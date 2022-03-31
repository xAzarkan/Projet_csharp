namespace CO2_Interface
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.COM_Button = new System.Windows.Forms.Button();
            this.DataTreatmen_Button = new System.Windows.Forms.Button();
            this.Connexion_Label = new System.Windows.Forms.Label();
            this.ConnexionStatus_Label = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btMesure = new System.Windows.Forms.ToolStripButton();
            this.btAlarme = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.btGraphics = new System.Windows.Forms.ToolStripButton();
            this.btUsers = new System.Windows.Forms.ToolStripButton();
            this.btSettings = new System.Windows.Forms.ToolStripButton();
            this.MyContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.StopDataTreatment_Button = new System.Windows.Forms.Button();
            this.CLOSE_COM_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_ID = new System.Windows.Forms.ComboBox();
            this.groupBox_Config = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.typeData_label1 = new System.Windows.Forms.Label();
            this.typeData_label = new System.Windows.Forms.Label();
            this.label_lowlimit = new System.Windows.Forms.Label();
            this.label_HighLimit = new System.Windows.Forms.Label();
            this.HighLimit_textBox = new System.Windows.Forms.TextBox();
            this.LowLimit_textBox = new System.Windows.Forms.TextBox();
            this.saveConfig_Button = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.groupBox_Config.SuspendLayout();
            this.SuspendLayout();
            // 
            // SerialPort
            // 
            this.SerialPort.PortName = "COM2";
            // 
            // COM_Button
            // 
            this.COM_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COM_Button.ForeColor = System.Drawing.Color.Black;
            this.COM_Button.Location = new System.Drawing.Point(36, 164);
            this.COM_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.COM_Button.Name = "COM_Button";
            this.COM_Button.Size = new System.Drawing.Size(248, 75);
            this.COM_Button.TabIndex = 0;
            this.COM_Button.Text = "OPEN PORT COM 2";
            this.COM_Button.UseVisualStyleBackColor = true;
            this.COM_Button.Click += new System.EventHandler(this.button_COM_Click);
            // 
            // DataTreatmen_Button
            // 
            this.DataTreatmen_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataTreatmen_Button.ForeColor = System.Drawing.Color.Black;
            this.DataTreatmen_Button.Location = new System.Drawing.Point(45, 433);
            this.DataTreatmen_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataTreatmen_Button.Name = "DataTreatmen_Button";
            this.DataTreatmen_Button.Size = new System.Drawing.Size(226, 75);
            this.DataTreatmen_Button.TabIndex = 1;
            this.DataTreatmen_Button.Text = "START";
            this.DataTreatmen_Button.UseVisualStyleBackColor = true;
            this.DataTreatmen_Button.Click += new System.EventHandler(this.button_DataTreatment_Click);
            // 
            // Connexion_Label
            // 
            this.Connexion_Label.AutoSize = true;
            this.Connexion_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connexion_Label.Location = new System.Drawing.Point(31, 783);
            this.Connexion_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Connexion_Label.Name = "Connexion_Label";
            this.Connexion_Label.Size = new System.Drawing.Size(197, 25);
            this.Connexion_Label.TabIndex = 3;
            this.Connexion_Label.Text = "Connexion Status: ";
            // 
            // ConnexionStatus_Label
            // 
            this.ConnexionStatus_Label.AutoSize = true;
            this.ConnexionStatus_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnexionStatus_Label.ForeColor = System.Drawing.Color.Red;
            this.ConnexionStatus_Label.Location = new System.Drawing.Point(225, 783);
            this.ConnexionStatus_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConnexionStatus_Label.Name = "ConnexionStatus_Label";
            this.ConnexionStatus_Label.Size = new System.Drawing.Size(86, 25);
            this.ConnexionStatus_Label.TabIndex = 4;
            this.ConnexionStatus_Label.Text = "CLOSE";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btMesure,
            this.btAlarme,
            this.toolStripButton3,
            this.btGraphics,
            this.btUsers,
            this.btSettings});
            this.toolStrip1.Location = new System.Drawing.Point(36, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(285, 50);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btMesure
            // 
            this.btMesure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btMesure.Image = ((System.Drawing.Image)(resources.GetObject("btMesure.Image")));
            this.btMesure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btMesure.Name = "btMesure";
            this.btMesure.Size = new System.Drawing.Size(44, 44);
            this.btMesure.Text = "Mesure";
            this.btMesure.Click += new System.EventHandler(this.btMesure_Click);
            // 
            // btAlarme
            // 
            this.btAlarme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAlarme.Image = ((System.Drawing.Image)(resources.GetObject("btAlarme.Image")));
            this.btAlarme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAlarme.Name = "btAlarme";
            this.btAlarme.Size = new System.Drawing.Size(44, 44);
            this.btAlarme.Text = "Alarme";
            this.btAlarme.Click += new System.EventHandler(this.btAlarme_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(44, 44);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // btGraphics
            // 
            this.btGraphics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btGraphics.Image = ((System.Drawing.Image)(resources.GetObject("btGraphics.Image")));
            this.btGraphics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btGraphics.Name = "btGraphics";
            this.btGraphics.Size = new System.Drawing.Size(44, 44);
            this.btGraphics.Text = "Graphics";
            this.btGraphics.Click += new System.EventHandler(this.btGraphics_Click);
            // 
            // btUsers
            // 
            this.btUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btUsers.Image = ((System.Drawing.Image)(resources.GetObject("btUsers.Image")));
            this.btUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btUsers.Name = "btUsers";
            this.btUsers.Size = new System.Drawing.Size(44, 44);
            this.btUsers.Text = "Users";
            this.btUsers.Click += new System.EventHandler(this.btUsers_Click);
            // 
            // btSettings
            // 
            this.btSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSettings.Image = ((System.Drawing.Image)(resources.GetObject("btSettings.Image")));
            this.btSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(44, 44);
            this.btSettings.Text = "toolStripButton1";
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            // 
            // MyContainer
            // 
            this.MyContainer.BackColor = System.Drawing.Color.Transparent;
            this.MyContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyContainer.Location = new System.Drawing.Point(339, 146);
            this.MyContainer.Name = "MyContainer";
            this.MyContainer.Size = new System.Drawing.Size(1223, 856);
            this.MyContainer.TabIndex = 6;
            // 
            // StopDataTreatment_Button
            // 
            this.StopDataTreatment_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopDataTreatment_Button.ForeColor = System.Drawing.Color.Black;
            this.StopDataTreatment_Button.Location = new System.Drawing.Point(45, 527);
            this.StopDataTreatment_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StopDataTreatment_Button.Name = "StopDataTreatment_Button";
            this.StopDataTreatment_Button.Size = new System.Drawing.Size(226, 75);
            this.StopDataTreatment_Button.TabIndex = 7;
            this.StopDataTreatment_Button.Text = "STOP";
            this.StopDataTreatment_Button.UseVisualStyleBackColor = true;
            this.StopDataTreatment_Button.Click += new System.EventHandler(this.StopDataTreatment_Button_Click);
            // 
            // CLOSE_COM_Button
            // 
            this.CLOSE_COM_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLOSE_COM_Button.ForeColor = System.Drawing.Color.Black;
            this.CLOSE_COM_Button.Location = new System.Drawing.Point(36, 249);
            this.CLOSE_COM_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CLOSE_COM_Button.Name = "CLOSE_COM_Button";
            this.CLOSE_COM_Button.Size = new System.Drawing.Size(248, 75);
            this.CLOSE_COM_Button.TabIndex = 8;
            this.CLOSE_COM_Button.Text = "CLOSE PORT COM 2";
            this.CLOSE_COM_Button.UseVisualStyleBackColor = true;
            this.CLOSE_COM_Button.Click += new System.EventHandler(this.CLOSE_COM_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select ID :";
            // 
            // comboBox_ID
            // 
            this.comboBox_ID.FormattingEnabled = true;
            this.comboBox_ID.Location = new System.Drawing.Point(192, 89);
            this.comboBox_ID.Name = "comboBox_ID";
            this.comboBox_ID.Size = new System.Drawing.Size(258, 37);
            this.comboBox_ID.TabIndex = 11;
            this.comboBox_ID.SelectedIndexChanged += new System.EventHandler(this.comboBox_ID_SelectedIndexChanged);
            // 
            // groupBox_Config
            // 
            this.groupBox_Config.Controls.Add(this.saveConfig_Button);
            this.groupBox_Config.Controls.Add(this.HighLimit_textBox);
            this.groupBox_Config.Controls.Add(this.LowLimit_textBox);
            this.groupBox_Config.Controls.Add(this.label_HighLimit);
            this.groupBox_Config.Controls.Add(this.label_lowlimit);
            this.groupBox_Config.Controls.Add(this.typeData_label);
            this.groupBox_Config.Controls.Add(this.typeData_label1);
            this.groupBox_Config.Controls.Add(this.textBox1);
            this.groupBox_Config.Controls.Add(this.comboBox_ID);
            this.groupBox_Config.Controls.Add(this.label1);
            this.groupBox_Config.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Config.Location = new System.Drawing.Point(1588, 146);
            this.groupBox_Config.Name = "groupBox_Config";
            this.groupBox_Config.Size = new System.Drawing.Size(496, 856);
            this.groupBox_Config.TabIndex = 12;
            this.groupBox_Config.TabStop = false;
            this.groupBox_Config.Text = "Configuration";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 34);
            this.textBox1.TabIndex = 0;
            // 
            // typeData_label1
            // 
            this.typeData_label1.AutoSize = true;
            this.typeData_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeData_label1.Location = new System.Drawing.Point(37, 187);
            this.typeData_label1.Name = "typeData_label1";
            this.typeData_label1.Size = new System.Drawing.Size(93, 29);
            this.typeData_label1.TabIndex = 12;
            this.typeData_label1.Text = "Type : ";
            // 
            // typeData_label
            // 
            this.typeData_label.AutoSize = true;
            this.typeData_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeData_label.Location = new System.Drawing.Point(187, 187);
            this.typeData_label.Name = "typeData_label";
            this.typeData_label.Size = new System.Drawing.Size(34, 29);
            this.typeData_label.TabIndex = 13;
            this.typeData_label.Text = "...";
            // 
            // label_lowlimit
            // 
            this.label_lowlimit.AutoSize = true;
            this.label_lowlimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lowlimit.Location = new System.Drawing.Point(32, 320);
            this.label_lowlimit.Name = "label_lowlimit";
            this.label_lowlimit.Size = new System.Drawing.Size(138, 29);
            this.label_lowlimit.TabIndex = 14;
            this.label_lowlimit.Text = "Low Limit :";
            // 
            // label_HighLimit
            // 
            this.label_HighLimit.AutoSize = true;
            this.label_HighLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HighLimit.Location = new System.Drawing.Point(33, 381);
            this.label_HighLimit.Name = "label_HighLimit";
            this.label_HighLimit.Size = new System.Drawing.Size(144, 29);
            this.label_HighLimit.TabIndex = 15;
            this.label_HighLimit.Text = "High Limit :";
            // 
            // HighLimit_textBox
            // 
            this.HighLimit_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighLimit_textBox.Location = new System.Drawing.Point(192, 374);
            this.HighLimit_textBox.Name = "HighLimit_textBox";
            this.HighLimit_textBox.Size = new System.Drawing.Size(258, 39);
            this.HighLimit_textBox.TabIndex = 17;
            // 
            // LowLimit_textBox
            // 
            this.LowLimit_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowLimit_textBox.Location = new System.Drawing.Point(192, 320);
            this.LowLimit_textBox.Name = "LowLimit_textBox";
            this.LowLimit_textBox.Size = new System.Drawing.Size(258, 39);
            this.LowLimit_textBox.TabIndex = 16;
            // 
            // saveConfig_Button
            // 
            this.saveConfig_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveConfig_Button.ForeColor = System.Drawing.Color.Black;
            this.saveConfig_Button.Location = new System.Drawing.Point(125, 612);
            this.saveConfig_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveConfig_Button.Name = "saveConfig_Button";
            this.saveConfig_Button.Size = new System.Drawing.Size(248, 75);
            this.saveConfig_Button.TabIndex = 18;
            this.saveConfig_Button.Text = "SAVE";
            this.saveConfig_Button.UseVisualStyleBackColor = true;
            this.saveConfig_Button.Click += new System.EventHandler(this.saveConfig_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(2188, 1043);
            this.Controls.Add(this.groupBox_Config);
            this.Controls.Add(this.CLOSE_COM_Button);
            this.Controls.Add(this.StopDataTreatment_Button);
            this.Controls.Add(this.MyContainer);
            this.Controls.Add(this.ConnexionStatus_Label);
            this.Controls.Add(this.Connexion_Label);
            this.Controls.Add(this.DataTreatmen_Button);
            this.Controls.Add(this.COM_Button);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = " CO2 interface";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox_Config.ResumeLayout(false);
            this.groupBox_Config.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.Button COM_Button;
        private System.Windows.Forms.Button DataTreatmen_Button;
        private System.Windows.Forms.Label Connexion_Label;
        private System.Windows.Forms.Label ConnexionStatus_Label;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btMesure;
        private System.Windows.Forms.ToolStripButton btAlarme;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.FlowLayoutPanel MyContainer;
        private System.Windows.Forms.Button StopDataTreatment_Button;
        private System.Windows.Forms.Button CLOSE_COM_Button;
        private System.Windows.Forms.ToolStripButton btGraphics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ID;
        private System.Windows.Forms.ToolStripButton btUsers;
        private System.Windows.Forms.ToolStripButton btSettings;
        private System.Windows.Forms.GroupBox groupBox_Config;
        private System.Windows.Forms.Label typeData_label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label typeData_label;
        private System.Windows.Forms.Label label_HighLimit;
        private System.Windows.Forms.Label label_lowlimit;
        private System.Windows.Forms.TextBox HighLimit_textBox;
        private System.Windows.Forms.TextBox LowLimit_textBox;
        private System.Windows.Forms.Button saveConfig_Button;
    }
}

