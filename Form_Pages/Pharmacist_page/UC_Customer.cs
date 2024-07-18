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
        PharmacistDashBord dashbord;
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
           
            timer1.Start();
        }
        public void refreshCustomer()
        {
            query = "Select * from Customer";
            DataSet dataset = connectionFunction.GetData(query);
            dataGridView1.DataSource = dataset.Tables[0];
        }
        string CusID;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CusID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show("Selected user: " + CusID);

            }
            catch
            {
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if(CusID == null)
            {

                MessageBox.Show("No Customerrr Selected");
            }
            else
            {
                AddMedication addMedication = new AddMedication(CusID);
                addMedication.Show();
                this.Hide();
            }
            



        }
        //Delete Selected customer from DB
        string username;
        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                query = "Delete from Customer where CustomerId ='" + CusID + "'";
                connectionFunction.AddData(query);
                UC_Customer_Load(this, null);
            }
            catch
            {
                MessageBox.Show("Something went wrong try again");
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            refreshCustomer();
            timer1.Start();
        }
    }
}
