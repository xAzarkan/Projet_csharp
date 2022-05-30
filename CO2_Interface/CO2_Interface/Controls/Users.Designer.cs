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
            this.UserTable_Grid = new System.Windows.Forms.DataGridView();
            this.UserAccess_Grid = new System.Windows.Forms.DataGridView();
            this.Update_Informations = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserTable_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserAccess_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // UserTable_Grid
            // 
            this.UserTable_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserTable_Grid.BackgroundColor = System.Drawing.Color.White;
            this.UserTable_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserTable_Grid.Location = new System.Drawing.Point(0, 0);
            this.UserTable_Grid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UserTable_Grid.Name = "UserTable_Grid";
            this.UserTable_Grid.ReadOnly = true;
            this.UserTable_Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.UserTable_Grid.RowHeadersVisible = false;
            this.UserTable_Grid.RowHeadersWidth = 51;
            this.UserTable_Grid.RowTemplate.Height = 30;
            this.UserTable_Grid.RowTemplate.ReadOnly = true;
            this.UserTable_Grid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserTable_Grid.Size = new System.Drawing.Size(610, 205);
            this.UserTable_Grid.TabIndex = 5;
            // 
            // UserAccess_Grid
            // 
            this.UserAccess_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserAccess_Grid.BackgroundColor = System.Drawing.Color.White;
            this.UserAccess_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserAccess_Grid.Location = new System.Drawing.Point(0, 256);
            this.UserAccess_Grid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UserAccess_Grid.Name = "UserAccess_Grid";
            this.UserAccess_Grid.ReadOnly = true;
            this.UserAccess_Grid.RowHeadersVisible = false;
            this.UserAccess_Grid.RowHeadersWidth = 51;
            this.UserAccess_Grid.RowTemplate.Height = 30;
            this.UserAccess_Grid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserAccess_Grid.Size = new System.Drawing.Size(610, 205);
            this.UserAccess_Grid.TabIndex = 6;
            // 
            // Update_Informations
            // 
            this.Update_Informations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Informations.ForeColor = System.Drawing.Color.Black;
            this.Update_Informations.Location = new System.Drawing.Point(238, 210);
            this.Update_Informations.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Update_Informations.Name = "Update_Informations";
            this.Update_Informations.Size = new System.Drawing.Size(135, 41);
            this.Update_Informations.TabIndex = 19;
            this.Update_Informations.Text = "UPDATE INFORMATIONS";
            this.Update_Informations.UseVisualStyleBackColor = true;
            this.Update_Informations.Click += new System.EventHandler(this.Update_Informations_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Controls.Add(this.Update_Informations);
            this.Controls.Add(this.UserAccess_Grid);
            this.Controls.Add(this.UserTable_Grid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(610, 461);
            ((System.ComponentModel.ISupportInitialize)(this.UserTable_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserAccess_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView UserTable_Grid;
        internal System.Windows.Forms.DataGridView UserAccess_Grid;
        private System.Windows.Forms.Button Update_Informations;
    }
}
