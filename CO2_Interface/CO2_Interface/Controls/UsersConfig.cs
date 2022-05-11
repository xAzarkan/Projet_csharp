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

                ID_box.Text = "";
                Password_box.Text =  "";
                Rights_comboBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            bool connexion = false;
            String userId = "";
            String name = "";
            String accessType = "";
            foreach (DataRow row in Data.Tables.UserTable.Rows)
            { 
                if(userName_box.Text.Equals(row["Name"]) && userPassword_box.Text.Equals(row["Password"]))
                {
                    connexion = true;
                    userId = row["ID"].ToString();
                    name = userName_box.Text;
                    accessType = row["Access type"].ToString();
                    userName_box.Text = "";
                    userPassword_box.Text = "";
                }
            }
            if (connexion == true)
            {
                MessageBox.Show("Bonjour : " + name);
                foreach (DataRow row in Data.Tables.AccessTable.Rows)
                {
                    if(accessType.Equals(row["ID"].ToString()))
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("Non");
                    }
                }
            }
            else
            {               
                MessageBox.Show("Compte inexistant");
            }

        }
    }
}
