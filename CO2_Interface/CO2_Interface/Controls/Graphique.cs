﻿using System;
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

        public static Series GraphPoints;
        public static Title GraphTitle;
        public static ChartArea Area;

        static int WarningMin = 10000;
        static int WarningMax = 10000;
        static int CriticalMin = 10000;
        static int CriticalMax = 10000;

        static StripLine criticalMaxStrip = new StripLine();
        static StripLine warningMaxStrip = new StripLine();
        static StripLine criticalMinStrip = new StripLine();
        static StripLine warningMinStrip = new StripLine();

        static int maxPPM = 1500;
        static int minPPM = 0;


        static int maxTemp = 50;
        static int minTemp = -10;

        static int maxHum = 100;
        static int minHum = 0;


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

        }

        public void GraphBuilder()
        {
            MyList = new Queue<int>();
            GraphPoints = new Series("MySerie");
            //GraphTitle = new Title("Graphique");
            Area = new ChartArea("MyChartArea");

            GraphPoints.ChartType = SeriesChartType.Spline;
            GraphPoints.Color = System.Drawing.Color.Black;

            Area.AxisX.InterlacedColor = System.Drawing.Color.White;
            Area.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            Area.AxisY.MajorGrid.LineColor = System.Drawing.Color.Black;
            Area.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            Area.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            Area.BorderColor = System.Drawing.Color.DarkGray;
            Area.AxisY.IsStartedFromZero = false;
            Area.AxisY.Minimum = 0;
            Area.AxisY.Maximum = 80000;
            Area.AxisX.Minimum = 0;

            //Chart.Titles.Add(GraphTitle);
            Chart.ChartAreas.Add(Area);

            criticalMaxStrip.Interval = 0;
            criticalMaxStrip.IntervalOffset = CriticalMax;
            criticalMaxStrip.StripWidth = 0.0;
            criticalMaxStrip.BorderColor = Color.FromArgb(100, Color.Red);
            criticalMaxStrip.BorderDashStyle = ChartDashStyle.Solid;
            criticalMaxStrip.BorderWidth = 3;
            Chart.ChartAreas[0].AxisY.StripLines.Add(criticalMaxStrip);

            warningMaxStrip.Interval = 0;
            warningMaxStrip.IntervalOffset = WarningMax;
            warningMaxStrip.StripWidth = 0.0;
            warningMaxStrip.BorderColor = Color.FromArgb(100, Color.Orange);
            warningMaxStrip.BorderDashStyle = ChartDashStyle.Solid;
            warningMaxStrip.BorderWidth = 3;
            Chart.ChartAreas[0].AxisY.StripLines.Add(warningMaxStrip);

            warningMinStrip.Interval = 0;
            warningMinStrip.IntervalOffset = WarningMin;
            warningMinStrip.StripWidth = 0.0;
            warningMinStrip.BorderColor = Color.FromArgb(100, Color.Orange);
            warningMinStrip.BorderDashStyle = ChartDashStyle.Solid;
            warningMinStrip.BorderWidth = 3;
            Chart.ChartAreas[0].AxisY.StripLines.Add(warningMinStrip);

            criticalMinStrip.Interval = 0;
            criticalMinStrip.IntervalOffset = CriticalMin;
            criticalMinStrip.StripWidth = 0.0;
            criticalMinStrip.BorderColor = Color.FromArgb(100, Color.Red);
            criticalMinStrip.BorderDashStyle = ChartDashStyle.Solid;
            criticalMinStrip.BorderWidth = 3;
            Chart.ChartAreas[0].AxisY.StripLines.Add(criticalMinStrip);

            Chart.Series.Add(GraphPoints);
        }
        internal static void GraphUpdate(int value)
        {
            GraphPoints.Points.Clear();

            if (Data.FromSensor.graphListSecond.Count >= 60) Data.FromSensor.graphListSecond.Dequeue();
            Data.FromSensor.graphListSecond.Enqueue(value);

            for (int i = 0; i < Data.FromSensor.graphListSecond.Count; i++)
            {
                GraphPoints.Points.AddXY(i, Data.FromSensor.graphListSecond.ElementAt(i));
            }

        }

        internal static void setGraphLimits(Int32 WMin, Int32 WMax, Int32 CMin, Int32 CMax, byte typeData)
        {
            WarningMin = WMin;
            WarningMax = WMax;
            CriticalMin = CMin;
            CriticalMax = CMax;

            criticalMaxStrip.IntervalOffset = CriticalMax; //on "replace" les lignes
            warningMaxStrip.IntervalOffset = WarningMax;
            criticalMinStrip.IntervalOffset = CriticalMin;
            warningMinStrip.IntervalOffset = WarningMin;
        }

        internal static void setLowHighLimits(Int32 lowLimit, Int32 highLimit)
        {
            Area.AxisY.Maximum = highLimit;
            Area.AxisY.Minimum = lowLimit;
        }
    }
}