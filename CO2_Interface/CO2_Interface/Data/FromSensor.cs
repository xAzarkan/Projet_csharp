using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO2_Interface.Data
{
    internal class FromSensor
    {
        internal static Queue<int> graphListSecond = new Queue<int>();

        internal class Base //forme brut de la donnée lorsqu'elle arrive
        { //on ne sait pas encore si c'est une Mesure ou une Alarme

            internal UInt16 Serial; //sur 2 octets donc --> 16 bits
            internal byte ID; // sur 1 octet donc --> 1 byte (8 bits)
            internal byte Type; //CO2, température, humidité
            internal UInt16 Data; //sur 2 octets
            internal byte CheckSum; //somme de tous les octets
                                    //internal Boolean IsConverted; // si IsConverted vaut faux alors ça veut dire qu'on ne sait pas encore son type, sinon on connait son type
            internal int Time;
            internal double ConvertedData;

            internal Base(UInt16 serial, byte id, byte type, UInt16 data, byte checksum)
            {
                Serial = serial; 
                ID = id;
                Type = type;
                Data = data;
                CheckSum = checksum;
                Time = 0;
                ConvertedData = (double)data/65535 * (120) - 40;
                //IsConverted = false;
            }
        }

        internal class Measure : Base
        { //le type est Mesure
            internal Int32 LowLimit; //définit par les éléctroniciens
            internal Int32 HighLimit; //définit par les éléctroniciens
            internal Int32 ConvertedData;
            internal UInt32 AlarmMaxPeriod; //définit par les éléctroniciens
            internal static class AlarmMin
            {
                internal static Int32 Warning;         //User Alarm
                internal static Int32 Critical;         //User Alarm
            }
            internal static class AlarmMax
            {
                internal static Int32 Warning;         //User Alarm
                internal static Int32 Critical;         //User Alarm
            }
            internal Measure() : base(0, 0, 0, 0, 0) 
            {
                LowLimit = 0;
                HighLimit = 0;
                ConvertedData = 0;
                AlarmMaxPeriod = 0;
                AlarmMin.Warning = 0;
                AlarmMin.Critical = 0;
                AlarmMax.Warning = 0;
                AlarmMax.Critical = 0;
            }
        }
    }
}
