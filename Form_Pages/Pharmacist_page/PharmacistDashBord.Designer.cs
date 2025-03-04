﻿namespace PharmacyFormsManagmentApplication
{
    partial class PharmacistDashBord
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
            this.button_med = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.CustomerInfo_button = new System.Windows.Forms.Button();
            this.LogOut_button = new System.Windows.Forms.Button();
            this.DashBord_button = new System.Windows.Forms.Button();
            this.uC_Display1 = new PharmacyFormsManagmentApplication.Form_Pages.Pharmacist_page.UC_Display();
            this.uC_Customer1 = new PharmacyFormsManagmentApplication.Form_Pages.Pharmacist_page.UC_Customer();
            this.uC_Medications1 = new PharmacyFormsManagmentApplication.Form_Pages.Pharmacist_page.UC_Medications();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.button_med);
            this.panel1.Controls.Add(this.button_logout);
            this.panel1.Controls.Add(this.CustomerInfo_button);
            this.panel1.Controls.Add(this.LogOut_button);
            this.panel1.Controls.Add(this.DashBord_button);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 770);
            this.panel1.TabIndex = 0;
            // 
            // button_med
            // 
            this.button_med.FlatAppearance.BorderSize = 0;
            this.button_med.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_med.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_med.ForeColor = System.Drawing.Color.White;
            this.button_med.Location = new System.Drawing.Point(34, 389);
            this.button_med.Name = "button_med";
            this.button_med.Size = new System.Drawing.Size(157, 41);
            this.button_med.TabIndex = 6;
            this.button_med.Text = "Medications";
            this.button_med.UseVisualStyleBackColor = true;
            this.button_med.Click += new System.EventHandler(this.button_med_Click);
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.Transparent;
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.ForeColor = System.Drawing.Color.White;
            this.button_logout.Location = new System.Drawing.Point(0, 649);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(232, 45);
            this.button_logout.TabIndex = 5;
            this.button_logout.Text = "Exit Application";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // CustomerInfo_button
            // 
            this.CustomerInfo_button.FlatAppearance.BorderSize = 0;
            this.CustomerInfo_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerInfo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerInfo_button.ForeColor = System.Drawing.Color.White;
            this.CustomerInfo_button.Location = new System.Drawing.Point(34, 311);
            this.CustomerInfo_button.Name = "CustomerInfo_button";
            this.CustomerInfo_button.Size = new System.Drawing.Size(157, 40);
            this.CustomerInfo_button.TabIndex = 4;
            this.CustomerInfo_button.Text = "Customers";
            this.CustomerInfo_button.UseVisualStyleBackColor = true;
            this.CustomerInfo_button.Click += new System.EventHandler(this.CustomerInfo_button_Click);
            // 
            // LogOut_button
            // 
            this.LogOut_button.FlatAppearance.BorderSize = 0;
            this.LogOut_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut_button.ForeColor = System.Drawing.Color.White;
            this.LogOut_button.Location = new System.Drawing.Point(48, 589);
            this.LogOut_button.Name = "LogOut_button";
            this.LogOut_button.Size = new System.Drawing.Size(130, 39);
            this.LogOut_button.TabIndex = 3;
            this.LogOut_button.Text = "logout";
            this.LogOut_button.UseVisualStyleBackColor = true;
            this.LogOut_button.Click += new System.EventHandler(this.LogOut_button_Click);
            // 
            // DashBord_button
            // 
            this.DashBord_button.FlatAppearance.BorderSize = 0;
            this.DashBord_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashBord_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBord_button.ForeColor = System.Drawing.Color.White;
            this.DashBord_button.Location = new System.Drawing.Point(34, 237);
            this.DashBord_button.Name = "DashBord_button";
            this.DashBord_button.Size = new System.Drawing.Size(157, 44);
            this.DashBord_button.TabIndex = 1;
            this.DashBord_button.Text = "DashBord";
            this.DashBord_button.UseVisualStyleBackColor = true;
            this.DashBord_button.Click += new System.EventHandler(this.DashBord_button_Click);
            // 
            // uC_Display1
            // 
            this.uC_Display1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.uC_Display1.Location = new System.Drawing.Point(301, 1);
            this.uC_Display1.Name = "uC_Display1";
            this.uC_Display1.Size = new System.Drawing.Size(1104, 770);
            this.uC_Display1.TabIndex = 1;
            // 
            // uC_Customer1
            // 
            this.uC_Customer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.uC_Customer1.Location = new System.Drawing.Point(301, 1);
            this.uC_Customer1.Name = "uC_Customer1";
            this.uC_Customer1.Size = new System.Drawing.Size(1104, 770);
            this.uC_Customer1.TabIndex = 3;
            // 
            // uC_Medications1
            // 
            this.uC_Medications1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(52)))), ((int)(((byte)(53)))));
            this.uC_Medications1.Location = new System.Drawing.Point(233, 1);
            this.uC_Medications1.Name = "uC_Medications1";
            this.uC_Medications1.Size = new System.Drawing.Size(1172, 770);
            this.uC_Medications1.TabIndex = 4;
            // 
            // PharmacistDashBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1402, 770);
            this.Controls.Add(this.uC_Medications1);
            this.Controls.Add(this.uC_Customer1);
            this.Controls.Add(this.uC_Display1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PharmacistDashBord";
            this.Text = "PharmacistDashBord";
            this.Load += new System.EventHandler(this.PharmacistDashBord_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DashBord_button;
        private System.Windows.Forms.Button CustomerInfo_button;
        private System.Windows.Forms.Button LogOut_button;
        private System.Windows.Forms.Button button_logout;
        private Form_Pages.Pharmacist_page.UC_Display uC_Display1;
        private Form_Pages.Pharmacist_page.UC_Customer uC_Customer1;
        private System.Windows.Forms.Button button_med;
        private Form_Pages.Pharmacist_page.UC_Medications uC_Medications1;
        
    }
}