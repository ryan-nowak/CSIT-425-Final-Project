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
            if (login.currentMember == 1)
            {
                if (login.paid == 1)
                {
                    MessageBox.Show("You are already a " + login.membershipType.Trim() + " member and paid for.", "Error", MessageBoxButtons.OK);
                }

                else
                {
                    this.Hide();
                    payment_active paymentForm = new payment_active();
                    paymentForm.Show();
                }
            }

            else
            {
                this.Hide();
                payment_nonactive paymentForm = new payment_nonactive();
                paymentForm.Show();
            }
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
            lbl_fullname.Text = "Welcome, " + login.firstName.Trim() + " " + login.lastName.Trim() + "!";
        }

        private void lbl_fullname_Click(object sender, EventArgs e)
        {

        }
    }
}
