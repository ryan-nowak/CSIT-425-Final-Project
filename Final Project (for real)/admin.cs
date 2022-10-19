using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project__for_real_
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerInfoDataSet1.CustomersInfo' table. You can move, or remove it, as needed.
            this.customersInfoTableAdapter.Fill(this.customerInfoDataSet1.CustomersInfo);

        }
    }
}
