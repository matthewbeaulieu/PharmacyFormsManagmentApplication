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

namespace PharmacyFormsManagmentApplication.Form_Pages.Adminastator_page
{
    public partial class UC_medications : UserControl
    {
        ConnectionFunction connectionFunction = new ConnectionFunction();
        string query;
        public UC_medications()
        {
            InitializeComponent();
        }

        private void UC_medications_Load(object sender, EventArgs e)
        {
            query = "Select * from medications";
            DataSet ds = connectionFunction.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string type = textBox2.Text;

            try
            {
                query = "INSERT INTO Customer (medicationName, medicationType) Values ('" + name + "', '" + type +"')";
            }
            catch { }
        }
    }
}
