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

        public static int surveyID;
        public static string surveyName;

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

        private void frmAdminMain_Load(object sender, EventArgs e)
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
                btnDeleteSurvey.Enabled = true;
                btnResults.Enabled = true;
            }
            else
            {
                btnDeleteSurvey.Enabled = false;
                btnResults.Enabled = false;
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

        private void btnNewSurvey_Click(object sender, EventArgs e)
        {
            // Call the 'openChildForm' function and pass the form 'frmNewSurvey' as a parameter
            openChildForm(new frmNewSurvey());
            btnSurveys.BackColor = Color.FromArgb(0, 24, 74);
        }

        private void btnDeleteSurvey_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this survey?",
                               "Consumer Survey System",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Information) == DialogResult.OK)
            {
                int surveyID = Convert.ToInt32(dgvSurveys.CurrentRow.Cells["id"].Value);

                cmd = new SqlCommand("DELETE FROM result WHERE survey_id = '" + surveyID + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                cmd = new SqlCommand("DELETE FROM question WHERE survey_id = '" + surveyID + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                cmd = new SqlCommand("DELETE FROM survey WHERE id = '" + surveyID + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

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
                    btnDeleteSurvey.Enabled = true;
                    btnResults.Enabled = true;
                }
                else
                {
                    btnDeleteSurvey.Enabled = false;
                    btnResults.Enabled = false;
                }
            }
            else
            {
                return;
            }
        }

        private void btnEditSurvey_Click(object sender, EventArgs e)
        {
            surveyID = Convert.ToInt32(dgvSurveys.CurrentRow.Cells["id"].Value);
            openChildForm(new frmEditSurvey());
        }

        private void btnSurveys_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            btnSurveys.BackColor = Color.FromArgb(0, 13, 49);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
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
                btnDeleteSurvey.Enabled = true;
                btnResults.Enabled = true;
            }
            else
            {
                btnDeleteSurvey.Enabled = false;
                btnResults.Enabled = false;
            }
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            surveyID = Convert.ToInt32(dgvSurveys.CurrentRow.Cells["id"].Value);
            surveyName = Convert.ToString(dgvSurveys.CurrentRow.Cells["name"].Value);
            btnSurveys.BackColor = Color.FromArgb(0, 24, 74);
            openChildForm(new frmResult());
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

        private void frmAdminMain_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
