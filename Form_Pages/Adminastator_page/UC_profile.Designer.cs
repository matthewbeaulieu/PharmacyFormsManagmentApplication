namespace PharmacyFormsManagmentApplication.Form_Pages.Adminastator_page
{
    partial class UC_profile
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
            this.text_username = new System.Windows.Forms.TextBox();
            this.label_role = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_DoB = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_pdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_username
            // 
            this.text_username.Location = new System.Drawing.Point(733, 108);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(100, 20);
            this.text_username.TabIndex = 0;
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_role.Location = new System.Drawing.Point(395, 189);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(51, 20);
            this.label_role.TabIndex = 1;
            this.label_role.Text = "label1";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(395, 370);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(78, 20);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Password";
            // 
            // label_DoB
            // 
            this.label_DoB.AutoSize = true;
            this.label_DoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DoB.Location = new System.Drawing.Point(395, 316);
            this.label_DoB.Name = "label_DoB";
            this.label_DoB.Size = new System.Drawing.Size(51, 20);
            this.label_DoB.TabIndex = 3;
            this.label_DoB.Text = "label3";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(395, 251);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(51, 20);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "label4";
            this.label_name.Click += new System.EventHandler(this.label_name_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(398, 409);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 20);
            this.textBox_password.TabIndex = 5;
            // 
            // button_pdate
            // 
            this.button_pdate.Location = new System.Drawing.Point(398, 496);
            this.button_pdate.Name = "button_pdate";
            this.button_pdate.Size = new System.Drawing.Size(75, 23);
            this.button_pdate.TabIndex = 6;
            this.button_pdate.Text = "update password";
            this.button_pdate.UseVisualStyleBackColor = true;
            this.button_pdate.Click += new System.EventHandler(this.button_pdate_Click);
            // 
            // UC_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_pdate);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_DoB);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_role);
            this.Controls.Add(this.text_username);
            this.Name = "UC_profile";
            this.Size = new System.Drawing.Size(1104, 770);
            this.Load += new System.EventHandler(this.UC_profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox text_username;
        private System.Windows.Forms.Label label_role;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_DoB;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_pdate;
    }
}
