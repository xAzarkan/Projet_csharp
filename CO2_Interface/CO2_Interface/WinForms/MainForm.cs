using System;
using System.IO.Ports;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Text;
using CO2_Interface.Controls;
using System.Linq;
using System.Drawing;

namespace CO2_Interface
{
    public partial class MainForm : Form //MainForm hérite de toutes les propriétés de Form (donne accès à la boite à outils)
    {

        internal Controls.Mesure MesurePage; //création d'une ampoule (sur base de UserControl)
        internal Controls.Alarme AlarmePage;
        internal Controls.Graphique GraphiquePage;
        internal Controls.Users UsersPage;
        internal Controls.UsersConfig UsersConfigPage;
        internal static Controls.AlarmSettings AlarmSettingsPage = new Controls.AlarmSettings();
        internal Controls.MesureConfig MesureConfigPage;
        internal Timer timer;
        internal bool dataTreatmentStarted = false;
        internal bool comPortOpened = false;
        internal static bool AllowCreateID = true;
        internal static bool AllowDestroyID = true;
        internal static bool AllowConfigAlarms = true;
        internal static bool UserCreation = true;

        internal string dataUnit = "";
        internal string dataType = "";
        internal Int32 defaultValue = 10000;

        //TOUT CE QUI CONCERNE LA PARTIE GRAPHIQUE
        public MainForm()
        {
            InitializeComponent(); //appelé au démaragge de l'interface graphique

            SerialPort.DataReceived += new SerialDataReceivedEventHandler(SerialDataHandler.Reception.ReceptionHandler);

            initTables();
            initUserAccess();

            this.MesurePage = new Controls.Mesure();
            this.AlarmePage = new Controls.Alarme();
            this.GraphiquePage = new Controls.Graphique();
            this.UsersPage = new Controls.Users();
            this.UsersConfigPage = new Controls.UsersConfig();
            this.MesureConfigPage = new Controls.MesureConfig();

            AlarmePage.ObjectsGrid.DataSource = Data.Tables.AlarmeDataFromSensor; //dgv qui se trouve dans le UserControl Alarme

            /* Mesure */
            //this.MesurePage.ButtonClick += new EventHandler(Mesure_InsideButton_Click);

            /* Alarme */
            this.AlarmePage.ButtonClick += new EventHandler(Alarme_InsideButton_Click);

            /* AlarmSettings */
            AlarmSettingsPage.saveAlarmButtonClick += new EventHandler(AlarmSettings_saveAlarmButton_Click);
            AlarmSettingsPage.loadSettingsButtonClick += new EventHandler(AlarmSettings_loadSettingsButton_Click);
            AlarmSettingsPage.comboBoxAlarmSettingsChanged += new EventHandler(AlarmSettings_comboBoxContent_Changed);

            /* MesureConfig */
            this.MesureConfigPage.saveMesureButtonClick += new EventHandler(MesureConfig_saveMesureButton_Click);
            this.MesureConfigPage.loadMesureButtonClick += new EventHandler(MesureConfig_loadMesureSettingsButton_Click);
            this.MesureConfigPage.comboBoxMesureSettingsChanged += new EventHandler(MesureConfig_comboBoxContent_Changed);

            ConnexionStatus_Label.Text = "CLOSE"; //sinon
            ConnexionStatus_Label.ForeColor = System.Drawing.Color.Red;

            comPort_comboBox.Items.Add("COM1");
            comPort_comboBox.Items.Add("COM2");
        }
        
        private void button_COM_Click(object sender, EventArgs e)
        {
            if(comPortOpened)
            {
                timer.Stop();

                SerialPort.Close();
                ConnexionStatus_Label.Text = "CLOSE"; //sinon
                ConnexionStatus_Label.ForeColor = System.Drawing.Color.Red;

                comPortOpened = false;

                ConnexionStatus_Label.Text = "CLOSE"; //sinon
                ConnexionStatus_Label.ForeColor = System.Drawing.Color.Red;

                COM_Button.Text = "Open COM port";
            }
            else
            {
                if(comPort_comboBox.Text == "")
                {
                    MessageBox.Show("Select the COM port to open first !");
                }
                else
                {
                    SerialPort.PortName = comPort_comboBox.Text;

                    try
                    {
                        SerialPort.Open(); //ouverture du serial port
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    ConnexionStatus_Label.Text = "OPEN"; //si le port est ouvert
                    ConnexionStatus_Label.ForeColor = System.Drawing.Color.Green;

                    comPortOpened = true;

                    COM_Button.Text = "Close COM port";

                    timer = new Timer();
                    timer.Tick += new EventHandler(timer_Tick);

                    timer.Interval = 1000;
                    timer.Start();
                }
            }
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SerialDataHandler.Reception.DataTreatment(Data.Tables.MesureDataFromSensor, MesurePage, MesureConfigPage.comboBox_ID, MesureConfigPage.LowLimit_textBox, MesureConfigPage.HighLimit_textBox, AlarmSettingsPage.comboBox_ID);
            //MesurePage.ObjectsGrid.FirstDisplayedScrollingRowIndex = MesurePage.ObjectsGrid.RowCount - 1;

            foreach (Data.FromSensor.Base obj in Data.Collections.ObjectList)
            {
                obj.Time++;
            }
        }

        private void btMesure_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();
            MyConfigContainer.Controls.Clear();

            
            MyConfigContainer.Controls.Add(MesureConfigPage);
            
            MyContainer.Controls.Add(MesurePage);
            
        }

        private void btAlarme_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();
            MyConfigContainer.Controls.Clear();

           
            MyConfigContainer.Controls.Add(AlarmSettingsPage);
            
            MyContainer.Controls.Add(AlarmePage);
            

            checkIfConfigured(AlarmSettingsPage.comboBox_ID);
        }

        private void initTables()
        {
            Data.Tables.MesureDataFromSensor.Columns.Add(Data.Tables.ColumnsMesure.ID); //associer des colonnes à la table que j'ai créer dans la classe Tables
            Data.Tables.MesureDataFromSensor.Columns.Add(Data.Tables.ColumnsMesure.ConfigStatus);
            Data.Tables.MesureDataFromSensor.Columns.Add(Data.Tables.ColumnsMesure.Type);
            Data.Tables.MesureDataFromSensor.Columns.Add(Data.Tables.ColumnsMesure.BinaryData);
            Data.Tables.MesureDataFromSensor.Columns.Add(Data.Tables.ColumnsMesure.LastUpdate);
            Data.Tables.MesureDataFromSensor.Columns.Add(Data.Tables.ColumnsMesure.Alarm);

            Data.Tables.AlarmeDataFromSensor.Columns.Add(Data.Tables.ColumnsAlarme.ID);
            Data.Tables.AlarmeDataFromSensor.Columns.Add(Data.Tables.ColumnsAlarme.Type);
            Data.Tables.AlarmeDataFromSensor.Columns.Add(Data.Tables.ColumnsAlarme.CriticalMin);
            Data.Tables.AlarmeDataFromSensor.Columns.Add(Data.Tables.ColumnsAlarme.WarningMin);
            Data.Tables.AlarmeDataFromSensor.Columns.Add(Data.Tables.ColumnsAlarme.CriticalMax);
            Data.Tables.AlarmeDataFromSensor.Columns.Add(Data.Tables.ColumnsAlarme.WarningMax);
            Data.Tables.AlarmeDataFromSensor.Columns.Add(Data.Tables.ColumnsAlarme.Status);


            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.ColumnsDataFromSensor.Serial);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.ColumnsDataFromSensor.ID);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.ColumnsDataFromSensor.Type);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.ColumnsDataFromSensor.Data);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.ColumnsDataFromSensor.CheckSum);

        }

        private void initUserAccess()
        {
            //UserTable
            Data.Tables.UserTable.TableName = "Users";
            Data.Tables.ColumnsUserTable.ID.Unique = true;
            Data.Tables.ColumnsUserTable.ID.AutoIncrement = true;
            Data.Tables.UserTable.Columns.Add(Data.Tables.ColumnsUserTable.ID);

            Data.Tables.ColumnsUserTable.Username.Unique = true;
            Data.Tables.UserTable.Columns.Add(Data.Tables.ColumnsUserTable.Username);

            Data.Tables.ColumnsUserTable.UserPassword.Unique = false;
            Data.Tables.UserTable.Columns.Add(Data.Tables.ColumnsUserTable.UserPassword);

            Data.Tables.ColumnsUserTable.Access_ID.Unique = false;
            Data.Tables.UserTable.Columns.Add(Data.Tables.ColumnsUserTable.Access_ID);

            /* AccessTable */
            Data.Tables.AccessTable.TableName = "Access";
            Data.Tables.ColumnsAccessTable.ID.Unique = true;
            Data.Tables.AccessTable.Columns.Add(Data.Tables.ColumnsAccessTable.ID);

            Data.Tables.ColumnsAccessTable.Name.Unique = true;
            Data.Tables.AccessTable.Columns.Add(Data.Tables.ColumnsAccessTable.Name);

            Data.Tables.ColumnsAccessTable.AllowCreateID.Unique = false;
            Data.Tables.AccessTable.Columns.Add(Data.Tables.ColumnsAccessTable.AllowCreateID);

            Data.Tables.ColumnsAccessTable.AllowDestroyID.Unique = false;
            Data.Tables.AccessTable.Columns.Add(Data.Tables.ColumnsAccessTable.AllowDestroyID);

            Data.Tables.ColumnsAccessTable.AllowConfigAlarm.Unique = false;
            Data.Tables.AccessTable.Columns.Add(Data.Tables.ColumnsAccessTable.AllowConfigAlarm);

            Data.Tables.ColumnsAccessTable.UserCreation.Unique = false;
            Data.Tables.AccessTable.Columns.Add(Data.Tables.ColumnsAccessTable.UserCreation);

            Data.Collections.UserAccess.Tables.Add(Data.Tables.UserTable);
            Data.Collections.UserAccess.Tables.Add(Data.Tables.AccessTable);

            DataColumn ParentColumn = Data.Collections.UserAccess.Tables["Access"].Columns["ID"];
            DataColumn ChildColumn = Data.Collections.UserAccess.Tables["Users"].Columns["Access type"];

            DataRelation relation = new DataRelation("Access2User",ParentColumn, ChildColumn);

            Data.Collections.UserAccess.Tables["Users"].ParentRelations.Add(relation);

            Data.Collections.UserAccess.Tables[1].Rows.Add(new object[] { 0, "AdminRights", true, true, true, true });
            Data.Collections.UserAccess.Tables[1].Rows.Add(new object[] { 1, "MasterRights", true, true, true, false });
            Data.Collections.UserAccess.Tables[1].Rows.Add(new object[] { 2, "NoRights", false, false, false, false });


        }

        private void btGraphics_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();
            MyConfigContainer.Controls.Clear();

            if(AllowConfigAlarms)
            {
                MyContainer.Controls.Add(GraphiquePage);
                MyConfigContainer.Controls.Add(AlarmSettingsPage);
                checkIfConfigured(AlarmSettingsPage.comboBox_ID);
            }

        }

        private void btUsers_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();
            MyConfigContainer.Controls.Clear();

            if(UserCreation)
            {
                MyContainer.Controls.Add(UsersPage);
            }
            MyConfigContainer.Controls.Add(UsersConfigPage);
            
            /* else
             {
                 MyConfigContainer.Controls.Add(UsersLoginPage);
             }*/

        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();
            MyConfigContainer.Controls.Clear();
        }

        private void Alarme_InsideButton_Click(object sender, EventArgs e)
        {

        }

        private void MesureConfig_saveMesureButton_Click(object sender, EventArgs e)
        {
            const int configStatusColumn = 1;

            if (!(MesureConfigPage.comboBox_ID.Text == "" || MesureConfigPage.LowLimit_textBox.Text == "" || MesureConfigPage.HighLimit_textBox.Text == ""))
            {
                if (Int32.Parse(MesureConfigPage.LowLimit_textBox.Text) > Int32.Parse(MesureConfigPage.HighLimit_textBox.Text))
                {
                    MessageBox.Show("LowLimit doit être inférieur à HighLimit");
                }
                else
                {
                    int posRow = 0;

                    foreach (Data.FromSensor.Measure obj in Data.Collections.ObjectList)
                    {
                        if (obj.ID.ToString() == MesureConfigPage.comboBox_ID.Text)
                        {

                            obj.LowLimit = Int32.Parse(MesureConfigPage.LowLimit_textBox.Text);
                            obj.HighLimit = Int32.Parse(MesureConfigPage.HighLimit_textBox.Text);

                            obj.ConfigStatus = "Done";

                           if (!(AlarmSettingsPage.comboBox_ID.Items.Contains(obj.ID.ToString())))
                            AlarmSettingsPage.comboBox_ID.Items.Add(obj.ID.ToString()); //ajout de l'id dans le combobox Alarme

                            Data.Tables.MesureDataFromSensor.Rows[posRow][configStatusColumn] = obj.ConfigStatus;
                        }

                        posRow += 1;
                    }
                }
            }
            saveMesureConfigInCSV();
        }

        private void MesureConfig_loadMesureSettingsButton_Click(object sender, EventArgs e)
        {
            string id, lowLimit, highLimit;
            int col;
            int i, j;
            Int32 defaultValue = 0;

            string FilePath = Directory.GetCurrentDirectory();
            FilePath += "\\Config.csv";

            try
            {
                StreamReader Reader = new StreamReader(FilePath, ASCIIEncoding.Default);
                string fileContent = Reader.ReadToEnd();
                String ConfigFile_Content;

                Reader.Close();

                i = fileContent.IndexOf("\r");

                var Text = string.Empty;
                for (j = 0; j < i; j++)
                {
                    Text += fileContent[j];
                }


                if (Text == "MeteoStation_Configuration_file")
                {
                    i = fileContent.IndexOf("Start");
                    int FileEnd = fileContent.IndexOf("End");

                    i += 7;

                    if (i >= FileEnd)
                    {
                        MessageBox.Show("Empty");
                    }

                    ConfigFile_Content = "";

                    while (i < FileEnd)
                    {
                        col = 0;
                        id = "";
                        lowLimit = "";
                        highLimit = "";
                        while (fileContent[i].ToString() != "\n")
                        {
                            if (fileContent[i].ToString() != ";")
                            {
                                if (col == 0) //ID
                                    id += fileContent[i].ToString();
                                else if (col == 1) //lowLimit
                                    lowLimit += fileContent[i].ToString();
                                else if (col == 2) //highLimit
                                    highLimit += fileContent[i].ToString();
                            }
                            else
                            {
                                col++;
                            }
                            i++;
                        }
                        foreach (Data.FromSensor.Measure obj in Data.Collections.ObjectList)
                        {
                            if (obj.ID.ToString() == id)
                            {
                                obj.LowLimit = Int32.Parse(lowLimit);
                                obj.HighLimit = Int32.Parse(highLimit);
                                obj.ConfigStatus = "Done";

                                if (!(obj.LowLimit == defaultValue && obj.HighLimit == defaultValue))
                                {
                                    obj.AlarmIsSet = true;
                                }


                                saveInMesureDataTable(obj);
                            }
                        }

                        i++;

                    }
                }
                else MessageBox.Show("Corrupted");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Not found");
            }
            catch (IOException)
            {
                MessageBox.Show("Not loaded");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //ConfigFile_Status.Text = "Error";
            }
        }

        private void saveInMesureDataTable(Data.FromSensor.Measure obj)
        {
            if (obj.LowLimit == 0 && obj.HighLimit == 0)
            {
                
            }
            else
            {
                DataRow row = Data.Tables.MesureDataFromSensor.Select("ID='" + obj.ID + "'").FirstOrDefault();

                row["Config Status"] = obj.ConfigStatus;
                //row["Warning Min"] = obj.WarningMin + typeOfData;
            }
        }

        private void MesureConfig_comboBoxContent_Changed(object sender, EventArgs e)
        {
            Data.FromSensor.graphListSecond.Clear();

            foreach (Data.FromSensor.Base obj in Data.Collections.ObjectList)
            {
                if (obj.ID.ToString() == MesureConfigPage.comboBox_ID.Text)
                {
                    if (obj.Type == 0)
                    {
                        MesureConfigPage.typeData_label.Text = "Alarme";
                    }
                    else if (obj.Type == 1)
                    {
                        MesureConfigPage.typeData_label.Text = "CO²";
                    }
                    else if (obj.Type == 2)
                    {
                        MesureConfigPage.typeData_label.Text = "Température";
                    }
                    else if (obj.Type == 3)
                    {
                        MesureConfigPage.typeData_label.Text = "Humidité";
                    }
                }
            }
        }

        private void saveMesureConfigInCSV()
        {
            string id = "", lowLimit = "", highLimit = "";

            var fileContent = string.Empty;

            fileContent += "MeteoStation_Configuration_file\r\n";

            fileContent += "ID;";
            fileContent += "LowLimit;";
            fileContent += "HighLimit";
            fileContent += "\r\n";
            fileContent += "Start";
            fileContent += "\r\n";

            foreach (Data.FromSensor.Measure obj in Data.Collections.ObjectList)
            {
                id = obj.ID.ToString();
                lowLimit = obj.LowLimit.ToString();
                highLimit = obj.HighLimit.ToString();

                fileContent += id + ";";
                fileContent += lowLimit + ";";
                fileContent += highLimit + ";";
                fileContent += "\r\n";
            }

            fileContent += "End";

            string filePath = Directory.GetCurrentDirectory();
            filePath += "\\Config.csv";

            StreamWriter Writer = new StreamWriter(filePath, false);
            Writer.Write(fileContent);
            Writer.Close();
        }

        private void AlarmSettings_saveAlarmButton_Click(object sender, EventArgs e)
        {
            if (!(AlarmSettingsPage.comboBox_ID.Text == "" || AlarmSettingsPage.WarningMin_textBox.Text == "" || AlarmSettingsPage.WarningMax_textBox.Text == "" || AlarmSettingsPage.CriticalMin_textBox.Text == "" || AlarmSettingsPage.CriticalMax_textBox.Text == ""))
            {
                if (Int32.Parse(AlarmSettingsPage.WarningMin_textBox.Text) > Int32.Parse(AlarmSettingsPage.WarningMax_textBox.Text))
                {
                    MessageBox.Show("WarningMin doit être inférieur à WarningMax");
                }
                else if (Int32.Parse(AlarmSettingsPage.CriticalMin_textBox.Text) > Int32.Parse(AlarmSettingsPage.CriticalMax_textBox.Text))
                {
                    MessageBox.Show("CriticalMin doit être inférieur à CriticalMax");
                }
                else if (Int32.Parse(AlarmSettingsPage.WarningMin_textBox.Text) < Int32.Parse(AlarmSettingsPage.CriticalMin_textBox.Text))
                {
                    MessageBox.Show("WarningMin doit être supérieur à CriticalMin");
                }
                else if (Int32.Parse(AlarmSettingsPage.WarningMax_textBox.Text) > Int32.Parse(AlarmSettingsPage.CriticalMax_textBox.Text))
                {
                    MessageBox.Show("WarningMax doit être inférieur à CriticalMax");
                }
                else
                {
                    foreach (Data.FromSensor.Measure obj in Data.Collections.ObjectList)
                    {
                        if (obj.ID.ToString() == AlarmSettingsPage.comboBox_ID.Text)
                        {

                            obj.WarningMin = Int32.Parse(AlarmSettingsPage.WarningMin_textBox.Text);
                            obj.WarningMax = Int32.Parse(AlarmSettingsPage.WarningMax_textBox.Text);
                            obj.CriticalMin = Int32.Parse(AlarmSettingsPage.CriticalMin_textBox.Text);
                            obj.CriticalMax = Int32.Parse(AlarmSettingsPage.CriticalMax_textBox.Text);
                            obj.AlarmIsSet = true;

                            saveInAlarmDataTable(obj);
                        }

                        saveAlarmConfigInCSV();
                    }
                }
            }
        }

        private void AlarmSettings_loadSettingsButton_Click(object sender, EventArgs e)
        {
            string id = "", type = "", warningMin = "", warningMax = "", criticalMin = "", criticalMax = "", status = "";
            int i, j;

            string FilePath = Directory.GetCurrentDirectory();
            FilePath += "\\AlarmConfig.csv";

            try
            {
                StreamReader Reader = new StreamReader(FilePath, ASCIIEncoding.Default);
                string fileContent = Reader.ReadToEnd();

                int numColonne = 0;

                Reader.Close();

                i = fileContent.IndexOf("\r");

                var Text = string.Empty;
                for (j = 0; j < i; j++) Text += fileContent[j];


                if (Text == "Alarm_Config_File")
                {
                    i = fileContent.IndexOf("Start");
                    int FileEnd = fileContent.IndexOf("End");

                    i += 7;

                    //if (i >= FileEnd) //ConfigFile_Status.Text = "Empty";

                    //ConfigFile_Content.Text = "";

                    while (i < FileEnd)
                    {
                        numColonne = 0;

                        id = "";
                        type = "";
                        warningMin = "";
                        warningMax = "";
                        criticalMin = "";
                        criticalMax = "";
                        status = "";

                        while (fileContent[i].ToString() != "\n")
                        {
                            if (fileContent[i].ToString() != ";")
                            {
                                if (numColonne == 0) //ID
                                    id += fileContent[i].ToString();
                                else if (numColonne == 1) //type
                                    type += fileContent[i].ToString();
                                else if (numColonne == 2) //warningMin
                                    warningMin += fileContent[i].ToString();
                                else if (numColonne == 3) //warningMax
                                    warningMax += fileContent[i].ToString();
                                else if (numColonne == 4) //criticalMin
                                    criticalMin += fileContent[i].ToString();
                                else if (numColonne == 5) //criticalMax
                                    criticalMax += fileContent[i].ToString();
                                else if (numColonne == 6) //status
                                    status += fileContent[i].ToString();
                            }
                            else
                            {
                                numColonne++;
                            }

                            i++;
                        }

                        foreach (Data.FromSensor.Measure obj in Data.Collections.ObjectList)
                        {
                            if (obj.ID.ToString() == id)
                            {
                                obj.WarningMin = Int32.Parse(warningMin);
                                obj.WarningMax = Int32.Parse(warningMax);
                                obj.CriticalMin = Int32.Parse(criticalMin);
                                obj.CriticalMax = Int32.Parse(criticalMax);
                                obj.ConfigStatus = status;

                                if(obj.ConfigStatus == "Done")
                                {
                                    if(!(AlarmSettingsPage.comboBox_ID.Items.Contains(obj.ID.ToString())))
                                        AlarmSettingsPage.comboBox_ID.Items.Add(obj.ID.ToString());
                                }
                                    

                                if (!(obj.WarningMin == defaultValue && obj.WarningMax == defaultValue && obj.CriticalMin == defaultValue && obj.CriticalMax == defaultValue))
                                {
                                    obj.AlarmIsSet = true;
                                }

                                checkTypeOfData(obj.ID.ToString());

                                saveInAlarmDataTable(obj);
                            }
                        }

                        i++;
                    }
                }
                else MessageBox.Show("Corrupted"); //ConfigFile_Status.Text = "Corrupted";
            }
            catch (FileNotFoundException)
            {
                //ConfigFile_Status.Text = "Not found";
            }
            catch (IOException)
            {
                //ConfigFile_Status.Text = "Not loaded";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //ConfigFile_Status.Text = "Error";
            }
        }

        private void saveAlarmConfigInCSV()
        {
            string id = "", type = "", warningMin = "", warningMax = "", criticalMin = "", criticalMax = "", status = "";

            var fileContent = string.Empty;

            fileContent += "Alarm_Config_File\r\n";

            fileContent += "ID;";
            fileContent += "Type;";
            fileContent += "WarningMin;";
            fileContent += "WarningMax;";
            fileContent += "CriticalMin;";
            fileContent += "CriticalMax;";
            fileContent += "Status;";
            fileContent += "\r\n";

            fileContent += "Start";
            fileContent += "\r\n";

            foreach (Data.FromSensor.Measure obj in Data.Collections.ObjectList)
            {

                id = obj.ID.ToString();
                type = obj.Type.ToString();
                warningMin = obj.WarningMin.ToString();
                warningMax = obj.WarningMax.ToString();
                criticalMin = obj.CriticalMin.ToString();
                criticalMax = obj.CriticalMax.ToString();
                status = obj.ConfigStatus.ToString();

                fileContent += id + ";";
                fileContent += type + ";";
                fileContent += warningMin + ";";
                fileContent += warningMax + ";";
                fileContent += criticalMin + ";";
                fileContent += criticalMax + ";";
                fileContent += status + ";";

                fileContent += "\r\n";
            }

            fileContent += "End";
            string filePath = Directory.GetCurrentDirectory();
            filePath += "\\AlarmConfig.csv";

            StreamWriter Writer = new StreamWriter(filePath, false);
            Writer.Write(fileContent);
            Writer.Close();
        }

        private void saveInAlarmDataTable(Data.FromSensor.Measure obj)
        {
            //Changement des infos dans la dgv alarme
            DataRow row = Data.Tables.MesureDataFromSensor.Select("ID='" + obj.ID + "'").FirstOrDefault();
            DataRow rowAlarmTable = Data.Tables.AlarmeDataFromSensor.Select("ID='" + obj.ID + "'").FirstOrDefault(); //pour mettre a jour la datatable Alarm

            if (obj.AlarmIsSet == true)
            {
                if (obj.ConvertedData < obj.CriticalMin)
                    obj.AlarmStatus = "Too low";
                else if (obj.ConvertedData > obj.CriticalMax)
                    obj.AlarmStatus = "Too high";
                else if (obj.ConvertedData < obj.WarningMin)
                    obj.AlarmStatus = "Low";
                else if (obj.ConvertedData > obj.WarningMax)
                    obj.AlarmStatus = "High";
                else
                    obj.AlarmStatus = "OK";

                if (alreadyInAlarmList(obj))
                {
                    row["Alarm"] = obj.AlarmStatus;

                    rowAlarmTable["ID"] = obj.ID;
                    rowAlarmTable["Type"] = dataType;
                    rowAlarmTable["Warning Min"] = obj.WarningMin + dataUnit;
                    rowAlarmTable["Critical Min"] = obj.CriticalMin + dataUnit;
                    rowAlarmTable["Warning Max"] = obj.WarningMax + dataUnit;
                    rowAlarmTable["Critical Max"] = obj.CriticalMax + dataUnit;
                    rowAlarmTable["Status"] = obj.AlarmStatus;


                    foreach (Data.FromSensor.Measure alarmObj in Data.Collections.AlarmList)
                    {
                        if (obj.ID == alarmObj.ID)
                        {
                            alarmObj.WarningMin = obj.WarningMin;
                            alarmObj.CriticalMin = obj.CriticalMin;
                            alarmObj.WarningMax = obj.WarningMax;
                            alarmObj.CriticalMax = obj.CriticalMax;
                        }
                    }
                }
                else
                {
                    Data.Collections.AlarmList.Add(obj);
                    Data.Tables.AlarmeDataFromSensor.Rows.Add(new object[] { obj.ID, dataType, obj.CriticalMin + dataUnit, obj.WarningMin + dataUnit, obj.CriticalMax + dataUnit, obj.WarningMax + dataUnit, obj.AlarmStatus });
                }

                Graphique.setGraphLimits(obj.WarningMin, obj.WarningMax, obj.CriticalMin, obj.CriticalMax, obj.Type);
            }

            AlarmePage.ObjectsGrid.Sort(AlarmePage.ObjectsGrid.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            AlarmePage.ObjectsGrid.ClearSelection();
        }

        private void AlarmSettings_comboBoxContent_Changed(object sender, EventArgs e)
        {
            checkTypeOfData(AlarmSettingsPage.comboBox_ID.Text);
            checkIfConfigured(AlarmSettingsPage.comboBox_ID);

            foreach(Data.FromSensor.Measure obj in Data.Collections.ObjectList)
            {
                if(obj.ID.ToString() == AlarmSettingsPage.comboBox_ID.Text)
                {
                    AlarmSettingsPage.CriticalMin_textBox.Text = obj.CriticalMin.ToString();
                    AlarmSettingsPage.CriticalMax_textBox.Text = obj.CriticalMax.ToString();
                    AlarmSettingsPage.WarningMin_textBox.Text = obj.WarningMin.ToString();
                    AlarmSettingsPage.WarningMax_textBox.Text = obj.WarningMax.ToString();
                }
            }
        }

        internal void checkIfConfigured(ComboBox comboBox)
        {
            foreach (Data.FromSensor.Measure obj in Data.Collections.ObjectList)
            {
                if (obj.ID.ToString() == AlarmSettingsPage.comboBox_ID.Text)
                {
                    if (obj.ConfigStatus == "Done")
                    {
                        AlarmSettingsPage.configStatus_label.Text = "Configured";
                        AlarmSettingsPage.configStatus_label.ForeColor = Color.Green;

                        Graphique.setLowHighLimits(obj.LowLimit, obj.HighLimit);
                    }
                    else
                    {
                        AlarmSettingsPage.configStatus_label.Text = "Not configured";
                        AlarmSettingsPage.configStatus_label.ForeColor = Color.Red;
                    }
                }
            }
        }

        internal void checkTypeOfData(String comboBox)
        {
            foreach (Data.FromSensor.Measure obj in Data.Collections.ObjectList)
            {
                if (obj.ID.ToString() == comboBox)
                {
                    if (obj.Type == 1)
                    {
                        dataType = "CO²";
                        if (AlarmSettingsPage.comboBox_ID.Text != "")
                            AlarmSettingsPage.typeData_label.Text = dataType;
                        dataUnit = " PPM";
                    }
                    else if (obj.Type == 2)
                    {
                        dataType = "Température";
                        if (AlarmSettingsPage.comboBox_ID.Text != "")
                            AlarmSettingsPage.typeData_label.Text = dataType;
                        dataUnit = " °C";
                    }
                    else if (obj.Type == 3)
                    {
                        dataType = "Humidité";
                        if (AlarmSettingsPage.comboBox_ID.Text != "")
                            AlarmSettingsPage.typeData_label.Text = dataType;
                        dataUnit = " %";
                    }

                    Graphique.setGraphLimits(obj.WarningMin, obj.WarningMax, obj.CriticalMin, obj.CriticalMax, obj.Type);


                    AlarmSettingsPage.WarningMin_textBox.Text = obj.WarningMin.ToString();
                    AlarmSettingsPage.WarningMax_textBox.Text = obj.WarningMax.ToString();
                    AlarmSettingsPage.CriticalMin_textBox.Text = obj.CriticalMin.ToString();
                    AlarmSettingsPage.CriticalMax_textBox.Text = obj.CriticalMax.ToString();
                }

            }
        }

        private bool alreadyInAlarmList(Data.FromSensor.Measure obj)
        {
            foreach (Data.FromSensor.Measure alarmObj in Data.Collections.AlarmList)
            {
                if (obj.ID == alarmObj.ID)
                    return true;
            }

            return false;
        }

        private void MesureConfig_InsideButton_Click(object sender, EventArgs e)
        {

        }

    }
}
