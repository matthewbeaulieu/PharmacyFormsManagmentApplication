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
    public partial class AdminDashBord : Form
    {
        public AdminDashBord()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button_admin_Dashbord_Click(object sender, EventArgs e)
        {
            AdminDashBord adminDashBord = new AdminDashBord();
            adminDashBord.Show();
            this.Hide();
        }
    }
}
