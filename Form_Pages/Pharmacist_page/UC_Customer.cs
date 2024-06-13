using PharmacyFormsManagmentApplication.ConnectionData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacyFormsManagmentApplication.Form_Pages.Pharmacist_page
{
    public partial class UC_Customer : UserControl
    {
        ConnectionFunction connectionFunction = new ConnectionFunction();
        string query;
        string current;
        public UC_Customer()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { current = value; }
        }
        private void UC_Customer_Load(object sender, EventArgs e)
        {
            query ="Select * from Customer";
            DataSet dataset = connectionFunction.GetData(query);
            dataGridView1.DataSource = dataset.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //need to fix connection so it actualy get and delete 
        string username;
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (current != username)
            {
                query = "Delete from Customer where username ='" + username + "'";
                connectionFunction.AddData(query);
                UC_Customer_Load(this, null);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string firstname = textBox_firstname.Text;
            string lastname = textbox_lastname.Text;
            string middel = textbox_middle.Text;
            string email = textBox_email.Text;
            string phone = TextBox_phone.Text;

            try
            {
                query = "INSERT INTO Customer (FirstName, Middelintial, LastName, email, phonenumber) Values ('" + firstname + "', '" + middel + "', '" + lastname + "', '" + email + "','" + phone + "')";
                connectionFunction.AddData(query);

                textBox_firstname.Clear();
                textbox_lastname.Clear();
                textbox_middle.Clear();
                textBox_email.Clear();
                TextBox_phone.Clear();
            }
            catch
            {
                MessageBox.Show("error please enter Correct Information!");
            }
        }
    }
}
