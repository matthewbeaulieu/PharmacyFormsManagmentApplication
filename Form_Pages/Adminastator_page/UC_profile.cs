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
    public partial class UC_profile : UserControl
    {
        ConnectionFunction connectionFunction = new ConnectionFunction();
        string query;
        public UC_profile()
        {
            InitializeComponent();
        }
        public string ID
        {
            set { label_role.Text = value; }
        }
        private void UC_profile_Load(object sender, EventArgs e)
        {
            query = "Select * from UsersInformation where UserName = '"+label_role.Text+"'";
            DataSet ds = connectionFunction.GetData(query);
            label_role.Text = ds.Tables[0].Rows[0][1].ToString();
            label_name.Text = ds.Tables[0].Rows[0][2].ToString();
            label_DoB.Text = ds.Tables[0].Rows[0][3].ToString();
            label_Password.Text = ds.Tables[0].Rows[0][5].ToString();

        }

        private void label_name_Click(object sender, EventArgs e)
        {

        }

        private void button_pdate_Click(object sender, EventArgs e)
        {
            string password = textBox_password.Text;
            

            query = "update UsersInformation set UserPassword ='"+password+"'";

        }

        private void label_role_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
