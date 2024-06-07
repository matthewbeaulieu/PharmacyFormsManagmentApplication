namespace PharmacyFormsManagmentApplication
{
    partial class AdminDashBord
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_admin_profiles = new System.Windows.Forms.Button();
            this.button_admin_viewusers = new System.Windows.Forms.Button();
            this.button_admin_AddUser = new System.Windows.Forms.Button();
            this.button_admin_Dashbord = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button_logout);
            this.panel1.Controls.Add(this.button_admin_profiles);
            this.panel1.Controls.Add(this.button_admin_viewusers);
            this.panel1.Controls.Add(this.button_admin_AddUser);
            this.panel1.Controls.Add(this.button_admin_Dashbord);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 782);
            this.panel1.TabIndex = 0;
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(76, 273);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(154, 34);
            this.button_logout.TabIndex = 4;
            this.button_logout.Text = "Log Out";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_admin_profiles
            // 
            this.button_admin_profiles.Location = new System.Drawing.Point(76, 204);
            this.button_admin_profiles.Name = "button_admin_profiles";
            this.button_admin_profiles.Size = new System.Drawing.Size(154, 34);
            this.button_admin_profiles.TabIndex = 3;
            this.button_admin_profiles.Text = "Profiles";
            this.button_admin_profiles.UseVisualStyleBackColor = true;
            // 
            // button_admin_viewusers
            // 
            this.button_admin_viewusers.Location = new System.Drawing.Point(76, 142);
            this.button_admin_viewusers.Name = "button_admin_viewusers";
            this.button_admin_viewusers.Size = new System.Drawing.Size(154, 34);
            this.button_admin_viewusers.TabIndex = 2;
            this.button_admin_viewusers.Text = "View Users";
            this.button_admin_viewusers.UseVisualStyleBackColor = true;
            // 
            // button_admin_AddUser
            // 
            this.button_admin_AddUser.Location = new System.Drawing.Point(76, 74);
            this.button_admin_AddUser.Name = "button_admin_AddUser";
            this.button_admin_AddUser.Size = new System.Drawing.Size(154, 34);
            this.button_admin_AddUser.TabIndex = 1;
            this.button_admin_AddUser.Text = "Add User";
            this.button_admin_AddUser.UseVisualStyleBackColor = true;
            // 
            // button_admin_Dashbord
            // 
            this.button_admin_Dashbord.Location = new System.Drawing.Point(76, 13);
            this.button_admin_Dashbord.Name = "button_admin_Dashbord";
            this.button_admin_Dashbord.Size = new System.Drawing.Size(154, 34);
            this.button_admin_Dashbord.TabIndex = 0;
            this.button_admin_Dashbord.Text = "Dashbord";
            this.button_admin_Dashbord.UseVisualStyleBackColor = true;
            this.button_admin_Dashbord.Click += new System.EventHandler(this.button_admin_Dashbord_Click);
            // 
            // AdminDashBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1360, 780);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashBord";
            this.Text = "AdminDashBord";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_admin_Dashbord;
        private System.Windows.Forms.Button button_admin_profiles;
        private System.Windows.Forms.Button button_admin_viewusers;
        private System.Windows.Forms.Button button_admin_AddUser;
        private System.Windows.Forms.Button button_logout;
    }
}