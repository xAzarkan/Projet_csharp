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
            this.Connexion_Label = new System.Windows.Forms.Label();
            this.ConnexionStatus_Label = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btMesure = new System.Windows.Forms.ToolStripButton();
            this.btAlarme = new System.Windows.Forms.ToolStripButton();
            this.btGraphics = new System.Windows.Forms.ToolStripButton();
            this.btUsers = new System.Windows.Forms.ToolStripButton();
            this.btSettings = new System.Windows.Forms.ToolStripButton();
            this.MyContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MyConfigContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.comPort_comboBox = new System.Windows.Forms.ComboBox();
            this.lb_SelectComPort = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.MyContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
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
            this.COM_Button.Location = new System.Drawing.Point(24, 173);
            this.COM_Button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.COM_Button.Name = "COM_Button";
            this.COM_Button.Size = new System.Drawing.Size(135, 41);
            this.COM_Button.TabIndex = 0;
            this.COM_Button.Text = "Open COM port";
            this.COM_Button.UseVisualStyleBackColor = true;
            this.COM_Button.Click += new System.EventHandler(this.button_COM_Click);
            // 
            // Connexion_Label
            // 
            this.Connexion_Label.AutoSize = true;
            this.Connexion_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connexion_Label.Location = new System.Drawing.Point(17, 424);
            this.Connexion_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Connexion_Label.Name = "Connexion_Label";
            this.Connexion_Label.Size = new System.Drawing.Size(114, 13);
            this.Connexion_Label.TabIndex = 3;
            this.Connexion_Label.Text = "Connexion Status: ";
            // 
            // ConnexionStatus_Label
            // 
            this.ConnexionStatus_Label.AutoSize = true;
            this.ConnexionStatus_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnexionStatus_Label.ForeColor = System.Drawing.Color.Red;
            this.ConnexionStatus_Label.Location = new System.Drawing.Point(123, 424);
            this.ConnexionStatus_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConnexionStatus_Label.Name = "ConnexionStatus_Label";
            this.ConnexionStatus_Label.Size = new System.Drawing.Size(47, 13);
            this.ConnexionStatus_Label.TabIndex = 4;
            this.ConnexionStatus_Label.Text = "CLOSE";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btMesure,
            this.btAlarme,
            this.btGraphics,
            this.btUsers,
            this.btSettings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1278, 57);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btMesure
            // 
            this.btMesure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btMesure.Image = ((System.Drawing.Image)(resources.GetObject("btMesure.Image")));
            this.btMesure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btMesure.Name = "btMesure";
            this.btMesure.Size = new System.Drawing.Size(54, 54);
            this.btMesure.Text = "Mesure";
            this.btMesure.Click += new System.EventHandler(this.btMesure_Click);
            // 
            // btAlarme
            // 
            this.btAlarme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAlarme.Image = ((System.Drawing.Image)(resources.GetObject("btAlarme.Image")));
            this.btAlarme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAlarme.Name = "btAlarme";
            this.btAlarme.Size = new System.Drawing.Size(54, 54);
            this.btAlarme.Text = "Alarme";
            this.btAlarme.Click += new System.EventHandler(this.btAlarme_Click);
            // 
            // btGraphics
            // 
            this.btGraphics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btGraphics.Image = ((System.Drawing.Image)(resources.GetObject("btGraphics.Image")));
            this.btGraphics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btGraphics.Name = "btGraphics";
            this.btGraphics.Size = new System.Drawing.Size(54, 54);
            this.btGraphics.Text = "Graphics";
            this.btGraphics.Click += new System.EventHandler(this.btGraphics_Click);
            // 
            // btUsers
            // 
            this.btUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btUsers.Image = ((System.Drawing.Image)(resources.GetObject("btUsers.Image")));
            this.btUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btUsers.Name = "btUsers";
            this.btUsers.Size = new System.Drawing.Size(54, 54);
            this.btUsers.Text = "Users";
            this.btUsers.Click += new System.EventHandler(this.btUsers_Click);
            // 
            // btSettings
            // 
            this.btSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSettings.Image = ((System.Drawing.Image)(resources.GetObject("btSettings.Image")));
            this.btSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(54, 54);
            this.btSettings.Text = "Settings";
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            // 
            // MyContainer
            // 
            this.MyContainer.BackColor = System.Drawing.Color.Transparent;
            this.MyContainer.Controls.Add(this.splitContainer1);
            this.MyContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyContainer.Location = new System.Drawing.Point(185, 79);
            this.MyContainer.Margin = new System.Windows.Forms.Padding(2);
            this.MyContainer.Name = "MyContainer";
            this.MyContainer.Size = new System.Drawing.Size(717, 464);
            this.MyContainer.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(82, 0);
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // MyConfigContainer
            // 
            this.MyConfigContainer.Location = new System.Drawing.Point(905, 79);
            this.MyConfigContainer.Margin = new System.Windows.Forms.Padding(2);
            this.MyConfigContainer.Name = "MyConfigContainer";
            this.MyConfigContainer.Size = new System.Drawing.Size(273, 464);
            this.MyConfigContainer.TabIndex = 13;
            // 
            // comPort_comboBox
            // 
            this.comPort_comboBox.FormattingEnabled = true;
            this.comPort_comboBox.Location = new System.Drawing.Point(25, 123);
            this.comPort_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.comPort_comboBox.Name = "comPort_comboBox";
            this.comPort_comboBox.Size = new System.Drawing.Size(135, 21);
            this.comPort_comboBox.TabIndex = 14;
            // 
            // lb_SelectComPort
            // 
            this.lb_SelectComPort.AutoSize = true;
            this.lb_SelectComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SelectComPort.Location = new System.Drawing.Point(22, 97);
            this.lb_SelectComPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_SelectComPort.Name = "lb_SelectComPort";
            this.lb_SelectComPort.Size = new System.Drawing.Size(108, 13);
            this.lb_SelectComPort.TabIndex = 15;
            this.lb_SelectComPort.Text = "Select COM port :";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1278, 562);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lb_SelectComPort);
            this.Controls.Add(this.comPort_comboBox);
            this.Controls.Add(this.MyConfigContainer);
            this.Controls.Add(this.MyContainer);
            this.Controls.Add(this.ConnexionStatus_Label);
            this.Controls.Add(this.Connexion_Label);
            this.Controls.Add(this.COM_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Text = " CO2 interface";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.MyContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.Button COM_Button;
        private System.Windows.Forms.Label Connexion_Label;
        private System.Windows.Forms.Label ConnexionStatus_Label;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btMesure;
        private System.Windows.Forms.ToolStripButton btAlarme;
        private System.Windows.Forms.FlowLayoutPanel MyContainer;
        private System.Windows.Forms.ToolStripButton btGraphics;
        private System.Windows.Forms.ToolStripButton btUsers;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel MyConfigContainer;
        private System.Windows.Forms.ToolStripButton btSettings;
        private System.Windows.Forms.ComboBox comPort_comboBox;
        private System.Windows.Forms.Label lb_SelectComPort;
    }
}

