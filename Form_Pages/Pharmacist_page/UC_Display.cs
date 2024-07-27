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
    public partial class UC_Display : UserControl
    {
        string qeury;
        ConnectionFunction connectionFunction = new ConnectionFunction();
        public UC_Display()
        {
            InitializeComponent();
        }

        private void UC_Display_Load(object sender, EventArgs e)
        {
            refresh();
            timer1.Start();
        }
        public void refresh()
        {
            qeury = "Select CustomerId ,OrderStatus, FirstName, LastName, PhoneNumber, Medication1, Medication2, Medication3, Medication4, Medication5, Medication6, Medication7, Medication8, Medication9, Medication10 from Customer\r\n";
            DataSet dataset = connectionFunction.GetData(qeury);
            dataGridView_customer.DataSource = dataset.Tables[0];
        }
        string cusid;
        private void dataGridView_customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cusid = dataGridView_customer.Rows[e.RowIndex].Cells[0].Value.ToString();
            MessageBox.Show("userid:" + cusid);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refresh();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            qeury = "update Customer set OrderStatus = 'Complete' where CustomerId = '" + cusid + "';";
            connectionFunction.AddData(qeury);
        }
    }
}
