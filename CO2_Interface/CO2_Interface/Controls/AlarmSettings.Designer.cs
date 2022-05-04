namespace CO2_Interface.Controls
{
    partial class AlarmSettings
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
            this.WarningMin_textBox = new System.Windows.Forms.TextBox();
            this.WarningMin_Label = new System.Windows.Forms.Label();
            this.WarningMax_Label = new System.Windows.Forms.Label();
            this.WarningMax_textBox = new System.Windows.Forms.TextBox();
            this.CriticalMax_Label = new System.Windows.Forms.Label();
            this.CriticalMax_textBox = new System.Windows.Forms.TextBox();
            this.CriticalMin_Label = new System.Windows.Forms.Label();
            this.CriticalMin_textBox = new System.Windows.Forms.TextBox();
            this.groupBox_Config = new System.Windows.Forms.GroupBox();
            this.configStatus_label = new System.Windows.Forms.Label();
            this.configStatus_label1 = new System.Windows.Forms.Label();
            this.saveAlarmConfig_Button = new System.Windows.Forms.Button();
            this.typeData_label = new System.Windows.Forms.Label();
            this.typeData_label1 = new System.Windows.Forms.Label();
            this.comboBox_ID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btLoadSettings = new System.Windows.Forms.Button();
            this.groupBox_Config.SuspendLayout();
            this.SuspendLayout();
            // 
            // WarningMin_textBox
            // 
            this.WarningMin_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningMin_textBox.Location = new System.Drawing.Point(204, 203);
            this.WarningMin_textBox.Name = "WarningMin_textBox";
            this.WarningMin_textBox.Size = new System.Drawing.Size(258, 39);
            this.WarningMin_textBox.TabIndex = 5;
            this.WarningMin_textBox.Text = "0";
            // 
            // WarningMin_Label
            // 
            this.WarningMin_Label.AutoSize = true;
            this.WarningMin_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningMin_Label.ForeColor = System.Drawing.Color.Gold;
            this.WarningMin_Label.Location = new System.Drawing.Point(21, 209);
            this.WarningMin_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WarningMin_Label.Name = "WarningMin_Label";
            this.WarningMin_Label.Size = new System.Drawing.Size(172, 29);
            this.WarningMin_Label.TabIndex = 6;
            this.WarningMin_Label.Text = "Warning Min :";
            // 
            // WarningMax_Label
            // 
            this.WarningMax_Label.AutoSize = true;
            this.WarningMax_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningMax_Label.ForeColor = System.Drawing.Color.Gold;
            this.WarningMax_Label.Location = new System.Drawing.Point(21, 263);
            this.WarningMax_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WarningMax_Label.Name = "WarningMax_Label";
            this.WarningMax_Label.Size = new System.Drawing.Size(177, 29);
            this.WarningMax_Label.TabIndex = 8;
            this.WarningMax_Label.Text = "Warning Max :";
            // 
            // WarningMax_textBox
            // 
            this.WarningMax_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningMax_textBox.Location = new System.Drawing.Point(204, 257);
            this.WarningMax_textBox.Name = "WarningMax_textBox";
            this.WarningMax_textBox.Size = new System.Drawing.Size(258, 39);
            this.WarningMax_textBox.TabIndex = 7;
            this.WarningMax_textBox.Text = "0";
            // 
            // CriticalMax_Label
            // 
            this.CriticalMax_Label.AutoSize = true;
            this.CriticalMax_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriticalMax_Label.ForeColor = System.Drawing.Color.Red;
            this.CriticalMax_Label.Location = new System.Drawing.Point(21, 406);
            this.CriticalMax_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CriticalMax_Label.Name = "CriticalMax_Label";
            this.CriticalMax_Label.Size = new System.Drawing.Size(163, 29);
            this.CriticalMax_Label.TabIndex = 12;
            this.CriticalMax_Label.Text = "Critical Max :";
            // 
            // CriticalMax_textBox
            // 
            this.CriticalMax_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriticalMax_textBox.Location = new System.Drawing.Point(204, 400);
            this.CriticalMax_textBox.Name = "CriticalMax_textBox";
            this.CriticalMax_textBox.Size = new System.Drawing.Size(258, 39);
            this.CriticalMax_textBox.TabIndex = 11;
            this.CriticalMax_textBox.Text = "0";
            // 
            // CriticalMin_Label
            // 
            this.CriticalMin_Label.AutoSize = true;
            this.CriticalMin_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriticalMin_Label.ForeColor = System.Drawing.Color.Red;
            this.CriticalMin_Label.Location = new System.Drawing.Point(21, 352);
            this.CriticalMin_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CriticalMin_Label.Name = "CriticalMin_Label";
            this.CriticalMin_Label.Size = new System.Drawing.Size(158, 29);
            this.CriticalMin_Label.TabIndex = 10;
            this.CriticalMin_Label.Text = "Critical Min :";
            // 
            // CriticalMin_textBox
            // 
            this.CriticalMin_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriticalMin_textBox.Location = new System.Drawing.Point(204, 346);
            this.CriticalMin_textBox.Name = "CriticalMin_textBox";
            this.CriticalMin_textBox.Size = new System.Drawing.Size(258, 39);
            this.CriticalMin_textBox.TabIndex = 9;
            this.CriticalMin_textBox.Text = "0";
            // 
            // groupBox_Config
            // 
            this.groupBox_Config.BackColor = System.Drawing.Color.OldLace;
            this.groupBox_Config.Controls.Add(this.btLoadSettings);
            this.groupBox_Config.Controls.Add(this.configStatus_label);
            this.groupBox_Config.Controls.Add(this.configStatus_label1);
            this.groupBox_Config.Controls.Add(this.saveAlarmConfig_Button);
            this.groupBox_Config.Controls.Add(this.CriticalMax_textBox);
            this.groupBox_Config.Controls.Add(this.CriticalMax_Label);
            this.groupBox_Config.Controls.Add(this.CriticalMin_textBox);
            this.groupBox_Config.Controls.Add(this.WarningMax_textBox);
            this.groupBox_Config.Controls.Add(this.CriticalMin_Label);
            this.groupBox_Config.Controls.Add(this.WarningMin_textBox);
            this.groupBox_Config.Controls.Add(this.WarningMax_Label);
            this.groupBox_Config.Controls.Add(this.typeData_label);
            this.groupBox_Config.Controls.Add(this.WarningMin_Label);
            this.groupBox_Config.Controls.Add(this.typeData_label1);
            this.groupBox_Config.Controls.Add(this.comboBox_ID);
            this.groupBox_Config.Controls.Add(this.label1);
            this.groupBox_Config.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Config.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Config.Name = "groupBox_Config";
            this.groupBox_Config.Size = new System.Drawing.Size(482, 890);
            this.groupBox_Config.TabIndex = 14;
            this.groupBox_Config.TabStop = false;
            this.groupBox_Config.Text = "Alarm Configuration";
            // 
            // configStatus_label
            // 
            this.configStatus_label.AutoSize = true;
            this.configStatus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configStatus_label.Location = new System.Drawing.Point(254, 144);
            this.configStatus_label.Name = "configStatus_label";
            this.configStatus_label.Size = new System.Drawing.Size(34, 29);
            this.configStatus_label.TabIndex = 20;
            this.configStatus_label.Text = "...";
            // 
            // configStatus_label1
            // 
            this.configStatus_label1.AutoSize = true;
            this.configStatus_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configStatus_label1.Location = new System.Drawing.Point(21, 144);
            this.configStatus_label1.Name = "configStatus_label1";
            this.configStatus_label1.Size = new System.Drawing.Size(189, 29);
            this.configStatus_label1.TabIndex = 19;
            this.configStatus_label1.Text = "Config Status : ";
            // 
            // saveAlarmConfig_Button
            // 
            this.saveAlarmConfig_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAlarmConfig_Button.ForeColor = System.Drawing.Color.Black;
            this.saveAlarmConfig_Button.Location = new System.Drawing.Point(105, 658);
            this.saveAlarmConfig_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveAlarmConfig_Button.Name = "saveAlarmConfig_Button";
            this.saveAlarmConfig_Button.Size = new System.Drawing.Size(248, 75);
            this.saveAlarmConfig_Button.TabIndex = 18;
            this.saveAlarmConfig_Button.Text = "SAVE";
            this.saveAlarmConfig_Button.UseVisualStyleBackColor = true;
            this.saveAlarmConfig_Button.Click += new System.EventHandler(this.saveAlarmConfig_Button_Click);
            // 
            // typeData_label
            // 
            this.typeData_label.AutoSize = true;
            this.typeData_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeData_label.Location = new System.Drawing.Point(254, 111);
            this.typeData_label.Name = "typeData_label";
            this.typeData_label.Size = new System.Drawing.Size(34, 29);
            this.typeData_label.TabIndex = 13;
            this.typeData_label.Text = "...";
            // 
            // typeData_label1
            // 
            this.typeData_label1.AutoSize = true;
            this.typeData_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeData_label1.Location = new System.Drawing.Point(19, 111);
            this.typeData_label1.Name = "typeData_label1";
            this.typeData_label1.Size = new System.Drawing.Size(93, 29);
            this.typeData_label1.TabIndex = 12;
            this.typeData_label1.Text = "Type : ";
            // 
            // comboBox_ID
            // 
            this.comboBox_ID.FormattingEnabled = true;
            this.comboBox_ID.Location = new System.Drawing.Point(204, 57);
            this.comboBox_ID.Name = "comboBox_ID";
            this.comboBox_ID.Size = new System.Drawing.Size(258, 37);
            this.comboBox_ID.TabIndex = 11;
            this.comboBox_ID.SelectedIndexChanged += new System.EventHandler(this.comboBox_ID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select ID :";
            // 
            // btLoadSettings
            // 
            this.btLoadSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadSettings.ForeColor = System.Drawing.Color.Black;
            this.btLoadSettings.Location = new System.Drawing.Point(105, 541);
            this.btLoadSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btLoadSettings.Name = "btLoadSettings";
            this.btLoadSettings.Size = new System.Drawing.Size(248, 75);
            this.btLoadSettings.TabIndex = 21;
            this.btLoadSettings.Text = "LOAD SETTINGS";
            this.btLoadSettings.UseVisualStyleBackColor = true;
            this.btLoadSettings.Click += new System.EventHandler(this.btLoadSettings_Click);
            // 
            // AlarmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox_Config);
            this.Name = "AlarmSettings";
            this.Size = new System.Drawing.Size(485, 890);
            this.groupBox_Config.ResumeLayout(false);
            this.groupBox_Config.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox WarningMin_textBox;
        private System.Windows.Forms.Label WarningMin_Label;
        private System.Windows.Forms.Label WarningMax_Label;
        private System.Windows.Forms.TextBox WarningMax_textBox;
        private System.Windows.Forms.Label CriticalMax_Label;
        private System.Windows.Forms.TextBox CriticalMax_textBox;
        private System.Windows.Forms.Label CriticalMin_Label;
        private System.Windows.Forms.TextBox CriticalMin_textBox;
        private System.Windows.Forms.GroupBox groupBox_Config;
        private System.Windows.Forms.Button saveAlarmConfig_Button;
        private System.Windows.Forms.Label typeData_label;
        private System.Windows.Forms.Label typeData_label1;
        public System.Windows.Forms.ComboBox comboBox_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label configStatus_label;
        private System.Windows.Forms.Label configStatus_label1;
        private System.Windows.Forms.Button btLoadSettings;
    }
}
