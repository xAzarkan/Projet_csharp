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
    public partial class Users : UserControl
    {

        internal event EventHandler updateDBDataButtonClick; //création d'un eventhandler
        public Users()
        {
            InitializeComponent();
            UserTable_Grid.DataSource = Data.Collections.UserAccess.Tables[0];
            UserAccess_Grid.DataSource = Data.Collections.UserAccess.Tables[1];

            UserTable_Grid.ClearSelection();
            UserAccess_Grid.ClearSelection();

        }

        private void Update_Informations_Click(object sender, EventArgs e)
        {
            this.updateDBDataButtonClick(this, e);
        }
    }
}
