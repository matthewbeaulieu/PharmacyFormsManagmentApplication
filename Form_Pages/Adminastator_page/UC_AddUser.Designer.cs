namespace PharmacyFormsManagmentApplication.Form_Pages.Adminastator_page
{
    partial class UC_AddUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_AddUser = new System.Windows.Forms.Button();
            this.button_rest = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this._UserRoleDesign = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_dob = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add User\r\n";
            // 
            // button_AddUser
            // 
            this.button_AddUser.Location = new System.Drawing.Point(645, 379);
            this.button_AddUser.Name = "button_AddUser";
            this.button_AddUser.Size = new System.Drawing.Size(75, 23);
            this.button_AddUser.TabIndex = 1;
            this.button_AddUser.Text = "Add User";
            this.button_AddUser.UseVisualStyleBackColor = true;
            this.button_AddUser.Click += new System.EventHandler(this.button_AddUser_Click);
            // 
            // button_rest
            // 
            this.button_rest.Location = new System.Drawing.Point(748, 379);
            this.button_rest.Name = "button_rest";
            this.button_rest.Size = new System.Drawing.Size(75, 23);
            this.button_rest.TabIndex = 2;
            this.button_rest.Text = "Reset";
            this.button_rest.UseVisualStyleBackColor = true;
            this.button_rest.Click += new System.EventHandler(this.button_rest_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(69, 197);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(177, 20);
            this.textBox_name.TabIndex = 3;
            // 
            // _UserRoleDesign
            // 
            this._UserRoleDesign.FormattingEnabled = true;
            this._UserRoleDesign.Items.AddRange(new object[] {
            "administrator",
            "Pharmacist"});
            this._UserRoleDesign.Location = new System.Drawing.Point(69, 121);
            this._UserRoleDesign.Name = "_UserRoleDesign";
            this._UserRoleDesign.Size = new System.Drawing.Size(177, 21);
            this._UserRoleDesign.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add role";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // dateTimePicker_dob
            // 
            this.dateTimePicker_dob.Location = new System.Drawing.Point(72, 287);
            this.dateTimePicker_dob.Name = "dateTimePicker_dob";
            this.dateTimePicker_dob.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_dob.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date Of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(660, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "User Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(660, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Password";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(660, 121);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(141, 20);
            this.textBox_UserName.TabIndex = 11;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(660, 246);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(141, 20);
            this.textBox_Password.TabIndex = 12;
            // 
            // UC_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker_dob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._UserRoleDesign);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_rest);
            this.Controls.Add(this.button_AddUser);
            this.Controls.Add(this.label1);
            this.Name = "UC_AddUser";
            this.Size = new System.Drawing.Size(1104, 770);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AddUser;
        private System.Windows.Forms.Button button_rest;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.ComboBox _UserRoleDesign;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.TextBox textBox_Password;
    }
}
