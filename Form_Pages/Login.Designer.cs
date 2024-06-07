namespace PharmacyFormsManagmentApplication
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Label1 = new System.Windows.Forms.Label();
            this.text_UserName = new System.Windows.Forms.TextBox();
            this.text_Password = new System.Windows.Forms.TextBox();
            this.Button_login = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(590, 79);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(244, 42);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Pharmacy Managment System\r\nPlease Login to Continue\r\n";
            // 
            // text_UserName
            // 
            this.text_UserName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_UserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.text_UserName.Location = new System.Drawing.Point(593, 189);
            this.text_UserName.Name = "text_UserName";
            this.text_UserName.Size = new System.Drawing.Size(203, 21);
            this.text_UserName.TabIndex = 1;
            this.text_UserName.Text = "User Name";
            // 
            // text_Password
            // 
            this.text_Password.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.text_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Password.Location = new System.Drawing.Point(593, 260);
            this.text_Password.Name = "text_Password";
            this.text_Password.Size = new System.Drawing.Size(203, 21);
            this.text_Password.TabIndex = 2;
            this.text_Password.Text = "Password";
            // 
            // Button_login
            // 
            this.Button_login.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Button_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_login.Cursor = System.Windows.Forms.Cursors.Default;
            this.Button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_login.ForeColor = System.Drawing.Color.Black;
            this.Button_login.Location = new System.Drawing.Point(593, 320);
            this.Button_login.Name = "Button_login";
            this.Button_login.Size = new System.Drawing.Size(147, 23);
            this.Button_login.TabIndex = 3;
            this.Button_login.Text = "Login";
            this.Button_login.UseVisualStyleBackColor = false;
            this.Button_login.Click += new System.EventHandler(this.Button_login_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.Color.Red;
            this.Button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Exit.Location = new System.Drawing.Point(593, 381);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(147, 23);
            this.Button_Exit.TabIndex = 4;
            this.Button_Exit.Text = "Exit";
            this.Button_Exit.UseVisualStyleBackColor = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_login);
            this.Controls.Add(this.text_Password);
            this.Controls.Add(this.text_UserName);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox text_UserName;
        public System.Windows.Forms.TextBox text_Password;
        public System.Windows.Forms.Button Button_login;
        private System.Windows.Forms.Button Button_Exit;
    }
}

