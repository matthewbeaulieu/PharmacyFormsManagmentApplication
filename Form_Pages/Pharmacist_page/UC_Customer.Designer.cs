namespace PharmacyFormsManagmentApplication.Form_Pages.Pharmacist_page
{
    partial class UC_Customer
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Delete = new System.Windows.Forms.Button();
            this.textBox_firstname = new System.Windows.Forms.TextBox();
            this.textbox_middle = new System.Windows.Forms.MaskedTextBox();
            this.TextBox_phone = new System.Windows.Forms.MaskedTextBox();
            this.textbox_lastname = new System.Windows.Forms.MaskedTextBox();
            this.textBox_email = new System.Windows.Forms.MaskedTextBox();
            this.label_firstname = new System.Windows.Forms.Label();
            this.label_MiddelName = new System.Windows.Forms.Label();
            this.label_lastname = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_Addmed = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(418, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(144, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(687, 333);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_Delete
            // 
            this.button_Delete.FlatAppearance.BorderSize = 0;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.Color.White;
            this.button_Delete.Location = new System.Drawing.Point(681, 576);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(150, 32);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Delete Customer";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // textBox_firstname
            // 
            this.textBox_firstname.Location = new System.Drawing.Point(246, 504);
            this.textBox_firstname.Name = "textBox_firstname";
            this.textBox_firstname.Size = new System.Drawing.Size(100, 20);
            this.textBox_firstname.TabIndex = 3;
            // 
            // textbox_middle
            // 
            this.textbox_middle.Location = new System.Drawing.Point(246, 597);
            this.textbox_middle.Name = "textbox_middle";
            this.textbox_middle.Size = new System.Drawing.Size(100, 20);
            this.textbox_middle.TabIndex = 4;
            // 
            // TextBox_phone
            // 
            this.TextBox_phone.Location = new System.Drawing.Point(246, 683);
            this.TextBox_phone.Name = "TextBox_phone";
            this.TextBox_phone.Size = new System.Drawing.Size(100, 20);
            this.TextBox_phone.TabIndex = 5;
            // 
            // textbox_lastname
            // 
            this.textbox_lastname.Location = new System.Drawing.Point(455, 504);
            this.textbox_lastname.Name = "textbox_lastname";
            this.textbox_lastname.Size = new System.Drawing.Size(100, 20);
            this.textbox_lastname.TabIndex = 6;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(455, 597);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(100, 20);
            this.textBox_email.TabIndex = 7;
            // 
            // label_firstname
            // 
            this.label_firstname.AutoSize = true;
            this.label_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firstname.ForeColor = System.Drawing.Color.White;
            this.label_firstname.Location = new System.Drawing.Point(246, 458);
            this.label_firstname.Name = "label_firstname";
            this.label_firstname.Size = new System.Drawing.Size(86, 20);
            this.label_firstname.TabIndex = 8;
            this.label_firstname.Text = "First Name";
            // 
            // label_MiddelName
            // 
            this.label_MiddelName.AutoSize = true;
            this.label_MiddelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MiddelName.ForeColor = System.Drawing.Color.White;
            this.label_MiddelName.Location = new System.Drawing.Point(246, 561);
            this.label_MiddelName.Name = "label_MiddelName";
            this.label_MiddelName.Size = new System.Drawing.Size(91, 20);
            this.label_MiddelName.TabIndex = 9;
            this.label_MiddelName.Text = "Middle inital";
            // 
            // label_lastname
            // 
            this.label_lastname.AutoSize = true;
            this.label_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lastname.ForeColor = System.Drawing.Color.White;
            this.label_lastname.Location = new System.Drawing.Point(452, 458);
            this.label_lastname.Name = "label_lastname";
            this.label_lastname.Size = new System.Drawing.Size(86, 20);
            this.label_lastname.TabIndex = 10;
            this.label_lastname.Text = "Last Name";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.ForeColor = System.Drawing.Color.White;
            this.label_email.Location = new System.Drawing.Point(451, 561);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(102, 20);
            this.label_email.TabIndex = 11;
            this.label_email.Text = "Email Adress";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.ForeColor = System.Drawing.Color.White;
            this.label_phone.Location = new System.Drawing.Point(246, 650);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(113, 20);
            this.label_phone.TabIndex = 12;
            this.label_phone.Text = "Phone number";
            // 
            // button_save
            // 
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Location = new System.Drawing.Point(426, 670);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(129, 42);
            this.button_save.TabIndex = 13;
            this.button_save.Text = "Add Customer";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_Addmed
            // 
            this.button_Addmed.FlatAppearance.BorderSize = 0;
            this.button_Addmed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Addmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Addmed.ForeColor = System.Drawing.Color.White;
            this.button_Addmed.Location = new System.Drawing.Point(681, 504);
            this.button_Addmed.Name = "button_Addmed";
            this.button_Addmed.Size = new System.Drawing.Size(150, 29);
            this.button_Addmed.TabIndex = 14;
            this.button_Addmed.Text = "Add Medications";
            this.button_Addmed.UseVisualStyleBackColor = true;
            this.button_Addmed.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.Controls.Add(this.button_Addmed);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_lastname);
            this.Controls.Add(this.label_MiddelName);
            this.Controls.Add(this.label_firstname);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textbox_lastname);
            this.Controls.Add(this.TextBox_phone);
            this.Controls.Add(this.textbox_middle);
            this.Controls.Add(this.textBox_firstname);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "UC_Customer";
            this.Size = new System.Drawing.Size(1104, 770);
            this.Load += new System.EventHandler(this.UC_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.TextBox textBox_firstname;
        private System.Windows.Forms.MaskedTextBox textbox_middle;
        private System.Windows.Forms.MaskedTextBox TextBox_phone;
        private System.Windows.Forms.MaskedTextBox textbox_lastname;
        private System.Windows.Forms.MaskedTextBox textBox_email;
        private System.Windows.Forms.Label label_firstname;
        private System.Windows.Forms.Label label_MiddelName;
        private System.Windows.Forms.Label label_lastname;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_Addmed;
        private System.Windows.Forms.Timer timer1;
    }
}
