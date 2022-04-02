namespace CO2_Interface.Controls
{
    partial class UsersConfig
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Config = new System.Windows.Forms.GroupBox();
            this.Rights_label = new System.Windows.Forms.Label();
            this.AddUser_Button = new System.Windows.Forms.Button();
            this.typeData_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.ID_box = new System.Windows.Forms.TextBox();
            this.Password_box = new System.Windows.Forms.TextBox();
            this.Rights_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox_Config.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Config
            // 
            this.groupBox_Config.BackColor = System.Drawing.Color.OldLace;
            this.groupBox_Config.Controls.Add(this.Rights_comboBox);
            this.groupBox_Config.Controls.Add(this.Password_box);
            this.groupBox_Config.Controls.Add(this.ID_box);
            this.groupBox_Config.Controls.Add(this.Rights_label);
            this.groupBox_Config.Controls.Add(this.AddUser_Button);
            this.groupBox_Config.Controls.Add(this.typeData_label);
            this.groupBox_Config.Controls.Add(this.Password_label);
            this.groupBox_Config.Controls.Add(this.ID_label);
            this.groupBox_Config.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Config.Location = new System.Drawing.Point(2, 2);
            this.groupBox_Config.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Config.Name = "groupBox_Config";
            this.groupBox_Config.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Config.Size = new System.Drawing.Size(263, 482);
            this.groupBox_Config.TabIndex = 15;
            this.groupBox_Config.TabStop = false;
            this.groupBox_Config.Text = "User Creation";
            // 
            // Rights_label
            // 
            this.Rights_label.AutoSize = true;
            this.Rights_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rights_label.Location = new System.Drawing.Point(4, 135);
            this.Rights_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Rights_label.Name = "Rights_label";
            this.Rights_label.Size = new System.Drawing.Size(69, 17);
            this.Rights_label.TabIndex = 19;
            this.Rights_label.Text = "Rights : ";
            // 
            // AddUser_Button
            // 
            this.AddUser_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUser_Button.ForeColor = System.Drawing.Color.Black;
            this.AddUser_Button.Location = new System.Drawing.Point(57, 356);
            this.AddUser_Button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AddUser_Button.Name = "AddUser_Button";
            this.AddUser_Button.Size = new System.Drawing.Size(135, 41);
            this.AddUser_Button.TabIndex = 18;
            this.AddUser_Button.Text = "ADD";
            this.AddUser_Button.UseVisualStyleBackColor = true;
            this.AddUser_Button.Click += new System.EventHandler(this.AddUser_Button_Click);
            // 
            // typeData_label
            // 
            this.typeData_label.AutoSize = true;
            this.typeData_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeData_label.Location = new System.Drawing.Point(149, 60);
            this.typeData_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeData_label.Name = "typeData_label";
            this.typeData_label.Size = new System.Drawing.Size(0, 17);
            this.typeData_label.TabIndex = 13;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.Location = new System.Drawing.Point(4, 78);
            this.Password_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(135, 17);
            this.Password_label.TabIndex = 12;
            this.Password_label.Text = "Write Password : ";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_label.Location = new System.Drawing.Point(9, 31);
            this.ID_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(76, 17);
            this.ID_label.TabIndex = 9;
            this.ID_label.Text = "Write ID :";
            // 
            // ID_box
            // 
            this.ID_box.Location = new System.Drawing.Point(142, 28);
            this.ID_box.Name = "ID_box";
            this.ID_box.Size = new System.Drawing.Size(100, 22);
            this.ID_box.TabIndex = 21;
            // 
            // Password_box
            // 
            this.Password_box.Location = new System.Drawing.Point(142, 75);
            this.Password_box.Name = "Password_box";
            this.Password_box.Size = new System.Drawing.Size(100, 22);
            this.Password_box.TabIndex = 22;
            // 
            // Rights_comboBox
            // 
            this.Rights_comboBox.FormattingEnabled = true;
            this.Rights_comboBox.Location = new System.Drawing.Point(142, 128);
            this.Rights_comboBox.Name = "Rights_comboBox";
            this.Rights_comboBox.Size = new System.Drawing.Size(100, 24);
            this.Rights_comboBox.TabIndex = 23;
            // 
            // UsersConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_Config);
            this.Name = "UsersConfig";
            this.Size = new System.Drawing.Size(267, 493);
            this.groupBox_Config.ResumeLayout(false);
            this.groupBox_Config.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Config;
        private System.Windows.Forms.Label Rights_label;
        private System.Windows.Forms.Button AddUser_Button;
        private System.Windows.Forms.Label typeData_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.TextBox Password_box;
        private System.Windows.Forms.TextBox ID_box;
        private System.Windows.Forms.ComboBox Rights_comboBox;
    }
}
