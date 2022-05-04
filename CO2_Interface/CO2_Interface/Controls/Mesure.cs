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
    public partial class Mesure : UserControl //tableau de mesures
    {
        internal event EventHandler ButtonClick; //création d'un eventhandler

        public Mesure() //changer le nom en "Mesure"
        {
            InitializeComponent();
            
        }
/*
        private void btMesureInside_Click(object sender, EventArgs e)
        {
            this.ButtonClick(this, e); //je donne en paramètre à l'eventhandler l'objet et l'eventargs
        } */
    }
}
