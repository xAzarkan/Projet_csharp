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

        internal static byte[] debutTrame = {0x55, 0x55, 0xAA};
        internal static byte[] finTrame = {0xAA, 0xAA, 0x55};

        internal static int cpt = 0;

        internal static void ReceptionHandler(object sender,SerialDataReceivedEventArgs e)
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
                                         
            Data.FromSensor.Base dataBrut = new Data.FromSensor.Base(0,0,0,0,0); //ici, ça ne sert pas encore à grand chose car on ne sait pas si l'objet est une Mesure ou une Alarme

            //Décrassage du SerialBuffer si les données ne nous interessent pas
            
            while ((Data.Collections.SerialBuffer.Count > 3) && (
            Data.Collections.SerialBuffer.ElementAt(0) != 0x55 ||
            Data.Collections.SerialBuffer.ElementAt(1) != 0x55 ||
            Data.Collections.SerialBuffer.ElementAt(2) != 0xAA))
            {
                Data.Collections.SerialBuffer.Dequeue();
                //Console.WriteLine("Toujours rien");
            }
            
            
            while(Data.Collections.SerialBuffer.Count > 13)
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

        }
        internal static void ObjToList(Data.FromSensor.Base newObj, DataTable dt, Controls.Mesure dgv, ComboBox comboBoxID)
        {
           

            if (dataInObjectList(newObj))
            {
                foreach (Data.FromSensor.Base obj in Data.Collections.ObjectList)
                {
                    if(obj.ID == newObj.ID)
                    {
                        DataRow row = dt.Select("ID='" + obj.ID + "'").FirstOrDefault();

                        obj.Data = newObj.Data;
                        row["Data"] = newObj.Data;
                    }
                }
            }
            else //pas dans l'ObjectList
            {
                comboBoxID.Items.Add(newObj.ID); //ajout de l'id dans le combobox

                Data.Collections.ObjectList.Add(newObj);
                dt.Rows.Add(new object[] { newObj.Serial, newObj.ID, newObj.Type, newObj.Data, newObj.CheckSum });
            }
    
            dgv.ObjectsGrid.DataSource = dt;

            updateGraph(comboBoxID);
           
        }

        internal static void updateGraph(ComboBox comboBoxID)
        {
            foreach(Data.FromSensor.Base obj in Data.Collections.ObjectList)
            {
                if(obj.ID.ToString() == comboBoxID.Text)
                {
                    Controls.Graphique.GraphUpdate(obj.Data);
                }
            }
        }
        internal static bool dataInObjectList(Data.FromSensor.Base newObj)
        {
            foreach(Data.FromSensor.Base oldObj in Data.Collections.ObjectList)
            {
                if(oldObj.ID == newObj.ID)
                {
                    return true;
                }
            }

            return false;

        }
    }
}
