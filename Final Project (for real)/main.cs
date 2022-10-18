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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            this.Hide();
            payment paymentForm = new payment();
            paymentForm.Show(); 
        }

        private void btn_information_Click(object sender, EventArgs e)
        {
            this.Hide();
            info infoForm = new info();
            infoForm.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void main_Load(object sender, EventArgs e)
        {
            lbl_fullname.Text = "Welcome, " + login.firstName + " " + login.lastName + "!";
        }
    }
}
