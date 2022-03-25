using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO2_Interface
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //---permet de mettre le windows forms en mode High DPI---//
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();
            //--------------------------------------------------------//

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        //---permet de mettre le windows forms en mode High DPI---//
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetProcessDPIAware();
        //--------------------------------------------------------//
    }
}
