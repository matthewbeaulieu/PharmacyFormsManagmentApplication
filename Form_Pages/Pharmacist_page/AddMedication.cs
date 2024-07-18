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

namespace PharmacyFormsManagmentApplication.Form_Pages.Pharmacist_page
{
    public partial class AddMedication : Form
    {
        string id;
        string query;
        ConnectionFunction connectionfunction = new ConnectionFunction();
        public AddMedication()
        {
            InitializeComponent();
        }
        public AddMedication(string num)
        {
            InitializeComponent();
            id = num;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AddMedication_Load(object sender, EventArgs e)
        {
            query = "select * from Customer where CustomerId = '" + id + "'";
            DataSet ds = connectionfunction.GetData(query);
            comboBox1.Text = ds.Tables[0].Rows[0][1].ToString();
            label_firstname.Text = ds.Tables[0].Rows[0][2].ToString();
            label_middle.Text = ds.Tables[0].Rows[0][3].ToString();
            label_lastname.Text = ds.Tables[0].Rows[0][4].ToString();
            label_email.Text = ds.Tables[0].Rows[0][5].ToString();
            label_phone.Text = ds.Tables[0].Rows[0][6].ToString();
            textBox_med1.Text = ds.Tables[0].Rows[0][7].ToString();
            textBox_med2.Text = ds.Tables[0].Rows[0][8].ToString();
            textBox_med3.Text = ds.Tables[0].Rows[0][9].ToString();
            textBox_med4.Text = ds.Tables[0].Rows[0][10].ToString();
            textBox_med5.Text = ds.Tables[0].Rows[0][11].ToString();
            textBox_med6.Text = ds.Tables[0].Rows[0][12].ToString();
            Med7.Text = ds.Tables[0].Rows[0][13].ToString();
            textBox_med8.Text = ds.Tables[0].Rows[0][14].ToString();
            textBox_med9.Text = ds.Tables[0].Rows[0][15].ToString();
            textBox_med10.Text = ds.Tables[0].Rows[0][16].ToString();

                timer1.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Medication1 = textBox_med1.Text;
            string Medication2 = textBox_med2.Text;
            string Medication3 = textBox_med3.Text;
            string Medication4 = textBox_med4.Text;
            string Medication5 = textBox_med5.Text;
            string Medication6 = textBox_med6.Text;
            string medication7 = Med7.Text;
            string Medication8 = textBox_med8.Text;
            string Medication9 = textBox_med9.Text;
            string Medication10 = textBox_med10.Text;
            string dropdown = comboBox1.Text;
            if (dropdown != "")
            {
                query = "update Customer set OrderStatus ='" + dropdown + "' Where Customerid ='" + id + "'";
                connectionfunction.AddData(query);
            }
            if (Medication1 != "")
            {
                query = "update Customer set Medication1 ='" + Medication1 + "' Where Customerid ='" + id + "'";
                connectionfunction.AddData(query);
            }
            if (Medication2 != "")
            {
                query = "update Customer set Medication2 ='" + Medication2 + "' Where Customerid ='" + id + "'";
                connectionfunction.AddData(query);
            }
            if (Medication3 != "")
            {
                query = "update Customer set Medication3 ='" + Medication3 + "' Where Customerid ='" + id + "'";
                connectionfunction.AddData(query);
            }
            if (Medication4 != "")
            {
                query = "update Customer set Medication4 ='" + Medication4 + "' Where Customerid ='" + id + "'";
                connectionfunction.AddData(query);
            }
            if (Medication5 != "")
            {
                query = "update Customer set Medication5 ='" + Medication5 + "' Where Customerid ='" + id + "'";
                connectionfunction.AddData(query);
            }
            if (Medication6 != "")
            {
                query = "update Customer set Medication6 ='" + Medication6 + "' Where Customerid ='" + id + "'";
                connectionfunction.AddData(query);
            }
            if (medication7 != "")
            {
                query = "update Customer set Medication7 ='" + medication7 + "' Where Customerid ='" + id + "'";
                connectionfunction.AddData(query);
            }
            if (Medication8 != "")
            {
                query = "update Customer set Medication8 ='" + Medication8 + "' Where Customerid ='" + id + "'";
                connectionfunction.AddData(query);
            }
            if (Medication9 != "")
            {
                query = "update Customer set Medication9 ='" + Medication9 + "' Where Customerid ='" + id + "'";
                connectionfunction.AddData(query);
            }
            if (Medication10 != "")
            {
                query = "update Customer set Medication10 ='" + Medication10 + "' Where Customerid ='" + id + "'";
                connectionfunction.AddData(query);
            }
            
        }
        public void refresh()
        {
            query = "Select * from medication";
            DataSet dataSet = connectionfunction.GetData(query);
            dataGridView1.DataSource = dataSet.Tables[0];

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            refresh();
            timer1.Start();
        }
    }
}
