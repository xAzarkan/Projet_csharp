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
    public partial class MesureConfig : UserControl
    {
        const int configStatusColumn = 1;
        string id = "", lowLimit = "", highLimit = "";

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

        private void loadConfig_Button_Click(object sender, EventArgs e)
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


                                changeDT(obj);
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

        private void changeDT(Data.FromSensor.Measure obj)
        {
            if(obj.LowLimit == 0 && obj.HighLimit == 0)
            {

            }
            else
            {
                DataRow row = Data.Tables.MesureDataFromSensor.Select("ID='" + obj.ID + "'").FirstOrDefault();

                row["Config Status"] = obj.ConfigStatus;
                //row["Warning Min"] = obj.WarningMin + typeOfData;
            }

        }

        private void saveConfig_Button_Click(object sender, EventArgs e)
        {

            if (!(comboBox_ID.Text == "" && LowLimit_textBox.Text == "" && HighLimit_textBox.Text == ""))
            {
                int posRow = 0;

                foreach(Data.FromSensor.Measure obj in Data.Collections.ObjectList)
                {
                    if(obj.ID.ToString() == comboBox_ID.Text)
                    {
                        
                        obj.LowLimit = Int32.Parse(LowLimit_textBox.Text);
                        obj.HighLimit = Int32.Parse(HighLimit_textBox.Text);

                        obj.ConfigStatus = "Done";

                        Data.Tables.MesureDataFromSensor.Rows[posRow][configStatusColumn] = obj.ConfigStatus;

                    }

                    posRow += 1;
                }
            }
            saveConfigCSV();
        }

        private void saveConfigCSV()
        {
           
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
    }
}
