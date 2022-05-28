namespace CO2_Interface.Controls
{
    partial class MesureConfig
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
            this.groupBox_Config = new System.Windows.Forms.GroupBox();
            this.loadConfig_Button = new System.Windows.Forms.Button();
            this.saveConfig_Button = new System.Windows.Forms.Button();
            this.HighLimit_textBox = new System.Windows.Forms.TextBox();
            this.LowLimit_textBox = new System.Windows.Forms.TextBox();
            this.label_HighLimit = new System.Windows.Forms.Label();
            this.label_lowlimit = new System.Windows.Forms.Label();
            this.typeData_label = new System.Windows.Forms.Label();
            this.typeData_label1 = new System.Windows.Forms.Label();
            this.comboBox_ID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Config.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Config
            // 
            this.groupBox_Config.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox_Config.Controls.Add(this.loadConfig_Button);
            this.groupBox_Config.Controls.Add(this.saveConfig_Button);
            this.groupBox_Config.Controls.Add(this.HighLimit_textBox);
            this.groupBox_Config.Controls.Add(this.LowLimit_textBox);
            this.groupBox_Config.Controls.Add(this.label_HighLimit);
            this.groupBox_Config.Controls.Add(this.label_lowlimit);
            this.groupBox_Config.Controls.Add(this.typeData_label);
            this.groupBox_Config.Controls.Add(this.typeData_label1);
            this.groupBox_Config.Controls.Add(this.comboBox_ID);
            this.groupBox_Config.Controls.Add(this.label1);
            this.groupBox_Config.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Config.Location = new System.Drawing.Point(4, 0);
            this.groupBox_Config.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Config.Name = "groupBox_Config";
            this.groupBox_Config.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Config.Size = new System.Drawing.Size(504, 927);
            this.groupBox_Config.TabIndex = 13;
            this.groupBox_Config.TabStop = false;
            this.groupBox_Config.Text = "Configuration";
            // 
            // loadConfig_Button
            // 
            this.loadConfig_Button.AutoSize = true;
            this.loadConfig_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadConfig_Button.ForeColor = System.Drawing.Color.Black;
            this.loadConfig_Button.Location = new System.Drawing.Point(121, 598);
            this.loadConfig_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loadConfig_Button.Name = "loadConfig_Button";
            this.loadConfig_Button.Size = new System.Drawing.Size(251, 79);
            this.loadConfig_Button.TabIndex = 19;
            this.loadConfig_Button.Text = "LOAD CONFIG";
            this.loadConfig_Button.UseVisualStyleBackColor = true;
            this.loadConfig_Button.Click += new System.EventHandler(this.loadConfig_Button_Click);
            // 
            // saveConfig_Button
            // 
            this.saveConfig_Button.AutoSize = true;
            this.saveConfig_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveConfig_Button.ForeColor = System.Drawing.Color.Black;
            this.saveConfig_Button.Location = new System.Drawing.Point(121, 735);
            this.saveConfig_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveConfig_Button.Name = "saveConfig_Button";
            this.saveConfig_Button.Size = new System.Drawing.Size(251, 79);
            this.saveConfig_Button.TabIndex = 18;
            this.saveConfig_Button.Text = "SAVE";
            this.saveConfig_Button.UseVisualStyleBackColor = true;
            this.saveConfig_Button.Click += new System.EventHandler(this.saveConfig_Button_Click);
            // 
            // HighLimit_textBox
            // 
            this.HighLimit_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighLimit_textBox.Location = new System.Drawing.Point(208, 391);
            this.HighLimit_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.HighLimit_textBox.Name = "HighLimit_textBox";
            this.HighLimit_textBox.Size = new System.Drawing.Size(282, 40);
            this.HighLimit_textBox.TabIndex = 17;
            // 
            // LowLimit_textBox
            // 
            this.LowLimit_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowLimit_textBox.Location = new System.Drawing.Point(208, 332);
            this.LowLimit_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.LowLimit_textBox.Name = "LowLimit_textBox";
            this.LowLimit_textBox.Size = new System.Drawing.Size(282, 40);
            this.LowLimit_textBox.TabIndex = 16;
            // 
            // label_HighLimit
            // 
            this.label_HighLimit.AutoSize = true;
            this.label_HighLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HighLimit.Location = new System.Drawing.Point(36, 396);
            this.label_HighLimit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_HighLimit.Name = "label_HighLimit";
            this.label_HighLimit.Size = new System.Drawing.Size(174, 33);
            this.label_HighLimit.TabIndex = 15;
            this.label_HighLimit.Text = "High Limit :";
            // 
            // label_lowlimit
            // 
            this.label_lowlimit.AutoSize = true;
            this.label_lowlimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lowlimit.Location = new System.Drawing.Point(34, 332);
            this.label_lowlimit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lowlimit.Name = "label_lowlimit";
            this.label_lowlimit.Size = new System.Drawing.Size(166, 33);
            this.label_lowlimit.TabIndex = 14;
            this.label_lowlimit.Text = "Low Limit :";
            // 
            // typeData_label
            // 
            this.typeData_label.AutoSize = true;
            this.typeData_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeData_label.Location = new System.Drawing.Point(250, 194);
            this.typeData_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeData_label.Name = "typeData_label";
            this.typeData_label.Size = new System.Drawing.Size(42, 33);
            this.typeData_label.TabIndex = 13;
            this.typeData_label.Text = "...";
            // 
            // typeData_label1
            // 
            this.typeData_label1.AutoSize = true;
            this.typeData_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeData_label1.Location = new System.Drawing.Point(40, 194);
            this.typeData_label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeData_label1.Name = "typeData_label1";
            this.typeData_label1.Size = new System.Drawing.Size(111, 33);
            this.typeData_label1.TabIndex = 12;
            this.typeData_label1.Text = "Type : ";
            // 
            // comboBox_ID
            // 
            this.comboBox_ID.FormattingEnabled = true;
            this.comboBox_ID.Location = new System.Drawing.Point(208, 93);
            this.comboBox_ID.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_ID.Name = "comboBox_ID";
            this.comboBox_ID.Size = new System.Drawing.Size(282, 41);
            this.comboBox_ID.Sorted = true;
            this.comboBox_ID.TabIndex = 11;
            this.comboBox_ID.SelectedIndexChanged += new System.EventHandler(this.comboBox_ID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select ID :";
            // 
            // MesureConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox_Config);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MesureConfig";
            this.Size = new System.Drawing.Size(508, 929);
            this.groupBox_Config.ResumeLayout(false);
            this.groupBox_Config.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox_Config;
        public System.Windows.Forms.Button saveConfig_Button;
        public System.Windows.Forms.Label label_HighLimit;
        public System.Windows.Forms.Label label_lowlimit;
        public System.Windows.Forms.Label typeData_label1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox_ID;
        public System.Windows.Forms.TextBox HighLimit_textBox;
        public System.Windows.Forms.TextBox LowLimit_textBox;
        public System.Windows.Forms.Button loadConfig_Button;
        public System.Windows.Forms.Label typeData_label;
    }
}