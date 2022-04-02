namespace CO2_Interface.Controls
{
    partial class Users
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
            this.User_Grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.User_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // User_Grid
            // 
            this.User_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.User_Grid.BackgroundColor = System.Drawing.Color.OldLace;
            this.User_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.User_Grid.Location = new System.Drawing.Point(0, 0);
            this.User_Grid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.User_Grid.Name = "User_Grid";
            this.User_Grid.RowHeadersVisible = false;
            this.User_Grid.RowHeadersWidth = 51;
            this.User_Grid.RowTemplate.Height = 24;
            this.User_Grid.Size = new System.Drawing.Size(610, 461);
            this.User_Grid.TabIndex = 5;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.User_Grid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(610, 461);
            ((System.ComponentModel.ISupportInitialize)(this.User_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView User_Grid;
    }
}
