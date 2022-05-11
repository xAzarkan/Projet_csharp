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

        internal event EventHandler ButtonClick; //création d'un eventhandler
        public Users()
        {
            InitializeComponent();
            UserTable_Grid.DataSource = Data.Collections.UserAccess.Tables[0];
            UserAccess_Grid.DataSource = Data.Collections.UserAccess.Tables[1];

        }
    }
}
