using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO2_Interface.Controls
{
    public partial class AlarmSettings : UserControl
    {
        string typeOfData = "";

        public AlarmSettings()
        {
            InitializeComponent();
        }

        private void saveAlarmConfig_Button_Click(object sender, EventArgs e)
        {

            if (!(comboBox_ID.Text == "" && WarningMin_textBox.Text == "" && WarningMax_textBox.Text == "" && CriticalMin_textBox.Text == "" && CriticalMax_textBox.Text == ""))
            {
                foreach (Data.FromSensor.Measure obj in Data.Collections.ObjectList)
                {
                    if (obj.ID.ToString() == comboBox_ID.Text)
                    {

                        obj.WarningMin = Int32.Parse(WarningMin_textBox.Text);
                        obj.WarningMax = Int32.Parse(WarningMax_textBox.Text);
                        obj.CriticalMin = Int32.Parse(CriticalMin_textBox.Text);
                        obj.CriticalMax = Int32.Parse(CriticalMax_textBox.Text);

                        if(alreadyInAlarmList(obj))
                        {
                            DataRow row = Data.Tables.AlarmeDataFromSensor.Select("ID='" + obj.ID + "'").FirstOrDefault();

                            row["ID"] = obj.ID;
                            row["Type"] = typeData_label.Text;
                            row["Warning Min"] = obj.WarningMin + typeOfData;
                            row["Critical Min"] = obj.CriticalMin + typeOfData;
                            row["Warning Max"] = obj.WarningMax + typeOfData;
                            row["Critical Max"] = obj.CriticalMax + typeOfData;
                            row["Status"] = "None";

                            foreach(Data.FromSensor.Measure alarmObj in Data.Collections.AlarmList)
                            {
                                if(obj.ID == alarmObj.ID)
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
                            Data.Tables.AlarmeDataFromSensor.Rows.Add(new object[] { obj.ID, typeData_label.Text, obj.CriticalMin + typeOfData, obj.WarningMin + typeOfData, obj.CriticalMax + typeOfData, obj.WarningMax + typeOfData, "None" });
                        }

                        Graphique.setGraphLimits(obj.WarningMin, obj.WarningMax, obj.CriticalMin, obj.CriticalMax, obj.Type);
                    }

                    
                }
            }
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

        private void comboBox_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkTypeOfData(comboBox_ID);
        }

        private void checkTypeOfData(ComboBox comboBox)
        {
            foreach (Data.FromSensor.Measure obj in Data.Collections.ObjectList)
            {
                if (obj.ID.ToString() == comboBox_ID.Text)
                {
                    if (obj.Type == 1)
                    {
                        typeData_label.Text = "CO²";
                        typeOfData = " PPM";
                    }
                    else if (obj.Type == 2)
                    {
                        typeData_label.Text = "Température";
                        typeOfData = " °C";
                    }
                    else if (obj.Type == 3)
                    {
                        typeData_label.Text = "Humidité";
                        typeOfData = " %";
                    }

                    Graphique.setGraphLimits(obj.WarningMin, obj.WarningMax, obj.CriticalMin, obj.CriticalMax, obj.Type);
                }

            }
        }
    }
}

    
