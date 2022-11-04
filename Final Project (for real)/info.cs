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
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();
            label1.Text = login.firstName.Trim() + " " + login.lastName.Trim();
            lbl_fulladdress.Text = login.streetAddress.Trim() + ", " + login.city.Trim() + ", " + login.stateAbbv.Trim() + ", " + login.zipCode.Trim();
            if (login.paid == 1 || login.currentMember == 0)
            {
                lbl_membershiptype.Text = login.membershipType.Trim();
            }
            else
            {
                lbl_membershiptype.Text = login.membershipType.Trim() + " (have not paid yet)";
            }
        }

        private void info_Name_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            main mainForm = new main(); 
            mainForm.Show();
        }

        private void lbl_MemType_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_fulladdress_Click(object sender, EventArgs e)
        {

        }

        private void lbl_membershiptype_Click(object sender, EventArgs e)
        {

        }

        private void info_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Address_Click(object sender, EventArgs e)
        {

        }
    }
}
