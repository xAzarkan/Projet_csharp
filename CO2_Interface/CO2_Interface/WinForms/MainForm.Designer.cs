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
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
            this.MyContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MyConfigContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.comPort_comboBox = new System.Windows.Forms.ComboBox();
            this.lb_SelectComPort = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.current_time_timer = new System.Windows.Forms.Timer(this.components);
            this.lb_current_time = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.MyContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SerialPort
            // 
            this.SerialPort.PortName = "COM2";
            // 
            // COM_Button
            // 
            this.COM_Button.AutoSize = true;
            this.COM_Button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.COM_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COM_Button.ForeColor = System.Drawing.Color.Black;
            this.COM_Button.Location = new System.Drawing.Point(800, 16);
            this.COM_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.COM_Button.Name = "COM_Button";
            this.COM_Button.Size = new System.Drawing.Size(252, 82);
            this.COM_Button.TabIndex = 0;
            this.COM_Button.Text = "Open COM port";
            this.COM_Button.UseVisualStyleBackColor = false;
            this.COM_Button.Click += new System.EventHandler(this.button_COM_Click);
            // 
            // Connexion_Label
            // 
            this.Connexion_Label.AutoSize = true;
            this.Connexion_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connexion_Label.Location = new System.Drawing.Point(1136, 44);
            this.Connexion_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Connexion_Label.Name = "Connexion_Label";
            this.Connexion_Label.Size = new System.Drawing.Size(278, 33);
            this.Connexion_Label.TabIndex = 3;
            this.Connexion_Label.Text = "Connexion Status: ";
            // 
            // ConnexionStatus_Label
            // 
            this.ConnexionStatus_Label.AutoSize = true;
            this.ConnexionStatus_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnexionStatus_Label.ForeColor = System.Drawing.Color.Red;
            this.ConnexionStatus_Label.Location = new System.Drawing.Point(1434, 44);
            this.ConnexionStatus_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConnexionStatus_Label.Name = "ConnexionStatus_Label";
            this.ConnexionStatus_Label.Size = new System.Drawing.Size(118, 33);
            this.ConnexionStatus_Label.TabIndex = 4;
            this.ConnexionStatus_Label.Text = "CLOSE";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btMesure,
            this.btAlarme,
            this.btGraphics,
            this.btUsers});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStrip1.Size = new System.Drawing.Size(146, 1112);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btMesure
            // 
            this.btMesure.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMesure.Image = ((System.Drawing.Image)(resources.GetObject("btMesure.Image")));
            this.btMesure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btMesure.Name = "btMesure";
            this.btMesure.Size = new System.Drawing.Size(137, 94);
            this.btMesure.Text = "Measures";
            this.btMesure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMesure.Click += new System.EventHandler(this.btMesure_Click);
            // 
            // btAlarme
            // 
            this.btAlarme.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlarme.Image = ((System.Drawing.Image)(resources.GetObject("btAlarme.Image")));
            this.btAlarme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAlarme.Name = "btAlarme";
            this.btAlarme.Size = new System.Drawing.Size(137, 94);
            this.btAlarme.Text = "Alarms";
            this.btAlarme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btAlarme.Click += new System.EventHandler(this.btAlarme_Click);
            // 
            // btGraphics
            // 
            this.btGraphics.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGraphics.Image = ((System.Drawing.Image)(resources.GetObject("btGraphics.Image")));
            this.btGraphics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btGraphics.Name = "btGraphics";
            this.btGraphics.Size = new System.Drawing.Size(137, 94);
            this.btGraphics.Text = "Graphics";
            this.btGraphics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btGraphics.Click += new System.EventHandler(this.btGraphics_Click);
            // 
            // btUsers
            // 
            this.btUsers.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUsers.Image = ((System.Drawing.Image)(resources.GetObject("btUsers.Image")));
            this.btUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btUsers.Name = "btUsers";
            this.btUsers.Size = new System.Drawing.Size(137, 94);
            this.btUsers.Text = "Users";
            this.btUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btUsers.Click += new System.EventHandler(this.btUsers_Click);
            // 
            // MyContainer
            // 
            this.MyContainer.AutoSize = true;
            this.MyContainer.BackColor = System.Drawing.Color.Transparent;
            this.MyContainer.Controls.Add(this.splitContainer1);
            this.MyContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyContainer.Location = new System.Drawing.Point(184, 132);
            this.MyContainer.Margin = new System.Windows.Forms.Padding(4);
            this.MyContainer.Name = "MyContainer";
            this.MyContainer.Size = new System.Drawing.Size(1434, 928);
            this.MyContainer.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(164, 0);
            this.splitContainer1.TabIndex = 0;
            // 
            // MyConfigContainer
            // 
            this.MyConfigContainer.AutoSize = true;
            this.MyConfigContainer.Location = new System.Drawing.Point(1624, 132);
            this.MyConfigContainer.Margin = new System.Windows.Forms.Padding(4);
            this.MyConfigContainer.Name = "MyConfigContainer";
            this.MyConfigContainer.Size = new System.Drawing.Size(546, 928);
            this.MyConfigContainer.TabIndex = 13;
            // 
            // comPort_comboBox
            // 
            this.comPort_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPort_comboBox.FormattingEnabled = true;
            this.comPort_comboBox.Location = new System.Drawing.Point(499, 44);
            this.comPort_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.comPort_comboBox.Name = "comPort_comboBox";
            this.comPort_comboBox.Size = new System.Drawing.Size(268, 41);
            this.comPort_comboBox.TabIndex = 14;
            // 
            // lb_SelectComPort
            // 
            this.lb_SelectComPort.AutoSize = true;
            this.lb_SelectComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SelectComPort.Location = new System.Drawing.Point(204, 44);
            this.lb_SelectComPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_SelectComPort.Name = "lb_SelectComPort";
            this.lb_SelectComPort.Size = new System.Drawing.Size(263, 33);
            this.lb_SelectComPort.TabIndex = 15;
            this.lb_SelectComPort.Text = "Select COM port :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2034, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // current_time_timer
            // 
            this.current_time_timer.Tick += new System.EventHandler(this.current_time_timer_Tick);
            // 
            // lb_current_time
            // 
            this.lb_current_time.AutoSize = true;
            this.lb_current_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_current_time.Location = new System.Drawing.Point(1678, 44);
            this.lb_current_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_current_time.Name = "lb_current_time";
            this.lb_current_time.Size = new System.Drawing.Size(188, 33);
            this.lb_current_time.TabIndex = 17;
            this.lb_current_time.Text = "Current time";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(2192, 1112);
            this.Controls.Add(this.lb_current_time);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_SelectComPort);
            this.Controls.Add(this.comPort_comboBox);
            this.Controls.Add(this.MyConfigContainer);
            this.Controls.Add(this.MyContainer);
            this.Controls.Add(this.ConnexionStatus_Label);
            this.Controls.Add(this.Connexion_Label);
            this.Controls.Add(this.COM_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " CO2 interface";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.MyContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ComboBox comPort_comboBox;
        private System.Windows.Forms.Label lb_SelectComPort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer current_time_timer;
        private System.Windows.Forms.Label lb_current_time;
    }
}