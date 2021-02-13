using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Consumer_Survey_System
{
    public partial class frmAdminMain : Form
    {
        public frmAdminMain()
        {
            InitializeComponent();
        }

        // Database Connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\source\repos\Consumer Survey System\Consumer Survey System\database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;

        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        private Form activeForm = null;

        public DataTable BindSource()
        {
            // Open connection
            con.Open();
            // Select all rows from the 'survey' table
            cmd = new SqlCommand("SELECT * FROM survey", con);
            da = new SqlDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds);
            dt = ds.Tables[0];
            // Close connection
            con.Close();
            return dt;
        }

        private void frmAdminMain_Load(object sender, EventArgs e)
        {
            /* Display data from 'survey' table
            dgvSurveys.DataSource = BindSource();
            // Change datagridview header text for columns
            dgvSurveys.Columns["id"].HeaderText = "No.";
            dgvSurveys.Columns["survey"].HeaderText = "Survey";*/
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(childForm);
            pnlContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnNewSurvey_Click(object sender, EventArgs e)
        {
            // Call the 'openChildForm' function and pass the form 'frmNewSurvey' as a parameter
            openChildForm(new frmNewSurvey());
            /*btnSurveys.BackColor = Color.FromArgb(0, 0, 40);
            btnSurveys.BackColor = Color.FromArgb(0, 0, 40);
            btnMyAccount.BackColor = Color.FromArgb(0, 0, 64);
            btnMyAccount.BackColor = Color.FromArgb(0, 0, 64);
            btnLogout.BackColor = Color.FromArgb(0, 0, 64);
            btnLogout.BackColor = Color.FromArgb(0, 0, 64);*/
        }

        private void btnDeleteSurvey_Click(object sender, EventArgs e)
        {

        }

        private void btnEditSurvey_Click(object sender, EventArgs e)
        {

        }

        private void btnSurveys_Click(object sender, EventArgs e)
        {

        }

    }
}
