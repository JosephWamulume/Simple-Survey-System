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

namespace Consumer_Survey_System
{
    public partial class frmConsumerMain : Form
    {
        public frmConsumerMain()
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

        public static int surveyID;

        public DataTable BindSource()
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM survey", con);
            da = new SqlDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds);
            dt = ds.Tables[0];
            con.Close();
            return dt;
        }

        private void frmConsumerMain_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM survey", con);
            da = new SqlDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds);
            dt = ds.Tables[0];
            con.Close();
            if (dt.Rows.Count > 0)
            {
                dgvSurveys.DataSource = dt;
                dgvSurveys.Columns["id"].HeaderText = "No.";
                dgvSurveys.Columns["name"].HeaderText = "Survey";
                btnAnswerSurvey.Enabled = true;
            }
            else
            {
                btnAnswerSurvey.Enabled = false;
                MessageBox.Show("There are currently no surveys available. Please check again later.", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void btnAnswerSurvey_Click(object sender, EventArgs e)
        {
            surveyID = Convert.ToInt32(dgvSurveys.CurrentRow.Cells["id"].Value);
            openChildForm(new frmSurvey());
        }

        private void frmConsumerMain_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to logout?",
                               "Consumer Survey System",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
            {
                frmLogin fl = new frmLogin();
                fl.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void btnSurveys_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            btnSurveys.BackColor = Color.FromArgb(0, 13, 49);
        }
    }
}
