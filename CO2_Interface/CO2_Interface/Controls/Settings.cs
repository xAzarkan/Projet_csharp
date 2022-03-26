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
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void saveSettings_Button_Click(object sender, EventArgs e)
        {
            int WarningMin = int.Parse(WarningMin_textBox.Text);
            int WarningMax = int.Parse(WarningMax_textBox.Text);
            int CriticalMin = int.Parse(CriticalMin_textBox.Text);
            int CriticalMax = int.Parse(CriticalMax_textBox.Text);

            Graphique.setGraphLimits(WarningMin, WarningMax, CriticalMin, CriticalMax);
        }
    }
}
