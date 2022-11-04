using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Final_Project__for_real_
{
    public partial class newacc : Form
    {
        public newacc()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=csit425finalproject.database.windows.net;Initial Catalog=CustomerInfo;Persist Security Info=True;User ID=customersAdmin;Password=csit425final$");
        public static string querry = "";

        private void lbl_welcome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                string fname, lname, streetAddress, city, stateAbbv, zipCode, ccNum, expDate, ccv, ccZipCode, ccFname, ccLname, email, password;
                fname = txt_fname.Text;
                lname = txt_lname.Text;
                streetAddress = txt_streetaddress.Text;
                city = txt_city.Text;
                stateAbbv = txt_stateabbv.Text;
                zipCode = txt_zipcode.Text;
                ccNum = txt_ccnumber.Text;
                expDate = txt_expdate.Text;
                ccv = txt_ccv.Text;
                ccZipCode = txt_cczipcode.Text;
                ccFname = txt_ccfname.Text;
                ccLname = txt_lname.Text;
                email = txt_email.Text;
                password = txt_password.Text;

                if (btn_monthly.Checked)
                {
                    querry = "INSERT INTO [dbo].[CustomersInfo] VALUES ('" + fname + "', '" + lname + "', '" + streetAddress + "', '" + city + "', '" + stateAbbv + "', '" + zipCode + "', '" + ccNum + "', '" + ccv + "', '" + ccFname + "', '" + ccLname + "', '" + ccZipCode + "', 1, 1, 0, null, '" + email + "', '" + password + "', 1)";
                }

                if (btn_yearly.Checked)
                {
                    querry = "INSERT INTO [dbo].[CustomersInfo] VALUES ('" + fname + "', '" + lname + "', '" + streetAddress + "', '" + city + "', '" + stateAbbv + "', '" + zipCode + "', '" + ccNum + "', '" + ccv + "', '" + ccFname + "', '" + ccLname + "', '" + ccZipCode + "', 1, 0, 1, null, '" + email + "', '" + password + "', 1)";
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("You have successfully created a new account!", "Success!", MessageBoxButtons.OK);

                this.Hide();
                login loginForm = new login();
                loginForm.Show();

            }

            catch
            {
                MessageBox.Show("You have either left a required field blank, or have inputted data wrong. Please try again.", "Error", MessageBoxButtons.OK);
            }

            finally
            {
                conn.Close();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginForm = new login();
            loginForm.Show(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_zipcode_Click(object sender, EventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_monthly_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_yearly_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
