using System;
using System.Collections;
using System.Collections.Generic;

namespace CO2_Interface.Data
{
    internal class Collections
    {
        internal static ArrayList ObjectList = new ArrayList();
        internal static ArrayList AlarmList = new ArrayList();

        internal static Queue<byte> SerialBuffer = new Queue<byte>();

        internal static Dictionary<byte, List<UInt16>> HistoryList = new Dictionary<byte, List<UInt16>>();   //dictionnaire qui lie les ID à des listes de données (UInt16 car les données sont reçus sur 2 octets)
    }
}
