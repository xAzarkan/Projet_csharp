using System;
using System.IO.Ports;
using System.Data;
using System.Windows.Forms;

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

            if(AllowCreateID)
            {
                MyConfigContainer.Controls.Add(MesureConfigPage);
            }
            MyContainer.Controls.Add(MesurePage);
            
        }

        private void btAlarme_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();
            MyConfigContainer.Controls.Clear();

            if(AllowCreateID)
            {
                MyConfigContainer.Controls.Add(AlarmSettingsPage);
            }
            MyContainer.Controls.Add(AlarmePage);
            

            AlarmSettingsPage.checkIfConfigured(AlarmSettingsPage.comboBox_ID);
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

        /*
        private void btMesureInside_Click(object sender, EventArgs e)
        {//mise à jour du label counter
            counter++;
        }

        private void btThermometreInside_Click(object sender, EventArgs e)
        {
            counter++; 
        }
        */

        private void btGraphics_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();
            MyConfigContainer.Controls.Clear();

            if(AllowConfigAlarms)
            {
                MyContainer.Controls.Add(GraphiquePage);
                MyConfigContainer.Controls.Add(AlarmSettingsPage);
                AlarmSettingsPage.checkIfConfigured(AlarmSettingsPage.comboBox_ID);
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

    }
}
