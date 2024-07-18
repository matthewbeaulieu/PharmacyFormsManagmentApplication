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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacyFormsManagmentApplication.Form_Pages.Adminastator_page
{
    public partial class UC_ViewUsersData : UserControl
    {
        ConnectionFunction confun = new ConnectionFunction();
        String query;
        String currentUser;
        public UC_ViewUsersData()
        {
            InitializeComponent();
        }
        public String ID
        {
            set { currentUser = value; }
        }
        private void UC_ViewUsersData_Load(object sender, EventArgs e)
        {
            refresh();
            timer1.Start();
        }
        public void refresh()
        {
            query = "Select * from UsersInformation";
            DataSet ds = confun.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        string userName;
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
            catch
            {

            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            
                if (currentUser != userName)
                {
                    query = "delete from UsersInformation where UserName = '" + userName + "'";
                    confun.AddData(query);
                    UC_ViewUsersData_Load(this, null);
                }
                else
                {
                    MessageBox.Show("You are Trying to delete \n Your Own Profile.");

                }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refresh();
            timer1.Start();
        }
    }
}
