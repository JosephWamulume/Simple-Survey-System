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
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /* VALIDATE FOR EMPTY FIELDS */

            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                // Display error message if user leaves the username text field empty
                MessageBox.Show("Please enter your username address", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Set focus back the username text field so that the user can type the input
                txtUsername.Focus();
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
            else
            {
                // Open database connection
                con.Open();
                // Select all 'users' with an username and password that matches the user inputs
                cmd = new SqlCommand("SELECT * FROM users WHERE username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", con);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int i = dt.Rows.Count;
                // Check if there is a matching record in the 'users' table
                if (i == 1)
                {
                    // Display a success message
                    MessageBox.Show("Login successful. Welcome!", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("The username or password you entered is incorrect. Please try again.", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Close database connection
                    con.Close();
                    // Clear the username address field
                    txtUsername.Clear();
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

        private void tmrLogin_Tick(object sender, EventArgs e)
        {
            if (count == 0)
            {
                tmrLogin.Enabled = false;
                btnLogin.Enabled = true;
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
                btnLogin.Text = "Login";
                txtUsername.Focus();
            }
            else
            {
                btnLogin.Text = "Log in " + count;
                count = count - 1;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            attempt = 0;
        }

        private void linklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerform = new frmRegister();
            registerform.Show();
            this.Hide();
        }

        private void pbxHidePassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '•';
            pbxHidePassword.Visible = false;
            pbxViewPassword.Visible = true;
        }

    }
}
