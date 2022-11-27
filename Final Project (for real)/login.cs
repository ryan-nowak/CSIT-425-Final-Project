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
        public static string streetAddress = "";
        public static string city = "";
        public static string stateAbbv = "";
        public static string zipCode = "";
        public static int currentMember = 0;
        public static int paid = 0;
        public static string membershipType = "";
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_login; 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            String email, password;

            email = txt_fname.Text;
            password = txt_lname.Text;

            if (email == "admin@aerfitness.com" && password == "aeradmin")
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
                    String querry = "SELECT * FROM CustomersInfo WHERE Email = '" + txt_fname.Text + "' AND Password = '" + txt_lname.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        email = txt_fname.Text;
                        password = txt_lname.Text;

                        firstName = dtable.Rows[0]["FirstName"].ToString();
                        lastName = dtable.Rows[0]["LastName"].ToString();
                        streetAddress = dtable.Rows[0]["StreetAddress"].ToString();
                        city = dtable.Rows[0]["City"].ToString();
                        stateAbbv = dtable.Rows[0]["StateAbbv"].ToString();
                        zipCode = dtable.Rows[0]["ZipCode"].ToString();

                        //code to determine whether a user is a current member or not, and their membership type
                        if (dtable.Rows[0]["CurrentMember"].ToString() == "True")
                        {
                            currentMember = 1;
                            if (dtable.Rows[0]["Paid"].ToString() == "True")
                            {
                                paid = 1;
                            }


                            if (dtable.Rows[0]["MonthlyMember"].ToString() == "True")
                            {
                                membershipType = "Monthly";
                            }

                            else if (dtable.Rows[0]["YearlyMember"].ToString() == "True")
                            {
                                membershipType = "Yearly";
                            }
                        }

                        else
                        {
                            currentMember = 0;
                            paid = 0;
                            membershipType = "Not an active member.";
                        }

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
            txt_lname.PasswordChar = '*';
        }

        private void lbl_lname_Click(object sender, EventArgs e)
        {

        }

        private void txt_lname_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
