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
    public partial class UC_Orders : UserControl
    {
        ConnectionFunction connectionfunction = new ConnectionFunction();
        string qeury;

        public UC_Orders()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_Orders_Load(object sender, EventArgs e)
        {
            qeury = "Select * from OrderStatus";
            DataSet ds = connectionfunction.GetData(qeury);
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
