using PharmacyFormsManagmentApplication.ConnectionData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacyFormsManagmentApplication.Form_Pages.Pharmacist_page
{
    public partial class UC_Medications : UserControl
    {
        ConnectionFunction connectionFunction = new ConnectionFunction();
        string query;
        public UC_Medications()
        {
            InitializeComponent();
        }
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UC_Medications_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
        }
        public void refresh()
        {
            query = "Select * from medication";
            DataSet dataSet = connectionFunction.GetData(query);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
        string user;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                user = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show("user ID:" + user);

            }
            catch
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string med = textBox_medname.Text;
            string type = textBox_type.Text;
            try
            {
                query = "INSERT INTO medication (medicationName, medicationType) Values ('" + med + "', '" + type + "')";
                connectionFunction.AddData(query);
                textBox_medname.Clear();
                textBox_type.Clear();
                UC_Medications_Load(this, null);

            }
            catch 
            {
                MessageBox.Show("Something went wrong!");
            }
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            refresh();
            timer1.Start();
        }

        private void Button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                query = "delete from medication where medications = '" + user + "'";
                connectionFunction.AddData(query);
                UC_Medications_Load(this, null);
            }
            catch
            {
                MessageBox.Show("Something went wrong!");
            }
            
        }
    }
}
