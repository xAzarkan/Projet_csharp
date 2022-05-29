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
            this.groupBox_Creation = new System.Windows.Forms.GroupBox();
            this.Rights_comboBox = new System.Windows.Forms.ComboBox();
            this.Password_box = new System.Windows.Forms.TextBox();
            this.ID_box = new System.Windows.Forms.TextBox();
            this.Rights_label = new System.Windows.Forms.Label();
            this.AddUser_Button = new System.Windows.Forms.Button();
            this.typeData_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.groupBox_Login = new System.Windows.Forms.GroupBox();
            this.userPassword_box = new System.Windows.Forms.TextBox();
            this.userName_box = new System.Windows.Forms.TextBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_Creation.SuspendLayout();
            this.groupBox_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Creation
            // 
            this.groupBox_Creation.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox_Creation.Controls.Add(this.Rights_comboBox);
            this.groupBox_Creation.Controls.Add(this.Password_box);
            this.groupBox_Creation.Controls.Add(this.ID_box);
            this.groupBox_Creation.Controls.Add(this.Rights_label);
            this.groupBox_Creation.Controls.Add(this.AddUser_Button);
            this.groupBox_Creation.Controls.Add(this.typeData_label);
            this.groupBox_Creation.Controls.Add(this.Password_label);
            this.groupBox_Creation.Controls.Add(this.ID_label);
            this.groupBox_Creation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Creation.Location = new System.Drawing.Point(4, 8);
            this.groupBox_Creation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Creation.Name = "groupBox_Creation";
            this.groupBox_Creation.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Creation.Size = new System.Drawing.Size(526, 530);
            this.groupBox_Creation.TabIndex = 15;
            this.groupBox_Creation.TabStop = false;
            this.groupBox_Creation.Text = "User Creation";
            // 
            // Rights_comboBox
            // 
            this.Rights_comboBox.FormattingEnabled = true;
            this.Rights_comboBox.Location = new System.Drawing.Point(284, 246);
            this.Rights_comboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Rights_comboBox.Name = "Rights_comboBox";
            this.Rights_comboBox.Size = new System.Drawing.Size(196, 24);
            this.Rights_comboBox.TabIndex = 23;
            // 
            // Password_box
            // 
            this.Password_box.Location = new System.Drawing.Point(284, 144);
            this.Password_box.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Password_box.Name = "Password_box";
            this.Password_box.Size = new System.Drawing.Size(196, 22);
            this.Password_box.TabIndex = 22;
            // 
            // ID_box
            // 
            this.ID_box.Location = new System.Drawing.Point(284, 54);
            this.ID_box.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ID_box.Name = "ID_box";
            this.ID_box.Size = new System.Drawing.Size(196, 22);
            this.ID_box.TabIndex = 21;
            // 
            // Rights_label
            // 
            this.Rights_label.AutoSize = true;
            this.Rights_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rights_label.Location = new System.Drawing.Point(18, 252);
            this.Rights_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Rights_label.Name = "Rights_label";
            this.Rights_label.Size = new System.Drawing.Size(69, 17);
            this.Rights_label.TabIndex = 19;
            this.Rights_label.Text = "Rights : ";
            // 
            // AddUser_Button
            // 
            this.AddUser_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUser_Button.ForeColor = System.Drawing.Color.Black;
            this.AddUser_Button.Location = new System.Drawing.Point(108, 399);
            this.AddUser_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddUser_Button.Name = "AddUser_Button";
            this.AddUser_Button.Size = new System.Drawing.Size(270, 79);
            this.AddUser_Button.TabIndex = 18;
            this.AddUser_Button.Text = "CREATE USER";
            this.AddUser_Button.UseVisualStyleBackColor = true;
            this.AddUser_Button.Click += new System.EventHandler(this.AddUser_Button_Click);
            // 
            // typeData_label
            // 
            this.typeData_label.AutoSize = true;
            this.typeData_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeData_label.Location = new System.Drawing.Point(298, 115);
            this.typeData_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeData_label.Name = "typeData_label";
            this.typeData_label.Size = new System.Drawing.Size(0, 17);
            this.typeData_label.TabIndex = 13;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.Location = new System.Drawing.Point(18, 150);
            this.Password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(135, 17);
            this.Password_label.TabIndex = 12;
            this.Password_label.Text = "Write Password : ";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_label.Location = new System.Drawing.Point(18, 60);
            this.ID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(102, 17);
            this.ID_label.TabIndex = 9;
            this.ID_label.Text = "Write Name :";
            // 
            // groupBox_Login
            // 
            this.groupBox_Login.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox_Login.Controls.Add(this.userPassword_box);
            this.groupBox_Login.Controls.Add(this.userName_box);
            this.groupBox_Login.Controls.Add(this.Login_Button);
            this.groupBox_Login.Controls.Add(this.label2);
            this.groupBox_Login.Controls.Add(this.label3);
            this.groupBox_Login.Controls.Add(this.label4);
            this.groupBox_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Login.Location = new System.Drawing.Point(4, 565);
            this.groupBox_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Login.Name = "groupBox_Login";
            this.groupBox_Login.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Login.Size = new System.Drawing.Size(526, 342);
            this.groupBox_Login.TabIndex = 24;
            this.groupBox_Login.TabStop = false;
            this.groupBox_Login.Text = "User Login";
            // 
            // userPassword_box
            // 
            this.userPassword_box.Location = new System.Drawing.Point(284, 144);
            this.userPassword_box.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.userPassword_box.Name = "userPassword_box";
            this.userPassword_box.Size = new System.Drawing.Size(196, 22);
            this.userPassword_box.TabIndex = 22;
            // 
            // userName_box
            // 
            this.userName_box.Location = new System.Drawing.Point(284, 54);
            this.userName_box.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.userName_box.Name = "userName_box";
            this.userName_box.Size = new System.Drawing.Size(196, 22);
            this.userName_box.TabIndex = 21;
            // 
            // Login_Button
            // 
            this.Login_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Button.ForeColor = System.Drawing.Color.Black;
            this.Login_Button.Location = new System.Drawing.Point(108, 229);
            this.Login_Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(270, 79);
            this.Login_Button.TabIndex = 18;
            this.Login_Button.Text = "LOG IN";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Write Password : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Write Name :";
            // 
            // UsersConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Controls.Add(this.groupBox_Login);
            this.Controls.Add(this.groupBox_Creation);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UsersConfig";
            this.Size = new System.Drawing.Size(534, 931);
            this.groupBox_Creation.ResumeLayout(false);
            this.groupBox_Creation.PerformLayout();
            this.groupBox_Login.ResumeLayout(false);
            this.groupBox_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Rights_label;
        private System.Windows.Forms.Label typeData_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.GroupBox groupBox_Login;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox Rights_comboBox;
        public System.Windows.Forms.TextBox Password_box;
        public System.Windows.Forms.TextBox ID_box;
        public System.Windows.Forms.TextBox userPassword_box;
        public System.Windows.Forms.TextBox userName_box;
        public System.Windows.Forms.GroupBox groupBox_Creation;
        internal System.Windows.Forms.Button AddUser_Button;
    }
}
