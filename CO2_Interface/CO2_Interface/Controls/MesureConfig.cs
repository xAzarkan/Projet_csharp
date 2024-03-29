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
            if (MainForm.AllowConfigAlarms)
            {
                this.saveMesureButtonClick(this, e);
            }
            else
            {
                MessageBox.Show("Vous n'avez pas l'autorisation");
            }
        }

    }
}
