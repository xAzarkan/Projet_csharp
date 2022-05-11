﻿namespace CO2_Interface.Controls
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
            ((System.ComponentModel.ISupportInitialize)(this.UserTable_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserAccess_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // UserTable_Grid
            // 
            this.UserTable_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserTable_Grid.BackgroundColor = System.Drawing.Color.OldLace;
            this.UserTable_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserTable_Grid.Location = new System.Drawing.Point(0, 0);
            this.UserTable_Grid.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UserTable_Grid.Name = "UserTable_Grid";
            this.UserTable_Grid.RowHeadersVisible = false;
            this.UserTable_Grid.RowHeadersWidth = 51;
            this.UserTable_Grid.RowTemplate.Height = 50;
            this.UserTable_Grid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserTable_Grid.Size = new System.Drawing.Size(1220, 394);
            this.UserTable_Grid.TabIndex = 5;
            // 
            // UserAccess_Grid
            // 
            this.UserAccess_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserAccess_Grid.BackgroundColor = System.Drawing.Color.OldLace;
            this.UserAccess_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserAccess_Grid.Location = new System.Drawing.Point(0, 452);
            this.UserAccess_Grid.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UserAccess_Grid.Name = "UserAccess_Grid";
            this.UserAccess_Grid.RowHeadersVisible = false;
            this.UserAccess_Grid.RowHeadersWidth = 51;
            this.UserAccess_Grid.RowTemplate.Height = 50;
            this.UserAccess_Grid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserAccess_Grid.Size = new System.Drawing.Size(1220, 394);
            this.UserAccess_Grid.TabIndex = 6;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UserAccess_Grid);
            this.Controls.Add(this.UserTable_Grid);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(1220, 887);
            ((System.ComponentModel.ISupportInitialize)(this.UserTable_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserAccess_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView UserTable_Grid;
        internal System.Windows.Forms.DataGridView UserAccess_Grid;
    }
}
