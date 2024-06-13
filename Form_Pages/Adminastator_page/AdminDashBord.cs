using PharmacyFormsManagmentApplication.Form_Pages.Adminastator_page;
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
        string user = "";
        
        public AdminDashBord()
        {
            InitializeComponent();
            
        }
        public string ID
        {
            get { return user.ToString(); }
        }
        public AdminDashBord(string userName)
        {
            InitializeComponent();
            label_username.Text = userName;
            user = userName;
            uC_ViewUsersData1.ID = ID;
            uC_profile1.ID = ID;
            
        }
        private void AdminDashBord_Load(object sender, EventArgs e)
        {
            uC_MainPageDisplay1.Visible = true;
            uC_AddUser1.Visible = false;
            uC_profile1.Visible = false;
            uC_ViewUsersData1.Visible = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button_admin_Dashbord_Click(object sender, EventArgs e)
        {
            uC_MainPageDisplay1.Visible = true;
            uC_AddUser1.Visible = false;
            uC_profile1.Visible = false;
            uC_ViewUsersData1.Visible = false;
        }

        private void button_admin_AddUser_Click(object sender, EventArgs e)
        {
            uC_MainPageDisplay1.Visible = false;
            uC_profile1.Visible = false;
            uC_ViewUsersData1.Visible = false;
            uC_AddUser1.Visible = true;
            
        }

        private void button_admin_viewusers_Click(object sender, EventArgs e)
        {
            uC_ViewUsersData1.Visible = true;
            uC_MainPageDisplay1.Visible = false;
            uC_profile1.Visible = false;
            uC_AddUser1.Visible = false;
            
        }

        private void button_admin_profiles_Click(object sender, EventArgs e)
        {
            uC_profile1.Visible = true;
            uC_MainPageDisplay1.Visible = false;
            uC_AddUser1.Visible = false;
            uC_ViewUsersData1.Visible=false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
