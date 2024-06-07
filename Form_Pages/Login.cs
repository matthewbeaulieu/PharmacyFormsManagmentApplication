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

namespace PharmacyFormsManagmentApplication
{
    public partial class Login : Form
    {
        ConnectionFunction confun = new ConnectionFunction();
        string query;
        public Login()
        {
            InitializeComponent();
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            query = "Select * from UsersInformation";
            DataSet dataSet = confun.GetData(query);
            if (dataSet.Tables[0].Rows.Count==0)
            {
                if(text_UserName.Text=="root" && text_Password.Text == "root")
                {
                    AdminDashBord admb = new AdminDashBord();
                    admb.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "Select * from UsersInformation where UserName = '" + text_UserName.Text + "' and UserPassword = '" + text_Password.Text + "'";
                DataSet DS =confun.GetData(query);
                if (DS.Tables[0].Rows.Count!=0)
                {
                    string role = DS.Tables[0].Rows[0][1].ToString();
                    if (role == "ADMIN")
                    {
                        AdminDashBord admindashbord = new AdminDashBord();
                        admindashbord.Show();
                        this.Hide();
                    }
                    else if(role == "Pharmacist")
                    {
                        PharmacistDashBord pharmacistDashBord = new PharmacistDashBord();
                        pharmacistDashBord.Show();
                        this.Hide();
                    }
                }
                else
                {
                    throw new Exception();
                }
            }

        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
