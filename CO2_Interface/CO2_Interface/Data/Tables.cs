using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace CO2_Interface.Data
{
    internal class Tables
    {
        internal static DataTable MesureDataFromSensor = new DataTable();
        internal static DataTable AlarmeDataFromSensor = new DataTable();
        internal static DataTable DataFromSensor = new DataTable();

        internal class ColumnsDataFromSensor
        {
            internal static DataColumn Serial = new DataColumn("Serial Number");
            internal static DataColumn ID = new DataColumn("ID");
            internal static DataColumn Type = new DataColumn("Type");
            internal static DataColumn Data = new DataColumn("Data");
            internal static DataColumn CheckSum = new DataColumn("Checksum");

        }

        internal class ColumnsMesure
        {
            internal static DataColumn ID = new DataColumn("ID");
            internal static DataColumn ConfigStatus = new DataColumn("Config Status");
            internal static DataColumn Type = new DataColumn("Type");
            internal static DataColumn BinaryData = new DataColumn("Data");
            internal static DataColumn LastUpdate = new DataColumn("Last Update");
            internal static DataColumn Alarm = new DataColumn("Alarm");
        }

        internal class ColumnsAlarme
        {
            internal static DataColumn ID = new DataColumn("ID");
            internal static DataColumn Type = new DataColumn("Type");
            internal static DataColumn CriticalMin = new DataColumn("Critical Min");
            internal static DataColumn WarningMin = new DataColumn("Warning Min");
            internal static DataColumn CriticalMax = new DataColumn("Critical Max");
            internal static DataColumn WarningMax = new DataColumn("Warning Max");
            internal static DataColumn Status = new DataColumn("Status");
        }
    }
   
}
