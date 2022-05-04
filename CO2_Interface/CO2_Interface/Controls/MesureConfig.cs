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
    public partial class MesureConfig : UserControl
    {
        const int configStatusColumn = 1;

        public MesureConfig()
        {
            InitializeComponent();
        }

        private void comboBox_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data.FromSensor.graphListSecond.Clear();

            foreach (Data.FromSensor.Base obj in Data.Collections.ObjectList)
            {
                if (obj.ID.ToString() == comboBox_ID.Text)
                {
                    if (obj.Type == 0)
                    {
                        typeData_label.Text = "Alarme";
                    }
                    else if (obj.Type == 1)
                    {
                        typeData_label.Text = "CO²";
                    }
                    else if (obj.Type == 2)
                    {
                        typeData_label.Text = "Température";
                    }
                    else if (obj.Type == 3)
                    {
                        typeData_label.Text = "Humidité";
                    }
                }
            }
        }

        private void saveConfig_Button_Click(object sender, EventArgs e)
        {

            if (!(comboBox_ID.Text == "" || LowLimit_textBox.Text == "" || HighLimit_textBox.Text == ""))
            {
                if(Int32.Parse(LowLimit_textBox.Text) > Int32.Parse(HighLimit_textBox.Text))
                {
                    MessageBox.Show("LowLimit doit être inférieur à HighLimit");
                }
                else
                {
                    int posRow = 0;

                    foreach (Data.FromSensor.Measure obj in Data.Collections.ObjectList)
                    {
                        if (obj.ID.ToString() == comboBox_ID.Text)
                        {

                            obj.LowLimit = Int32.Parse(LowLimit_textBox.Text);
                            obj.HighLimit = Int32.Parse(HighLimit_textBox.Text);

                            obj.ConfigStatus = "Done";

                            MainForm.AlarmSettingsPage.comboBox_ID.Items.Add(obj.ID); //ajout de l'id dans le combobox Alarme

                            Data.Tables.MesureDataFromSensor.Rows[posRow][configStatusColumn] = obj.ConfigStatus;
                        }

                        posRow += 1;
                    }
                }
            }
        }
    }
}
