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
        public Users()
        {
            InitializeComponent();
            User_Grid.DataSource = Data.Collections.UserAccess.Tables[0];

        }
    }
}
