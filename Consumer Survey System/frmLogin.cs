using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Consumer_Survey_System
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        // Database Connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\source\repos\Consumer Survey System\Consumer Survey System\database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;

        int count, attempt;

        void disable()
        {
            if (attempt == 3)
            {
                MessageBox.Show("You have reached the maximum number of attempts (3). Please try again after 60 seconds.", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                attempt = 0;
                count = 60;

                tmrLogin.Enabled = true;
                btnLogin.Enabled = false;
                txtEmail.Enabled = false;
                txtPassword.Enabled = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /* VALIDATE FOR EMPTY FIELDS */

            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                // Display error message if user leaves the email text field empty
                MessageBox.Show("Please enter your email address", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the email text field so that the user can type the input
                txtEmail.Focus();
                // Terminate the event handler
                return;
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                // Display error message if user leaves the password text field empty
                MessageBox.Show("Please enter your password", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the password text field so that the user can type the input
                txtPassword.Focus();
                // Terminate the event handler
                return;
            }

            /* VALIDATE FOR INVALID INPUTS */

            else if (!Regex.Match(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
            {
                // Display an error message if the user enters an invalid last name
                MessageBox.Show("The email address you entered is invalid. Please make sure to include an @ symbol.", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the last name text field so that the user can retype the input
                txtEmail.Focus();
                // Terminate the event handler
                return;
            }
            else
            {
                // Open database connection
                con.Open();
                // Select all 'users' with an email address and password that matches the user inputs
                cmd = new SqlCommand("SELECT * FROM users WHERE email_address='" + txtEmail.Text + "' and password='" + txtPassword.Text + "'", con);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int i = dt.Rows.Count;
                // Check if there is a matching record in the 'users' table
                if (i == 1)
                {
                    // Display a success message
                    MessageBox.Show("Login successful. Welcome!", "Consumer Survey System", MessageBoxButtons.OK);
                    // If the user is a consumer, open the consumer form
                    if (dt.Rows[0]["user_type"].ToString() == "consumer")
                    {
                        // Open consumer form
                        frmConsumerMain fm = new frmConsumerMain();
                        fm.Show();
                        // Close database connection
                        con.Close();
                        // Hide login form
                        this.Hide();
                    }
                    // If the user is an administrator, open the administrator form
                    else if (dt.Rows[0]["user_type"].ToString() == "admin")
                    {
                        // Open administrator form
                        frmAdminMain fm = new frmAdminMain();
                        // Close database connection
                        con.Close();
                        fm.Show();
                        // Hide login form
                        this.Hide();
                    }
                }
                else
                {
                    // If the records search is negative, display an error message
                    MessageBox.Show("The email address or password you entered is incorrect. Please try again.", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Close database connection
                    con.Close();
                    // Clear the email address field
                    txtEmail.Clear();
                    // Clear the password field
                    txtPassword.Clear();
                    // Increment the number of login attempts by 1
                    attempt = attempt + 1;
                    // Call the 'disable' function to check if the number of failed attempts has been succeeded
                    disable();
                    // Terminate the event handler and return to login form
                    return;
                }
                // Close database connection
                con.Close();
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit?",
                   "Consumer Survey System",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information) == DialogResult.OK)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void pbxViewPassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            pbxViewPassword.Visible = false;
            pbxHidePassword.Visible = true;
        }

        private void pbxHidePassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '•';
            pbxHidePassword.Visible = false;
            pbxViewPassword.Visible = true;
        }

    }
}
