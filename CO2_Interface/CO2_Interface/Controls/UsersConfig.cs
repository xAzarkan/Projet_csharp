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
        internal event EventHandler ButtonClick; //création d'un eventhandler
        public UsersConfig()
        {
            InitializeComponent();
            Rights_comboBox.Items.Add("Admin");
            Rights_comboBox.Items.Add("Master");
            Rights_comboBox.Items.Add("User");
        }

        private void AddUser_Button_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Collections.UserAccess.Tables[0].Rows.Add(new object[] { null, ID_box.Text, Password_box.Text, Rights_comboBox.SelectedIndex });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
