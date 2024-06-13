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
            query = "Select * from medication";
            DataSet dataSet = connectionFunction.GetData(query);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
