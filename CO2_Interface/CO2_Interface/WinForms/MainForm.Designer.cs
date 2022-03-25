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
            this.btAmpoule = new System.Windows.Forms.ToolStripButton();
            this.btThermometre = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.btGraphics = new System.Windows.Forms.ToolStripButton();
            this.MyContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.StopDataTreatment_Button = new System.Windows.Forms.Button();
            this.CLOSE_COM_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_ID = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
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
            this.ConnexionStatus_Label.Location = new System.Drawing.Point(225, 783);
            this.ConnexionStatus_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConnexionStatus_Label.Name = "ConnexionStatus_Label";
            this.ConnexionStatus_Label.Size = new System.Drawing.Size(68, 25);
            this.ConnexionStatus_Label.TabIndex = 4;
            this.ConnexionStatus_Label.Text = "Close";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAmpoule,
            this.btThermometre,
            this.toolStripButton3,
            this.btGraphics});
            this.toolStrip1.Location = new System.Drawing.Point(45, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(197, 50);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btAmpoule
            // 
            this.btAmpoule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAmpoule.Image = ((System.Drawing.Image)(resources.GetObject("btAmpoule.Image")));
            this.btAmpoule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAmpoule.Name = "btAmpoule";
            this.btAmpoule.Size = new System.Drawing.Size(44, 44);
            this.btAmpoule.Text = "Ampoule";
            this.btAmpoule.Click += new System.EventHandler(this.btMesure_Click);
            // 
            // btThermometre
            // 
            this.btThermometre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btThermometre.Image = ((System.Drawing.Image)(resources.GetObject("btThermometre.Image")));
            this.btThermometre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btThermometre.Name = "btThermometre";
            this.btThermometre.Size = new System.Drawing.Size(44, 44);
            this.btThermometre.Text = "Thermometre";
            this.btThermometre.Click += new System.EventHandler(this.btAlarme_Click);
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
            // MyContainer
            // 
            this.MyContainer.BackColor = System.Drawing.Color.White;
            this.MyContainer.Location = new System.Drawing.Point(339, 146);
            this.MyContainer.Name = "MyContainer";
            this.MyContainer.Size = new System.Drawing.Size(1122, 856);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(631, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select ID :";
            // 
            // comboBox_ID
            // 
            this.comboBox_ID.FormattingEnabled = true;
            this.comboBox_ID.Location = new System.Drawing.Point(765, 48);
            this.comboBox_ID.Name = "comboBox_ID";
            this.comboBox_ID.Size = new System.Drawing.Size(121, 32);
            this.comboBox_ID.TabIndex = 11;
            this.comboBox_ID.SelectedIndexChanged += new System.EventHandler(this.comboBox_ID_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1486, 1014);
            this.Controls.Add(this.comboBox_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CLOSE_COM_Button);
            this.Controls.Add(this.StopDataTreatment_Button);
            this.Controls.Add(this.MyContainer);
            this.Controls.Add(this.ConnexionStatus_Label);
            this.Controls.Add(this.Connexion_Label);
            this.Controls.Add(this.DataTreatmen_Button);
            this.Controls.Add(this.COM_Button);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = " CO2 interface";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton btAmpoule;
        private System.Windows.Forms.ToolStripButton btThermometre;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.FlowLayoutPanel MyContainer;
        private System.Windows.Forms.Button StopDataTreatment_Button;
        private System.Windows.Forms.Button CLOSE_COM_Button;
        private System.Windows.Forms.ToolStripButton btGraphics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ID;
    }
}

