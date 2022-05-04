using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO2_Interface.Controls
{
    public partial class AlarmSettings : UserControl
    {
        string dataUnit = "";
        string dataType = "";
        Int32 defaultValue = 10000;

        public AlarmSettings()
        {
            InitializeComponent();
        }

        private void saveAlarmConfig_Button_Click(object sender, EventArgs e)
        {
            if (!(comboBox_ID.Text == "" || WarningMin_textBox.Text == "" || WarningMax_textBox.Text == "" || CriticalMin_textBox.Text == "" || CriticalMax_textBox.Text == ""))
            {
                if(Int32.Parse(WarningMin_textBox.Text) > Int32.Parse(WarningMax_textBox.Text))
                {
                    MessageBox.Show("WarningMin doit être inférieur à WarningMax");
                }
                else if(Int32.Parse(CriticalMin_textBox.Text) > Int32.Parse(CriticalMax_textBox.Text))
                {
                    MessageBox.Show("CriticalMin doit être inférieur à CriticalMax");
                }
                else if(Int32.Parse(WarningMin_textBox.Text) < Int32.Parse(CriticalMin_textBox.Text))
                {
                    MessageBox.Show("WarningMin doit être supérieur à CriticalMin");
                }
                else if (Int32.Parse(WarningMax_textBox.Text) > Int32.Parse(CriticalMax_textBox.Text))
                {
                    MessageBox.Show("WarningMax doit être inférieur à CriticalMax");
                }
                else
                {
                    foreach(Data.FromSensor.Measure obj in Data.Collections.ObjectList)
                {
                        if (obj.ID.ToString() == comboBox_ID.Text)
                        {

                            obj.WarningMin = Int32.Parse(WarningMin_textBox.Text);
                            obj.WarningMax = Int32.Parse(WarningMax_textBox.Text);
                            obj.CriticalMin = Int32.Parse(CriticalMin_textBox.Text);
                            obj.CriticalMax = Int32.Parse(CriticalMax_textBox.Text);
                            obj.AlarmIsSet = true;

                            saveInDataTable(obj);                        
                        }

                        saveConfigInCSV();
                    }
                }
            }

        }

        private void saveConfigInCSV()
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

        private bool alreadyInAlarmList(Data.FromSensor.Measure obj)
        {
            foreach(Data.FromSensor.Measure alarmObj in Data.Collections.AlarmList)
            {
                if (obj.ID == alarmObj.ID)
                    return true;
            }

            return false;
        }

        internal void comboBox_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkTypeOfData(comboBox_ID.Text);
            checkIfConfigured(comboBox_ID);
        }

        internal void checkIfConfigured(ComboBox comboBox)
        {
            foreach (Data.FromSensor.Measure obj in Data.Collections.ObjectList)
            {
                if (obj.ID.ToString() == comboBox_ID.Text)
                {
                    if(obj.ConfigStatus == "Done")
                    {
                        configStatus_label.Text = "Configured";
                        configStatus_label.ForeColor = Color.Green;

                        Graphique.setLowHighLimits(obj.LowLimit, obj.HighLimit);
                    }
                    else
                    {
                        configStatus_label.Text = "Not configured";
                        configStatus_label.ForeColor = Color.Red;
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
                        if (comboBox_ID.Text != "")
                            typeData_label.Text = dataType;
                        dataUnit = " PPM";
                    }
                    else if (obj.Type == 2)
                    {
                        dataType = "Température";
                        if (comboBox_ID.Text != "")
                            typeData_label.Text = dataType;
                        dataUnit = " °C";
                    }
                    else if (obj.Type == 3)
                    {
                        dataType = "Humidité";
                        if (comboBox_ID.Text != "")
                            typeData_label.Text = dataType;
                        dataUnit = " %";
                    }

                    Graphique.setGraphLimits(obj.WarningMin, obj.WarningMax, obj.CriticalMin, obj.CriticalMax, obj.Type);
                }

            }
        }

        private void btLoadSettings_Click(object sender, EventArgs e)
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

                        while(fileContent[i].ToString() != "\n")
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

                        foreach(Data.FromSensor.Measure obj in Data.Collections.ObjectList)
                        {
                            if(obj.ID.ToString() == id)
                            {
                                obj.WarningMin = Int32.Parse(warningMin);
                                obj.WarningMax = Int32.Parse(warningMax);
                                obj.CriticalMin = Int32.Parse(criticalMin);
                                obj.CriticalMax = Int32.Parse(criticalMax);
                                obj.ConfigStatus = status;

                                if (!(obj.WarningMin == defaultValue && obj.WarningMax == defaultValue && obj.CriticalMin == defaultValue && obj.CriticalMax == defaultValue)) 
                                {
                                    //MessageBox.Show("id:" + obj.ID + " --> alarme configurée");
                                    obj.AlarmIsSet = true;
                                }

                                checkTypeOfData(obj.ID.ToString());

                                saveInDataTable(obj);
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

        internal void saveInDataTable(Data.FromSensor.Measure obj)
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
        }

    }

    
}

    
