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
    public partial class UC_AddUser : UserControl
    {
        ConnectionFunction ConnectionFunction = new ConnectionFunction();
        string Query;
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_AddUser_Click(object sender, EventArgs e)
        {
            string role = _UserRoleDesign.Text;
            string Name = textBox_name.Text;
            string DateOfBirth = dateTimePicker_dob.Text;
            string UserName = textBox_UserName.Text;
            string Password = textBox_Password.Text;

            try
            {
                Query = "INSERT INTO UsersInformation (UserRole, FullName, DateOfBirth, UserName, UserPassword) Values ('"+role+"', '"+Name+"', '"+DateOfBirth+"', '"+UserName+"','"+Password+"')";
                ConnectionFunction.AddData(Query);  
                textBox_name.Clear();
                textBox_UserName.Clear();
                textBox_Password.Clear();
            }
            catch
            {
                MessageBox.Show("Username is Taken. Please chose Another User Name!");
                
            }
        }

        private void button_rest_Click(object sender, EventArgs e)
        {
            textBox_name.Clear() ;
            textBox_Password .Clear();
            textBox_UserName .Clear();
            _UserRoleDesign.Refresh();
            dateTimePicker_dob.Refresh();
            

        }
    }
}
