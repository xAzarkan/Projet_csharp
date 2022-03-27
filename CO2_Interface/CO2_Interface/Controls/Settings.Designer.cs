namespace CO2_Interface.Controls
{
    partial class Settings
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
            this.saveSettings_Button = new System.Windows.Forms.Button();
            this.TitleSettings_Label = new System.Windows.Forms.Label();
            this.WarningMin_textBox = new System.Windows.Forms.TextBox();
            this.WarningMin_Label = new System.Windows.Forms.Label();
            this.WarningMax_Label = new System.Windows.Forms.Label();
            this.WarningMax_textBox = new System.Windows.Forms.TextBox();
            this.CriticalMax_Label = new System.Windows.Forms.Label();
            this.CriticalMax_textBox = new System.Windows.Forms.TextBox();
            this.CriticalMin_Label = new System.Windows.Forms.Label();
            this.CriticalMin_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveSettings_Button
            // 
            this.saveSettings_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSettings_Button.ForeColor = System.Drawing.Color.Black;
            this.saveSettings_Button.Location = new System.Drawing.Point(432, 651);
            this.saveSettings_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveSettings_Button.Name = "saveSettings_Button";
            this.saveSettings_Button.Size = new System.Drawing.Size(248, 75);
            this.saveSettings_Button.TabIndex = 1;
            this.saveSettings_Button.Text = "SAVE SETTINGS";
            this.saveSettings_Button.UseVisualStyleBackColor = true;
            this.saveSettings_Button.Click += new System.EventHandler(this.saveSettings_Button_Click);
            // 
            // TitleSettings_Label
            // 
            this.TitleSettings_Label.AutoSize = true;
            this.TitleSettings_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleSettings_Label.Location = new System.Drawing.Point(425, 21);
            this.TitleSettings_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleSettings_Label.Name = "TitleSettings_Label";
            this.TitleSettings_Label.Size = new System.Drawing.Size(293, 38);
            this.TitleSettings_Label.TabIndex = 4;
            this.TitleSettings_Label.Text = "Graphics Settings";
            // 
            // WarningMin_textBox
            // 
            this.WarningMin_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningMin_textBox.Location = new System.Drawing.Point(499, 185);
            this.WarningMin_textBox.Name = "WarningMin_textBox";
            this.WarningMin_textBox.Size = new System.Drawing.Size(258, 39);
            this.WarningMin_textBox.TabIndex = 5;
            this.WarningMin_textBox.Text = "0";
            // 
            // WarningMin_Label
            // 
            this.WarningMin_Label.AutoSize = true;
            this.WarningMin_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningMin_Label.Location = new System.Drawing.Point(339, 185);
            this.WarningMin_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WarningMin_Label.Name = "WarningMin_Label";
            this.WarningMin_Label.Size = new System.Drawing.Size(147, 25);
            this.WarningMin_Label.TabIndex = 6;
            this.WarningMin_Label.Text = "Warning Min :";
            // 
            // WarningMax_Label
            // 
            this.WarningMax_Label.AutoSize = true;
            this.WarningMax_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningMax_Label.Location = new System.Drawing.Point(339, 249);
            this.WarningMax_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WarningMax_Label.Name = "WarningMax_Label";
            this.WarningMax_Label.Size = new System.Drawing.Size(153, 25);
            this.WarningMax_Label.TabIndex = 8;
            this.WarningMax_Label.Text = "Warning Max :";
            // 
            // WarningMax_textBox
            // 
            this.WarningMax_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningMax_textBox.Location = new System.Drawing.Point(499, 239);
            this.WarningMax_textBox.Name = "WarningMax_textBox";
            this.WarningMax_textBox.Size = new System.Drawing.Size(258, 39);
            this.WarningMax_textBox.TabIndex = 7;
            this.WarningMax_textBox.Text = "60000";
            // 
            // CriticalMax_Label
            // 
            this.CriticalMax_Label.AutoSize = true;
            this.CriticalMax_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriticalMax_Label.Location = new System.Drawing.Point(339, 498);
            this.CriticalMax_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CriticalMax_Label.Name = "CriticalMax_Label";
            this.CriticalMax_Label.Size = new System.Drawing.Size(139, 25);
            this.CriticalMax_Label.TabIndex = 12;
            this.CriticalMax_Label.Text = "Critical Max :";
            // 
            // CriticalMax_textBox
            // 
            this.CriticalMax_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriticalMax_textBox.Location = new System.Drawing.Point(499, 488);
            this.CriticalMax_textBox.Name = "CriticalMax_textBox";
            this.CriticalMax_textBox.Size = new System.Drawing.Size(258, 39);
            this.CriticalMax_textBox.TabIndex = 11;
            this.CriticalMax_textBox.Text = "70000";
            // 
            // CriticalMin_Label
            // 
            this.CriticalMin_Label.AutoSize = true;
            this.CriticalMin_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriticalMin_Label.Location = new System.Drawing.Point(339, 444);
            this.CriticalMin_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CriticalMin_Label.Name = "CriticalMin_Label";
            this.CriticalMin_Label.Size = new System.Drawing.Size(133, 25);
            this.CriticalMin_Label.TabIndex = 10;
            this.CriticalMin_Label.Text = "Critical Min :";
            // 
            // CriticalMin_textBox
            // 
            this.CriticalMin_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriticalMin_textBox.Location = new System.Drawing.Point(499, 434);
            this.CriticalMin_textBox.Name = "CriticalMin_textBox";
            this.CriticalMin_textBox.Size = new System.Drawing.Size(258, 39);
            this.CriticalMin_textBox.TabIndex = 9;
            this.CriticalMin_textBox.Text = "0";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CriticalMax_Label);
            this.Controls.Add(this.CriticalMax_textBox);
            this.Controls.Add(this.CriticalMin_Label);
            this.Controls.Add(this.CriticalMin_textBox);
            this.Controls.Add(this.WarningMax_Label);
            this.Controls.Add(this.WarningMax_textBox);
            this.Controls.Add(this.WarningMin_Label);
            this.Controls.Add(this.WarningMin_textBox);
            this.Controls.Add(this.TitleSettings_Label);
            this.Controls.Add(this.saveSettings_Button);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(1151, 796);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveSettings_Button;
        private System.Windows.Forms.Label TitleSettings_Label;
        private System.Windows.Forms.TextBox WarningMin_textBox;
        private System.Windows.Forms.Label WarningMin_Label;
        private System.Windows.Forms.Label WarningMax_Label;
        private System.Windows.Forms.TextBox WarningMax_textBox;
        private System.Windows.Forms.Label CriticalMax_Label;
        private System.Windows.Forms.TextBox CriticalMax_textBox;
        private System.Windows.Forms.Label CriticalMin_Label;
        private System.Windows.Forms.TextBox CriticalMin_textBox;
    }
}
