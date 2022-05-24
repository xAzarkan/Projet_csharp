namespace CO2_Interface.Controls
{
    partial class Mesure
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
            this.ObjectsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ObjectsGrid
            // 
            this.ObjectsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ObjectsGrid.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.ObjectsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ObjectsGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ObjectsGrid.Location = new System.Drawing.Point(0, 0);
            this.ObjectsGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObjectsGrid.Name = "ObjectsGrid";
            this.ObjectsGrid.ReadOnly = true;
            this.ObjectsGrid.RowHeadersVisible = false;
            this.ObjectsGrid.RowHeadersWidth = 51;
            this.ObjectsGrid.RowTemplate.Height = 30;
            this.ObjectsGrid.RowTemplate.ReadOnly = true;
            this.ObjectsGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ObjectsGrid.Size = new System.Drawing.Size(1220, 886);
            this.ObjectsGrid.TabIndex = 3;
            // 
            // Mesure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ObjectsGrid);
            this.Name = "Mesure";
            this.Size = new System.Drawing.Size(1224, 892);
            ((System.ComponentModel.ISupportInitialize)(this.ObjectsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView ObjectsGrid;
    }
}
