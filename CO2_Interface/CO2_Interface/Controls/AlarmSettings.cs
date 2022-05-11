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
    public partial class AlarmSettings : UserControl
    {
        internal event EventHandler saveAlarmButtonClick; //création d'un eventhandler
        internal event EventHandler loadSettingsButtonClick;
        internal event EventHandler comboBoxAlarmSettingsChanged;

        public AlarmSettings()
        {
            InitializeComponent();
            
        }

        private void saveAlarmConfig_Button_Click(object sender, EventArgs e)
        {
            if (MainForm.AllowConfigAlarms)
            {
                this.saveAlarmButtonClick(this, e);
            }
            else
            {
                MessageBox.Show("Vous n'avez pas l'autorisation");
            }

        }

        internal void comboBox_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBoxAlarmSettingsChanged(this, e);
        }


        private void btLoadSettings_Click(object sender, EventArgs e)
        {
            this.loadSettingsButtonClick(this, e);
        }

        

    }

    
}

    
