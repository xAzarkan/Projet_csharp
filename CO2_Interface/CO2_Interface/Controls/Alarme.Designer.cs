namespace CO2_Interface.Controls
{
    partial class Alarme
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
            this.ObjectsGrid.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.ObjectsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ObjectsGrid.Location = new System.Drawing.Point(0, 0);
            this.ObjectsGrid.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ObjectsGrid.Name = "ObjectsGrid";
            this.ObjectsGrid.RowHeadersVisible = false;
            this.ObjectsGrid.RowHeadersWidth = 51;
            this.ObjectsGrid.RowTemplate.Height = 50;
            this.ObjectsGrid.RowTemplate.ReadOnly = true;
            this.ObjectsGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ObjectsGrid.Size = new System.Drawing.Size(1220, 887);
            this.ObjectsGrid.TabIndex = 4;
            // 
            // Alarme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.ObjectsGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Alarme";
            this.Size = new System.Drawing.Size(1220, 887);
            ((System.ComponentModel.ISupportInitialize)(this.ObjectsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView ObjectsGrid;
    }
}
