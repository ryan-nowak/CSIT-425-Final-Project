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
    public partial class payment_active : Form
    {
        public payment_active()
        {
            InitializeComponent();

            if (login.membershipType == "Monthly")
            {
                lbl_paymentinfo.Text = "You are a monthly user. The amount due is $50 for the next month. Press the submit button to submit your payment using the credit card information on file.";
            }

            else
            {
                lbl_paymentinfo.Text = "You are a yearly user. The amount due is $500 for the next year. Press the submit button to submit your payment using the credit card information on file.";
            }
        }

        SqlConnection conn = new SqlConnection(@"Data Source=csit425finalproject.database.windows.net;Initial Catalog=CustomerInfo;Persist Security Info=True;User ID=customersAdmin;Password=csit425final$");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_expdate_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String querry = "UPDATE [dbo].[CustomersInfo] SET Paid = 1 WHERE FirstName = '" + login.firstName.Trim() + "' AND LastName = '" + login.lastName.Trim() + "'";
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Payment submitted! Please login again to update the changes.", "Successful!", MessageBoxButtons.OK);
                this.Close();
                login loginForm = new login();
                loginForm.Show();
            }

            catch
            {
                MessageBox.Show("There was an error with the payment information you have on file.", "Error", MessageBoxButtons.OK);
            }

            finally
            {
                conn.Close();  
            }
        }

        private void btn_Backtomain_Click(object sender, EventArgs e)
        {
            this.Hide();
            main mainForm = new main();
            mainForm.Show();
        }

        private void lbl_paymentinfo_Click(object sender, EventArgs e)
        {

        }
    }
}
