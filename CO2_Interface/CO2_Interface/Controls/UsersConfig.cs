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
    public partial class UsersConfig : UserControl
    {
        internal event EventHandler loginButtonClick; //création d'un eventhandler
        internal event EventHandler addUserButtonClick;
        internal event EventHandler comboBoxRightsChanged;
        public UsersConfig()
        {
            InitializeComponent();
            Rights_comboBox.Items.Add("Admin");
            Rights_comboBox.Items.Add("Master");
            Rights_comboBox.Items.Add("User");
        }

        private void AddUser_Button_Click(object sender, EventArgs e)
        {
            this.addUserButtonClick(this, e);
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            this.loginButtonClick(this, e);
        }
    }
}
