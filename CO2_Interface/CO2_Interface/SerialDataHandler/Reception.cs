using System.Windows.Forms;
using System.Data;
using System.IO.Ports;
using System.Collections.Generic;
using System.Linq;
using System;

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

        internal static void DataTreatment(DataTable dt, Controls.Mesure dgv, ComboBox comboBoxID)
        { //traitement de la donnée

            Data.FromSensor.Base dataBrut = new Data.FromSensor.Base(0, 0, 0, 0, 0); //ici, ça ne sert pas encore à grand chose car on ne sait pas si l'objet est une Mesure ou une Alarme
            int cpt = 1;
            //Décrassage du SerialBuffer si les données ne nous interessent pas

            while ((Data.Collections.SerialBuffer.Count > 3) && (
            Data.Collections.SerialBuffer.ElementAt(0) != 0x55 ||
            Data.Collections.SerialBuffer.ElementAt(1) != 0x55 ||
            Data.Collections.SerialBuffer.ElementAt(2) != 0xAA))
            {
                Data.Collections.SerialBuffer.Dequeue();
                //Console.WriteLine("Toujours rien");
            }


            while (Data.Collections.SerialBuffer.Count > 13)
            {
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

                Console.WriteLine("-------- DEBUT DE TRAME -------");

                Console.WriteLine("Serial Number : " + dataBrut.Serial);
                Console.WriteLine("ID : " + dataBrut.ID);
                Console.WriteLine("Type : " + dataBrut.Type);
                Console.WriteLine("Data : " + dataBrut.Data);
                Console.WriteLine("CheckSum : " + dataBrut.CheckSum);

                Console.WriteLine("----- FIN DE TRAME ------");
            }

            ObjToList(dataBrut, dt, dgv, comboBoxID);
            updateDataColumn(dt);


        }
        internal static void ObjToList(Data.FromSensor.Base newObj, DataTable dt, Controls.Mesure dgv, ComboBox comboBoxID)
        {
           

            if (dataInObjectList(newObj))
            {
                foreach (Data.FromSensor.Base obj in Data.Collections.ObjectList)
                {
                    DataRow row = dt.Select("ID='" + obj.ID + "'").FirstOrDefault();
                    if (obj.ID == newObj.ID)
                    {
                        obj.Data = newObj.Data;
                        obj.Time = 0;
                        row["Data"] = newObj.Data;
                    }
                    row["Last Update"] = obj.Time + " secondes";
                    obj.Time++;
                }

                Data.Collections.HistoryList[newObj.ID].Add(newObj.Data);

            }
            else //pas dans l'ObjectList
            {
                comboBoxID.Items.Add(newObj.ID); //ajout de l'id dans le combobox

                Data.Collections.ObjectList.Add(newObj);

               // dt.Rows.Add(new object[] { newObj.Serial, newObj.ID, newObj.Type, newObj.Data, newObj.Time + " secondes"/*newObj.CheckSum*/ });
                dt.Rows.Add(new object[] { newObj.ID, "None", newObj.Type, newObj.Data, newObj.Time + " secondes", "Pas d'alarme"});


                Data.Collections.HistoryList.Add(newObj.ID, new List<UInt16>());
            }

            dgv.ObjectsGrid.DataSource = dt;

            updateGraph(comboBoxID);

        }

        internal static void updateGraph(ComboBox comboBoxID)
        {
            if (comboBoxID.Text != "")
            {
                Data.FromSensor.graphListSecond.Clear();

                foreach (Data.FromSensor.Base obj in Data.Collections.ObjectList)
                {
                    Data.Collections.HistoryList[obj.ID].Add(obj.Data);
                }

                foreach (UInt16 data in Data.Collections.HistoryList[byte.Parse(comboBoxID.Text)])
                {
                    Controls.Graphique.GraphUpdate(data);
                }
            }

        }

        internal static bool dataInObjectList(Data.FromSensor.Base newObj)
        {
            foreach (Data.FromSensor.Base oldObj in Data.Collections.ObjectList)
            {
                if (oldObj.ID == newObj.ID)
                {
                    return true;
                }
            }

            return false;

        }

        internal static void updateDataColumn(DataTable dt)
        {
            int TypeColumn = 2;
            int DataColumn = 3;
            string valeurString;
            double valeurDouble;

            int posRow = 0;

            foreach(Data.FromSensor.Base obj in Data.Collections.ObjectList)
            {
                if(obj.Type == 0)
                {
                    dt.Rows[posRow][TypeColumn] = "Alarme"; 
                }
                else if(obj.Type == 1)
                {
                    dt.Rows[posRow][TypeColumn] = "CO²";
                    valeurDouble = obj.Data;
                    valeurDouble = (valeurDouble / 65535) * (1000 - 0) + 0;
                    valeurDouble = Math.Round(valeurDouble);
                    valeurString = valeurDouble.ToString() + " PPM";

                    dt.Rows[posRow][DataColumn] = valeurString;

                }
                else if (obj.Type == 2)
                {
                    dt.Rows[posRow][TypeColumn] = "Température";

                    //Conversion de la data
                    
                    valeurDouble = obj.Data;
                    valeurDouble = (valeurDouble / 65535) * (30 + 10) - 10;
                    valeurDouble = Math.Round(valeurDouble, 2);
                    valeurString = valeurDouble.ToString() + " °C";
                    
                    dt.Rows[posRow][DataColumn] = valeurString;
                }
                else if (obj.Type == 3)
                {
                    dt.Rows[posRow][TypeColumn] = "Humidité";
                    dt.Rows[posRow][DataColumn] = "0 %";
                }

                posRow += 1;
            }
           
        }

        
        
    }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
}
