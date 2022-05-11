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
        internal event EventHandler saveMesureButtonClick; //création d'un eventhandler
        internal event EventHandler loadMesureButtonClick; //création d'un eventhandler
        internal event EventHandler comboBoxMesureSettingsChanged; //création d'un eventhandler

        public MesureConfig()
        {
            InitializeComponent();
            if (MainForm.AllowCreateID)
            {
                //MessageBox.Show("je suis true");
                saveConfig_Button.Enabled = true;
            }
            else
            {
                saveConfig_Button.Enabled = false;
            }
        }

        private void comboBox_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxMesureSettingsChanged(this, e);
        }

        private void loadConfig_Button_Click(object sender, EventArgs e)
        {
            this.loadMesureButtonClick(this, e);
        }

        private void saveConfig_Button_Click(object sender, EventArgs e)
        {
            this.saveMesureButtonClick(this, e);
        }

    }
}
