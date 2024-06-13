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

namespace PharmacyFormsManagmentApplication.Form_Pages.Adminastator_page
{
    public partial class UC_ViewUsersData : UserControl
    {
        ConnectionFunction confun = new ConnectionFunction();
        string query;
        string Current;
        public UC_ViewUsersData()
        {
            InitializeComponent();
        }
        public String ID
        {
            set { Current = value; }
        }
        private void UC_ViewUsersData_Load(object sender, EventArgs e)
        {
            query = "Select * from UsersInformation";
            DataSet ds = confun.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        string username;
        private void button_delete_Click(object sender, EventArgs e)
        {
            if (Current != username) 
            {
                query = "Delete from UsersInformation where username ='"+username+"'";
                confun.AddData(query);
                UC_ViewUsersData_Load(this, null);
            }
        }
    }
}
