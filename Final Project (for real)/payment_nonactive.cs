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
    public partial class payment_nonactive : Form
    {
        public payment_nonactive()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=csit425finalproject.database.windows.net;Initial Catalog=CustomerInfo;Persist Security Info=True;User ID=customersAdmin;Password=csit425final$");
        public static string querry = "";

        private void btn_monthly_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_yearly_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_monthly.Checked)
                {
                    querry = "UPDATE [dbo].[CustomersInfo] SET Paid = 1, CurrentMember = 1, MonthlyMember = 1 WHERE FirstName = '" + login.firstName.Trim() + "' AND LastName = '" + login.lastName.Trim() + "'";
                }
                else if (btn_yearly.Checked)
                {
                    querry = "UPDATE [dbo].[CustomersInfo] SET Paid = 1, CurrentMember = 1, YearlyMember = 1 WHERE FirstName = '" + login.firstName.Trim() + "' AND LastName = '" + login.lastName.Trim() + "'";
                }
                else
                {
                    MessageBox.Show("Payment type wasn't selected. Please select one.", "Error", MessageBoxButtons.OK);
                }
                conn.Open();
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
    }
}
