namespace CO2_Interface.Controls
{
    partial class Graphique
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Timer_200ms = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart
            // 
            this.Chart.Location = new System.Drawing.Point(0, 4);
            this.Chart.Margin = new System.Windows.Forms.Padding(4);
            this.Chart.Name = "Chart";
            this.Chart.Size = new System.Drawing.Size(1118, 848);
            this.Chart.TabIndex = 2;
            this.Chart.Text = "MyChart";
            // 
            // Timer_200ms
            // 
            this.Timer_200ms.Enabled = true;
            this.Timer_200ms.Tick += new System.EventHandler(this.Timer_200ms_Tick);
            // 
            // Graphique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.Chart);
            this.Name = "Graphique";
            this.Size = new System.Drawing.Size(1122, 856);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer_200ms;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
    }
}
