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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=csit425finalproject.database.windows.net;Initial Catalog=CustomerInfo;Persist Security Info=True;User ID=customersAdmin;Password=csit425final$");

        private void admin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = customerInfoDataSet.CustomersInfo;
            this.customersInfoTableAdapter.Fill(this.customerInfoDataSet.CustomersInfo);
        }

        private void btn_monthlycharge_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String querry = "UPDATE [dbo].[CustomersInfo] SET Paid = 1 WHERE MonthlyMember = 1";
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Monthly users who haven't paid have now been charged.", "Success!", MessageBoxButtons.OK);

            }

            catch
            {
                MessageBox.Show("Error.");
            }

            finally
            {
                conn.Close();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = customerInfoDataSet.CustomersInfo;
            this.customersInfoTableAdapter.Fill(this.customerInfoDataSet.CustomersInfo);
        }

        private void btn_yearlycharge_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String querry = "UPDATE [dbo].[CustomersInfo] SET Paid = 1 WHERE YearlyMember = 1";
                SqlCommand cmd = new SqlCommand(querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Yearly users who haven't paid have now been charged.", "Success!", MessageBoxButtons.OK);

            }

            catch
            {
                MessageBox.Show("Error.");
            }

            finally
            {
                conn.Close();
            }
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            conn.Open();
            String querry = "SELECT COUNT(ConsecutiveMonthsLate) FROM [dbo].[CustomersInfo] WHERE ConsecutiveMonthsLate > 2";
            SqlCommand cmd = new SqlCommand(querry, conn);
            int result = (int)cmd.ExecuteScalar();
            conn.Close();
            MessageBox.Show("Email was sent to " + result + " gym users about their consecutive late payments, with a reminder of the $20 late fee charge.", "Success!", MessageBoxButtons.OK);
        }

        private void btn_filterpaid_Click(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM [dbo].[CustomersInfo] WHERE Paid = 1 AND CurrentMember = 1";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querry, conn);
            SqlCommandBuilder cmd = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            MessageBox.Show("Now showing current members who have paid their dues.", "Success!", MessageBoxButtons.OK);
        }

        private void btn_filterunpaid_Click(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM [dbo].[CustomersInfo] WHERE Paid = 0 AND CurrentMember = 1";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querry, conn);
            SqlCommandBuilder cmd = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            MessageBox.Show("Now showing current members who have not paid their dues.", "Success!", MessageBoxButtons.OK);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
