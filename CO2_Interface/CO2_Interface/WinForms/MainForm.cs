using System;
using System.IO.Ports;
using System.Data;
using System.Windows.Forms;

namespace CO2_Interface
{
    public partial class MainForm : Form //MainForm hérite de toutes les propriétés de Form (donne accès à la boite à outils)
    {

        private Controls.Mesure MesurePage; //création d'une ampoule (sur base de UserControl)
        private Controls.Alarme AlarmePage;
        private Controls.Graphique GraphiquePage;
        private Controls.Users UsersPage;
        private Controls.Settings SettingsPage;
        private Timer timer;

        private int counter = 0;

        //TOUT CE QUI CONCERNE LA PARTIE GRAPHIQUE
        public MainForm()
        {
            InitializeComponent(); //appelé au démaragge de l'interface graphique

            SerialPort.DataReceived += new SerialDataReceivedEventHandler(SerialDataHandler.Reception.ReceptionHandler);

            initTables();

            //j'instancie l'ampoulepage et le thermopage
            this.MesurePage = new Controls.Mesure();
            this.AlarmePage = new Controls.Alarme();
            this.GraphiquePage = new Controls.Graphique();
            this.UsersPage = new Controls.Users();
            this.SettingsPage = new Controls.Settings();

            //this.AmpoulePage.ButtonClick += new EventHandler(btMesureInside_Click); //si je clique sur le boutton dans l'ampoule, j'effectue ce qu'il y'a dans la fonction en paramètre
            //this.ThermoPage.ButtonClick += new EventHandler(btThermometreInside_Click);
            //this.GraphiquePage.ButtonClick += new EventHandler(btGraphicsInside_Click);

            ConnexionStatus_Label.Text = "CLOSE"; //sinon
            ConnexionStatus_Label.ForeColor = System.Drawing.Color.Red;
        }            
        private void button_COM_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort.Open(); //ouverture du serial port
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }

            if (SerialPort.IsOpen)
            {
                ConnexionStatus_Label.Text = "OPEN"; //si le port est ouvert
                ConnexionStatus_Label.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                ConnexionStatus_Label.Text = "CLOSE"; //sinon
                ConnexionStatus_Label.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void button_DataTreatment_Click(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);

            timer.Interval = 1000;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            //SerialDataHandler.Reception.DataTreatment(Data.Tables.DataFromSensor, MesurePage, comboBox_ID); //va à la classe Reception, et puis, va dans la méthode DataTreatment
            SerialDataHandler.Reception.DataTreatment(Data.Tables.MesureDataFromSensor, MesurePage, comboBox_ID); //va à la classe Reception, et puis, va dans la méthode DataTreatment
            MesurePage.ObjectsGrid.FirstDisplayedScrollingRowIndex = MesurePage.ObjectsGrid.RowCount - 1;
        }

        private void btMesure_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();
            MyContainer.Controls.Add(MesurePage);
        }

        private void btAlarme_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();
            MyContainer.Controls.Add(AlarmePage);
        }

        private void initTables()
        {
            Data.Tables.MesureDataFromSensor.Columns.Add(Data.Tables.ColumnsMesure.ID); //associer des colonnes à la table que j'ai créer dans la classe Tables
            Data.Tables.MesureDataFromSensor.Columns.Add(Data.Tables.ColumnsMesure.ConfigStatus);
            Data.Tables.MesureDataFromSensor.Columns.Add(Data.Tables.ColumnsMesure.Type);
            Data.Tables.MesureDataFromSensor.Columns.Add(Data.Tables.ColumnsMesure.BinaryData);
            Data.Tables.MesureDataFromSensor.Columns.Add(Data.Tables.ColumnsMesure.LastUpdate);
            Data.Tables.MesureDataFromSensor.Columns.Add(Data.Tables.ColumnsMesure.Alarm);

            Data.Tables.AlarmeDataFromSensor.Columns.Add(Data.Tables.ColumnsAlarme.ID);
            Data.Tables.AlarmeDataFromSensor.Columns.Add(Data.Tables.ColumnsAlarme.Type);
            Data.Tables.AlarmeDataFromSensor.Columns.Add(Data.Tables.ColumnsAlarme.CriticalMin);
            Data.Tables.AlarmeDataFromSensor.Columns.Add(Data.Tables.ColumnsAlarme.WarningMin);
            Data.Tables.AlarmeDataFromSensor.Columns.Add(Data.Tables.ColumnsAlarme.CriticalMax);
            Data.Tables.AlarmeDataFromSensor.Columns.Add(Data.Tables.ColumnsAlarme.WarningMax);
            Data.Tables.AlarmeDataFromSensor.Columns.Add(Data.Tables.ColumnsAlarme.Status);

            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.ColumnsDataFromSensor.Serial);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.ColumnsDataFromSensor.ID);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.ColumnsDataFromSensor.Type);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.ColumnsDataFromSensor.Data);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.ColumnsDataFromSensor.CheckSum);

        }

        /*
        private void btMesureInside_Click(object sender, EventArgs e)
        {//mise à jour du label counter
            counter++;
        }

        private void btThermometreInside_Click(object sender, EventArgs e)
        {
            counter++; 
        }
        */

        private void StopDataTreatment_Button_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void CLOSE_COM_Button_Click(object sender, EventArgs e)
        {
            SerialPort.Close();
            ConnexionStatus_Label.Text = "CLOSE"; //sinon
            ConnexionStatus_Label.ForeColor = System.Drawing.Color.Red;
        }

        private void btGraphics_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();
            MyContainer.Controls.Add(GraphiquePage);
        }

        private void comboBox_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Data.FromSensor.graphListSecond.Clear();
        }

        private void btUsers_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();
            MyContainer.Controls.Add(UsersPage);
        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            MyContainer.Controls.Clear();
            MyContainer.Controls.Add(SettingsPage);
        }
    }
}
