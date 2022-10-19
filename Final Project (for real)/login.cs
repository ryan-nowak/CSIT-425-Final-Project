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
using Microsoft.Identity.Client;

namespace Final_Project__for_real_
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=csit425finalproject.database.windows.net;Initial Catalog=CustomerInfo;Persist Security Info=True;User ID=customersAdmin;Password=csit425final$");

        public static string firstName = "";
        public static string lastName = "";

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            String fname, lname;

            fname = txt_fname.Text;
            lname = txt_lname.Text;

            //for other form
            firstName = txt_fname.Text;
            lastName = txt_lname.Text;

            if (fname == "admin")
            {
                this.Hide();
                admin adminForm = new admin();
                adminForm.Show();
            }

            else
            {
                try
                {
                    conn.Open();
                    String querry = "SELECT * FROM CustomersInfo WHERE FirstName = '" + txt_fname.Text + "' AND LastName = '" + txt_lname.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        fname = txt_fname.Text;
                        lname = txt_lname.Text;

                        this.Hide();
                        main mainForm = new main();
                        mainForm.Show();
                    }

                    else
                    {
                        MessageBox.Show("Invalid login details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_fname.Clear();
                        txt_lname.Clear();

                        txt_fname.Focus();
                    }
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
            
        }

        private void btn_newacc_Click(object sender, EventArgs e)
        {
            this.Hide();
            newacc newAccForm = new newacc();
            newAccForm.Show();
        }

        private void lbl_fname_Click(object sender, EventArgs e)
        {

        }

        private void txt_fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_lname_Click(object sender, EventArgs e)
        {

        }
    }
}
