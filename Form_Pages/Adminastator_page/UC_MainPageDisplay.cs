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
    public partial class UC_MainPageDisplay : UserControl
    {
        ConnectionFunction connectionFunction = new ConnectionFunction();
        string qeury;
        public UC_MainPageDisplay()
        {
            InitializeComponent();
        }

        private void UC_MainPageDisplay_Load(object sender, EventArgs e)
        {
            
        }
    }
}
