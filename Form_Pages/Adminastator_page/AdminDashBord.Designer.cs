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
            this.label_username = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_admin_profiles = new System.Windows.Forms.Button();
            this.button_admin_viewusers = new System.Windows.Forms.Button();
            this.button_admin_AddUser = new System.Windows.Forms.Button();
            this.button_admin_Dashbord = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.uC_profile1 = new PharmacyFormsManagmentApplication.Form_Pages.Adminastator_page.UC_profile();
            this.uC_ViewUsersData1 = new PharmacyFormsManagmentApplication.Form_Pages.Adminastator_page.UC_ViewUsersData();
            this.uC_MainPageDisplay1 = new PharmacyFormsManagmentApplication.Form_Pages.Adminastator_page.UC_MainPageDisplay();
            this.uC_AddUser1 = new PharmacyFormsManagmentApplication.Form_Pages.Adminastator_page.UC_AddUser();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_username);
            this.panel1.Controls.Add(this.button_logout);
            this.panel1.Controls.Add(this.button_admin_profiles);
            this.panel1.Controls.Add(this.button_admin_viewusers);
            this.panel1.Controls.Add(this.button_admin_AddUser);
            this.panel1.Controls.Add(this.button_admin_Dashbord);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 770);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(14, 55);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(185, 24);
            this.label_username.TabIndex = 6;
            this.label_username.Text = "user name displayed";
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(48, 502);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(154, 34);
            this.button_logout.TabIndex = 4;
            this.button_logout.Text = "Log Out";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_admin_profiles
            // 
            this.button_admin_profiles.Location = new System.Drawing.Point(48, 433);
            this.button_admin_profiles.Name = "button_admin_profiles";
            this.button_admin_profiles.Size = new System.Drawing.Size(154, 34);
            this.button_admin_profiles.TabIndex = 3;
            this.button_admin_profiles.Text = "Profiles";
            this.button_admin_profiles.UseVisualStyleBackColor = true;
            this.button_admin_profiles.Click += new System.EventHandler(this.button_admin_profiles_Click);
            // 
            // button_admin_viewusers
            // 
            this.button_admin_viewusers.Location = new System.Drawing.Point(48, 371);
            this.button_admin_viewusers.Name = "button_admin_viewusers";
            this.button_admin_viewusers.Size = new System.Drawing.Size(154, 34);
            this.button_admin_viewusers.TabIndex = 2;
            this.button_admin_viewusers.Text = "View Users";
            this.button_admin_viewusers.UseVisualStyleBackColor = true;
            this.button_admin_viewusers.Click += new System.EventHandler(this.button_admin_viewusers_Click);
            // 
            // button_admin_AddUser
            // 
            this.button_admin_AddUser.Location = new System.Drawing.Point(48, 303);
            this.button_admin_AddUser.Name = "button_admin_AddUser";
            this.button_admin_AddUser.Size = new System.Drawing.Size(154, 34);
            this.button_admin_AddUser.TabIndex = 1;
            this.button_admin_AddUser.Text = "Add User";
            this.button_admin_AddUser.UseVisualStyleBackColor = true;
            this.button_admin_AddUser.Click += new System.EventHandler(this.button_admin_AddUser_Click);
            // 
            // button_admin_Dashbord
            // 
            this.button_admin_Dashbord.Location = new System.Drawing.Point(48, 242);
            this.button_admin_Dashbord.Name = "button_admin_Dashbord";
            this.button_admin_Dashbord.Size = new System.Drawing.Size(154, 34);
            this.button_admin_Dashbord.TabIndex = 0;
            this.button_admin_Dashbord.Text = "Dashbord";
            this.button_admin_Dashbord.UseVisualStyleBackColor = true;
            this.button_admin_Dashbord.Click += new System.EventHandler(this.button_admin_Dashbord_Click);
            // 
            // uC_profile1
            // 
            this.uC_profile1.BackColor = System.Drawing.Color.White;
            this.uC_profile1.Location = new System.Drawing.Point(257, -1);
            this.uC_profile1.Name = "uC_profile1";
            this.uC_profile1.Size = new System.Drawing.Size(1104, 770);
            this.uC_profile1.TabIndex = 5;
            // 
            // uC_ViewUsersData1
            // 
            this.uC_ViewUsersData1.Location = new System.Drawing.Point(257, -1);
            this.uC_ViewUsersData1.Name = "uC_ViewUsersData1";
            this.uC_ViewUsersData1.Size = new System.Drawing.Size(1104, 770);
            this.uC_ViewUsersData1.TabIndex = 3;
            // 
            // uC_MainPageDisplay1
            // 
            this.uC_MainPageDisplay1.Location = new System.Drawing.Point(257, -1);
            this.uC_MainPageDisplay1.Name = "uC_MainPageDisplay1";
            this.uC_MainPageDisplay1.Size = new System.Drawing.Size(1104, 770);
            this.uC_MainPageDisplay1.TabIndex = 1;
            // 
            // uC_AddUser1
            // 
            this.uC_AddUser1.Location = new System.Drawing.Point(257, -1);
            this.uC_AddUser1.Name = "uC_AddUser1";
            this.uC_AddUser1.Size = new System.Drawing.Size(1104, 770);
            this.uC_AddUser1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome";
            // 
            // AdminDashBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1360, 770);
            this.Controls.Add(this.uC_profile1);
            this.Controls.Add(this.uC_ViewUsersData1);
            this.Controls.Add(this.uC_MainPageDisplay1);
            this.Controls.Add(this.uC_AddUser1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashBord";
            this.Text = "AdminDashBord";
            this.Load += new System.EventHandler(this.AdminDashBord_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_admin_Dashbord;
        private System.Windows.Forms.Button button_admin_profiles;
        private System.Windows.Forms.Button button_admin_viewusers;
        private System.Windows.Forms.Button button_admin_AddUser;
        private System.Windows.Forms.Button button_logout;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Panel panel1;
        public Form_Pages.Adminastator_page.UC_AddUser uC_AddUser1;
        private Form_Pages.Adminastator_page.UC_MainPageDisplay uC_MainPageDisplay1;
        private Form_Pages.Adminastator_page.UC_ViewUsersData uC_ViewUsersData1;
        private Form_Pages.Adminastator_page.UC_profile uC_profile1;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label1;
    }
}