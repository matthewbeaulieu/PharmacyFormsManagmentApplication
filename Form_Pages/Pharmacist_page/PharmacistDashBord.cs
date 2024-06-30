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
    public partial class PharmacistDashBord : Form
    {
        string user = "";
        
        public PharmacistDashBord()
        {
            InitializeComponent();
        }
        public string ID
        {
            get { return user.ToString(); }
        }
        public PharmacistDashBord(string username)
        {
            InitializeComponent();
            user = username;
        }

        private void PharmacistDashBord_Load(object sender, EventArgs e)
        {
            uC_Display1.Visible = true;
            uC_Customer1.Visible = false;
            uC_Orders1.Visible = false;
            uC_Medications1.Visible = false;
        }

        
        private void button_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOut_button_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            
        }

        private void DashBord_button_Click(object sender, EventArgs e)
        {
            uC_Display1.Visible = true;
            uC_Customer1.Visible = false;
            uC_Orders1.Visible = false;
            uC_Medications1.Visible = false;
        }

        private void CustomerInfo_button_Click(object sender, EventArgs e)
        {
            uC_Customer1.Visible = true;
            uC_Orders1.Visible = false;
            uC_Display1.Visible = false;
            uC_Medications1.Visible = false;
        }

        private void Orders_Click(object sender, EventArgs e)
        {
            uC_Orders1.Visible = true;
            uC_Display1.Visible = false;
            uC_Customer1.Visible = false;
            uC_Medications1.Visible = false;
        }

        private void button_med_Click(object sender, EventArgs e)
        {
            uC_Customer1.Visible = false;
            uC_Orders1.Visible = false;
            uC_Display1.Visible = false;
            uC_Medications1.Visible = true;
        }
    }
}
