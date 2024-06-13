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
            qeury = "Select * from Customer";
            DataSet dataset = connectionFunction.GetData(qeury);
            dataGridView_customer.DataSource = dataset.Tables[0];

            qeury = "Select * from OrderStatus";
            DataSet dataset2 = connectionFunction.GetData(qeury);
            dataGridView_orders.DataSource = dataset2.Tables[0];
        }
    }
}
