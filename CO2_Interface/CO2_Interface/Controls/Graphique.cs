using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CO2_Interface.Controls
{
    public partial class Graphique : UserControl
    {
        static Queue<int> MyList;

        static Series GraphPoints;
        static Title GraphTitle;
        static ChartArea Area;

        public Graphique()
        {
            InitializeComponent();

            GraphBuilder();
        }

        private void Timer_200ms_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            if (MyList.Count > 99) MyList.Dequeue();
            MyList.Enqueue(rnd.Next(0, 1000)); 
           
            
            //GraphUpdate();
        }

        private void GraphBuilder()
        {
            MyList = new Queue<int>();
            GraphPoints = new Series("MySerie");
            GraphTitle = new Title("Taux de CO2");
            Area = new ChartArea("MyChartArea");

            GraphPoints.ChartType = SeriesChartType.Spline;
            GraphPoints.Color = System.Drawing.Color.DarkRed;

            Area.AxisX.InterlacedColor = System.Drawing.Color.White;
            Area.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            Area.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            Area.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            Area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            Area.BorderColor = System.Drawing.Color.DarkGray;
            Area.AxisY.IsStartedFromZero = false;
            Area.AxisY.Minimum = 0;
            Area.AxisY.Maximum = 70000;
            Area.AxisX.Minimum = 0;

            Chart.Titles.Add(GraphTitle);
            Chart.ChartAreas.Add(Area);
            Chart.Series.Add(GraphPoints);
        }
        internal static void GraphUpdate(int value)
        {

            GraphPoints.Points.Clear();

            if (Data.FromSensor.graphListSecond.Count >= 60) Data.FromSensor.graphListSecond.Dequeue();
            Data.FromSensor.graphListSecond.Enqueue(value);

            for(int i = 0; i < Data.FromSensor.graphListSecond.Count; i++)
            {
                GraphPoints.Points.AddXY(i, Data.FromSensor.graphListSecond.ElementAt(i));
            }

            
        }
    }
}
