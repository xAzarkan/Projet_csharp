using System.Windows.Forms;
using System.Data;
using System.IO.Ports;
using System.Collections.Generic;
using System.Linq;
using System;
using CO2_Interface.Data;

namespace CO2_Interface.SerialDataHandler //namespace = CO2_Interface
{
    internal static class Reception
    {

        internal static byte[] debutTrame = { 0x55, 0x55, 0xAA };
        internal static byte[] finTrame = { 0xAA, 0xAA, 0x55 };

        internal static int cpt = 0;

        internal static void ReceptionHandler(object sender, SerialDataReceivedEventArgs e)
        { //reception de la donnée et stockage dans une QueueList (SerialBuffer --> voir dans Collections.cs)

            SerialPort sp = (SerialPort)sender;
            byte[] ByteArray = new byte[sp.BytesToRead];

            sp.Read(ByteArray, 0, ByteArray.Length);

            for (int i = 0; i < ByteArray.Length; i++)
            {
                Data.Collections.SerialBuffer.Enqueue(ByteArray[i]); //on ajoute la donnée tout devant dans la liste (système de file FIFO)
            }
        }

        internal static void DataTreatment(DataTable dt, Controls.Mesure dgv, ComboBox measureComboBoxID, TextBox lowLimit, TextBox highLimit, ComboBox alarmComboBoxID)
        { //traitement de la donnée

            //Décrassage du SerialBuffer si les données ne nous interessent pas

            while ((Data.Collections.SerialBuffer.Count > 3) && (
            Data.Collections.SerialBuffer.ElementAt(0) != 0x55 ||
            Data.Collections.SerialBuffer.ElementAt(1) != 0x55 ||
            Data.Collections.SerialBuffer.ElementAt(2) != 0xAA))
            {
                Data.Collections.SerialBuffer.Dequeue();
            }


            while (Data.Collections.SerialBuffer.Count > 13)
            {
                Data.FromSensor.Measure dataBrut = new Data.FromSensor.Measure(); //ici, ça ne sert pas encore à grand chose car on ne sait pas si l'objet est une Mesure ou une Alarme

                Data.Collections.SerialBuffer.Dequeue(); // on dequeue les 3 premiers octets qui sont le début de trame
                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();

                //The following data's shall be extracted from Queue List
                dataBrut.Serial = Data.Collections.SerialBuffer.Dequeue();
                dataBrut.Serial <<= 8; //décalage à gauche
                dataBrut.Serial += Data.Collections.SerialBuffer.Dequeue();
                dataBrut.ID = Data.Collections.SerialBuffer.Dequeue();
                dataBrut.Type = Data.Collections.SerialBuffer.Dequeue(); //retourne le premier élément de la QueueList (SerialBuffer)
                dataBrut.Data = Data.Collections.SerialBuffer.Dequeue();
                dataBrut.Data <<= 8; //décalage à gauche
                dataBrut.Data += Data.Collections.SerialBuffer.Dequeue();
                dataBrut.CheckSum = Data.Collections.SerialBuffer.Dequeue();

                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();


                //This part shall be modified once rules have been defined

                /*
                Console.WriteLine("-------- DEBUT DE TRAME -------");

                Console.WriteLine("Serial Number : " + dataBrut.Serial);
                Console.WriteLine("ID : " + dataBrut.ID);
                Console.WriteLine("Type : " + dataBrut.Type);
                Console.WriteLine("Data : " + dataBrut.Data);
                Console.WriteLine("CheckSum : " + dataBrut.CheckSum);

                Console.WriteLine("----- FIN DE TRAME ------"); 
                */
                ObjToList(dataBrut, dt, dgv, measureComboBoxID, alarmComboBoxID);


            }

            updateDataColumn(dt, lowLimit, highLimit);


        }
        internal static void ObjToList(Data.FromSensor.Measure newObj, DataTable dt, Controls.Mesure dgv, ComboBox measureComboBoxID, ComboBox alarmComboBoxID)
        {
            if (dataInObjectList(newObj))
            {
                foreach (Data.FromSensor.Measure obj in Data.Collections.ObjectList)
                {
                   DataRow row = dt.Select("ID='" + obj.ID + "'").FirstOrDefault();
                   DataRow rowAlarmTable = Data.Tables.AlarmeDataFromSensor.Select("ID='" + obj.ID + "'").FirstOrDefault(); //pour mettre a jour la datatable Alarm

                     if (obj.ID == newObj.ID)
                     {
                         obj.Data = newObj.Data;
                         obj.Time = 0;
                         row["Data"] = newObj.Data;
                    }
                     row["Last Update"] = obj.Time + " secondes";
                     
                    if(obj.AlarmIsSet == true)
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

                        if(obj.AlarmIsSet)
                        {
                            row["Alarm"] = obj.AlarmStatus;
                            rowAlarmTable["Status"] = obj.AlarmStatus;
                        }
                        
                    }
                }

            }
            else //pas dans l'ObjectList
            {
                measureComboBoxID.Items.Add(newObj.ID.ToString()); //ajout de l'id dans le combobox Mesure

                Data.Collections.ObjectList.Add(newObj);

                dt.Rows.Add(new object[] { newObj.ID, newObj.ConfigStatus, newObj.Type, newObj.Data, newObj.Time + " secondes", newObj.AlarmStatus});

                Data.Collections.HistoryList.Add(newObj.ID, new List<Int32>());
            }

            dgv.ObjectsGrid.DataSource = dt;

            //affichage des id dans l'ordre
            dgv.ObjectsGrid.Sort(dgv.ObjectsGrid.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            dgv.ObjectsGrid.ClearSelection();
            updateGraph(alarmComboBoxID);
        }

        internal static void updateGraph(ComboBox comboBoxID)
        {
            if (comboBoxID.Text != "")
            {
                Data.FromSensor.graphListSecond.Clear();

                if(Data.Collections.HistoryList[byte.Parse(comboBoxID.Text)].Count == 0)
                {
                    Controls.Graphique.GraphPoints.Points.Clear(); //si aucune donnée à afficher pour cet ID alors on clear le graph 
                }
                else
                {
                    foreach (Int32 data in Data.Collections.HistoryList[byte.Parse(comboBoxID.Text)])
                    {
                        Controls.Graphique.GraphUpdate(data);
                    }
                }
            }

        }

        internal static bool dataInObjectList(Data.FromSensor.Measure newObj)
        {
            foreach (Data.FromSensor.Measure oldObj in Data.Collections.ObjectList)
            {
                if (oldObj.ID == newObj.ID)
                {
                    return true;
                }
            }

            return false;

        }

        internal static void updateDataColumn(DataTable dt, TextBox lowLimit, TextBox highLimit)
        {
            const int TypeColumn = 2;
            const int DataColumn = 3;
            string valeurString;
            double valeurDataBrut;

            Int32 lengthOfBits = 65535;

            int posRow = 0;

            foreach(Data.FromSensor.Measure obj in Data.Collections.ObjectList)
            {
                if(obj.Type == 0)
                {
                    dt.Rows[posRow][TypeColumn] = "Alarme"; 
                }
                else if(obj.Type == 1)
                {
                    dt.Rows[posRow][TypeColumn] = "CO²";
                    valeurDataBrut = obj.Data;
                    obj.ConvertedData = (Int32)((valeurDataBrut / lengthOfBits) * (obj.HighLimit - obj.LowLimit) + obj.LowLimit);

                    valeurString = obj.ConvertedData.ToString() + " PPM";

                    dt.Rows[posRow][DataColumn] = valeurString;

                }
                else if (obj.Type == 2)
                {
                    dt.Rows[posRow][TypeColumn] = "Température";

                    //Conversion de la data

                    valeurDataBrut = obj.Data;
                    obj.ConvertedData = (Int32)((valeurDataBrut / lengthOfBits) * (obj.HighLimit - obj.LowLimit) + obj.LowLimit);
                    valeurDataBrut = Math.Round(valeurDataBrut, 2);
                    valeurString = obj.ConvertedData.ToString() + " °C";

                    dt.Rows[posRow][DataColumn] = valeurString;
                }
                else if (obj.Type == 3)
                {
                    dt.Rows[posRow][TypeColumn] = "Humidité";

                    valeurDataBrut = obj.Data;
                    obj.ConvertedData = (Int32)((valeurDataBrut / lengthOfBits) * (obj.HighLimit - obj.LowLimit) + obj.LowLimit);
                    valeurDataBrut = Math.Round(valeurDataBrut, 2);
                    valeurString = obj.ConvertedData.ToString() + " %";

                    dt.Rows[posRow][DataColumn] = valeurString;
                }

                if (obj.ConfigStatus == "Done")
                {
                    Data.Collections.HistoryList[obj.ID].Add(obj.ConvertedData);

                    if(obj.AlarmIsSet == true)
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
                    }
                }

                posRow += 1;
            }
           
        }

        
        
    }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
}
