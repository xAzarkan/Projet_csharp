using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace CO2_Interface.Data
{
    internal class Collections
    {
        internal static ArrayList ObjectList = new ArrayList();
        internal static ArrayList AlarmList = new ArrayList();

        internal static Queue<byte> SerialBuffer = new Queue<byte>();

        internal static Dictionary<byte, List<Int32>> HistoryList = new Dictionary<byte, List<Int32>>();   //dictionnaire qui lie les ID à des listes de données (Int32 car les données converties sont définies en Int32)

        internal static DataSet UserAccess = new DataSet();
    }
}
