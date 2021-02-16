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
    public partial class frmNewSurvey : Form
    {
        public frmNewSurvey()
        {
            InitializeComponent();
        }

        // Database Connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\source\repos\Consumer Survey System\Consumer Survey System\database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;

        private void frmNewSurvey_Load(object sender, EventArgs e)
        {
            cbxFormat1.SelectedIndex = 0;
            cbxFormat2.SelectedIndex = 0;
            cbxFormat3.SelectedIndex = 0;
            cbxFormat4.SelectedIndex = 0;
            cbxFormat5.SelectedIndex = 0;
            cbxFormat6.SelectedIndex = 0;
            cbxFormat7.SelectedIndex = 0;
            cbxFormat8.SelectedIndex = 0;
            cbxFormat9.SelectedIndex = 0;
            cbxFormat10.SelectedIndex = 0;
        }

        private void btnAddQuestion2_Click(object sender, EventArgs e)
        {
            btnAddQuestion2.Visible = false;
            gbxQuestion2.Visible = true;
            btnAddQuestion3.Visible = true;
            btnRemoveQuestion2.Visible = true;
            txtDescription2.Focus();
        }

        private void btnAddQuestion3_Click(object sender, EventArgs e)
        {
            btnAddQuestion3.Visible = false;
            btnRemoveQuestion2.Visible = false;
            gbxQuestion3.Visible = true;
            btnAddQuestion4.Visible = true;
            btnRemoveQuestion3.Visible = true;
            txtDescription3.Focus();
        }

        private void btnRemoveQuestion2_Click(object sender, EventArgs e)
        {
            btnAddQuestion2.Visible = true;
            gbxQuestion2.Visible = false;
            btnAddQuestion3.Visible = false;
            btnRemoveQuestion2.Visible = false;
            txtDescription1.Focus();
        }

        private void btnAddQuestion4_Click(object sender, EventArgs e)
        {
            btnAddQuestion4.Visible = false;
            btnRemoveQuestion3.Visible = false;
            gbxQuestion4.Visible = true;
            btnAddQuestion5.Visible = true;
            btnRemoveQuestion4.Visible = true;
            txtDescription4.Focus();
        }

        private void btnRemoveQuestion3_Click(object sender, EventArgs e)
        {
            btnAddQuestion3.Visible = true;
            gbxQuestion3.Visible = false;
            btnAddQuestion4.Visible = false;
            btnRemoveQuestion3.Visible = false;
            btnRemoveQuestion2.Visible = true;
            txtDescription2.Focus();
        }

        private void btnAddQuestion5_Click(object sender, EventArgs e)
        {
            btnAddQuestion5.Visible = false;
            btnRemoveQuestion4.Visible = false;
            gbxQuestion5.Visible = true;
            btnAddQuestion6.Visible = true;
            btnRemoveQuestion5.Visible = true;
            txtDescription5.Focus();
        }

        private void btnRemoveQuestion4_Click(object sender, EventArgs e)
        {
            btnAddQuestion4.Visible = true;
            gbxQuestion4.Visible = false;
            btnAddQuestion5.Visible = false;
            btnRemoveQuestion4.Visible = false;
            btnRemoveQuestion3.Visible = true;
            txtDescription3.Focus();
        }

        private void btnAddQuestion6_Click(object sender, EventArgs e)
        {
            btnAddQuestion6.Visible = false;
            btnRemoveQuestion5.Visible = false;
            gbxQuestion6.Visible = true;
            btnAddQuestion7.Visible = true;
            btnRemoveQuestion6.Visible = true;
            txtDescription6.Focus();
        }

        private void btnRemoveQuestion5_Click(object sender, EventArgs e)
        {
            btnAddQuestion5.Visible = true;
            gbxQuestion5.Visible = false;
            btnAddQuestion6.Visible = false;
            btnRemoveQuestion5.Visible = false;
            btnRemoveQuestion4.Visible = true;
            txtDescription4.Focus();
        }

        private void btnAddQuestion7_Click(object sender, EventArgs e)
        {
            btnAddQuestion7.Visible = false;
            btnRemoveQuestion6.Visible = false;
            gbxQuestion7.Visible = true;
            btnAddQuestion8.Visible = true;
            btnRemoveQuestion7.Visible = true;
            txtDescription7.Focus();
        }

        private void btnRemoveQuestion6_Click(object sender, EventArgs e)
        {
            btnAddQuestion6.Visible = true;
            gbxQuestion6.Visible = false;
            btnAddQuestion7.Visible = false;
            btnRemoveQuestion6.Visible = false;
            btnRemoveQuestion5.Visible = true;
            txtDescription5.Focus();
        }

        private void btnAddQuestion8_Click(object sender, EventArgs e)
        {
            btnAddQuestion8.Visible = false;
            btnRemoveQuestion7.Visible = false;
            gbxQuestion8.Visible = true;
            btnAddQuestion9.Visible = true;
            btnRemoveQuestion8.Visible = true;
            txtDescription8.Focus();
        }

        private void btnRemoveQuestion7_Click(object sender, EventArgs e)
        {
            btnAddQuestion7.Visible = true;
            gbxQuestion7.Visible = false;
            btnAddQuestion8.Visible = false;
            btnRemoveQuestion7.Visible = false;
            btnRemoveQuestion6.Visible = true;
            txtDescription6.Focus();
        }
   

        private void btnAddQuestion9_Click(object sender, EventArgs e)
        {
            btnAddQuestion9.Visible = false;
            btnRemoveQuestion8.Visible = false;
            gbxQuestion9.Visible = true;
            btnAddQuestion10.Visible = true;
            btnRemoveQuestion9.Visible = true;
            txtDescription9.Focus();
        }

        private void btnRemoveQuestion8_Click(object sender, EventArgs e)
        {
            btnAddQuestion8.Visible = true;
            gbxQuestion8.Visible = false;
            btnAddQuestion9.Visible = false;
            btnRemoveQuestion8.Visible = false;
            btnRemoveQuestion7.Visible = true;
            txtDescription7.Focus();
        }

        private void btnAddQuestion10_Click(object sender, EventArgs e)
        {
            btnAddQuestion10.Visible = false;
            btnRemoveQuestion9.Visible = false;
            gbxQuestion10.Visible = true;
            btnRemoveQuestion10.Visible = true;
            txtDescription10.Focus();
        }

        private void btnRemoveQuestion9_Click(object sender, EventArgs e)
        {
            btnAddQuestion9.Visible = true;
            gbxQuestion9.Visible = false;
            btnAddQuestion10.Visible = false;
            btnRemoveQuestion9.Visible = false;
            btnRemoveQuestion8.Visible = true;
            txtDescription8.Focus();
        }

        private void btnRemoveQuestion10_Click(object sender, EventArgs e)
        {
            btnAddQuestion10.Visible = true;
            btnRemoveQuestion9.Visible = true;
            gbxQuestion10.Visible = false;
            btnRemoveQuestion10.Visible = false;
            txtDescription9.Focus();
        }

        private void btnCreateSurvey_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSurveyName.Text))
            {
                MessageBox.Show("Please enter a survey name", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurveyName.Focus();
                return;
            }
            // Question 1
            else if (String.IsNullOrEmpty(txtDescription1.Text))
            {
                MessageBox.Show("Please enter a question description for Question 1", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription1.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(cbxFormat1.Text))
            {
                MessageBox.Show("Please select a question format for Question 1", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxFormat1.Focus();
                return;
            }
            // Question 2
            else if (gbxQuestion2.Visible == true & String.IsNullOrEmpty(txtDescription2.Text))
            {
                MessageBox.Show("Please enter a question description for Question 2", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription2.Focus();
                return;
            }
            else if (gbxQuestion2.Visible == true & String.IsNullOrEmpty(cbxFormat2.Text))
            {
                MessageBox.Show("Please select a question format for Question 2", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxFormat2.Focus();
                return;
            }
            // Question 3
            else if (gbxQuestion3.Visible == true & String.IsNullOrEmpty(txtDescription3.Text))
            {
                MessageBox.Show("Please enter a question description for Question 3", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription3.Focus();
                return;
            }
            else if (gbxQuestion3.Visible == true & String.IsNullOrEmpty(cbxFormat3.Text))
            {
                MessageBox.Show("Please select a question format for Question 3", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxFormat3.Focus();
                return;
            }
            // Question 4
            else if (gbxQuestion4.Visible == true & String.IsNullOrEmpty(txtDescription4.Text))
            {
                MessageBox.Show("Please enter a question description for Question 4", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription4.Focus();
                return;
            }
            else if (gbxQuestion4.Visible == true & String.IsNullOrEmpty(cbxFormat4.Text))
            {
                MessageBox.Show("Please select a question format for Question 4", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxFormat4.Focus();
                return;
            }
            // Question 5
            else if (gbxQuestion5.Visible == true & String.IsNullOrEmpty(txtDescription5.Text))
            {
                MessageBox.Show("Please enter a question description for Question 5", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription5.Focus();
                return;
            }
            else if (gbxQuestion5.Visible == true & String.IsNullOrEmpty(cbxFormat5.Text))
            {
                MessageBox.Show("Please select a question format for Question 5", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxFormat5.Focus();
                return;
            }
            // Question 6
            else if (gbxQuestion6.Visible == true & String.IsNullOrEmpty(txtDescription6.Text))
            {
                MessageBox.Show("Please enter a question description for Question 6", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription6.Focus();
                return;
            }
            else if (gbxQuestion6.Visible == true & String.IsNullOrEmpty(cbxFormat6.Text))
            {
                MessageBox.Show("Please select a question format for Question 6", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxFormat6.Focus();
                return;
            }
            // Question 7
            else if (gbxQuestion7.Visible == true & String.IsNullOrEmpty(txtDescription7.Text))
            {
                MessageBox.Show("Please enter a question description for Question 7", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription7.Focus();
                return;
            }
            else if (gbxQuestion7.Visible == true & String.IsNullOrEmpty(cbxFormat7.Text))
            {
                MessageBox.Show("Please select a question format for Question 7", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxFormat7.Focus();
                return;
            }
            // Question 8
            else if (gbxQuestion8.Visible == true & String.IsNullOrEmpty(txtDescription8.Text))
            {
                MessageBox.Show("Please enter a question description for Question 8", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription8.Focus();
                return;
            }
            else if (gbxQuestion8.Visible == true & String.IsNullOrEmpty(cbxFormat8.Text))
            {
                MessageBox.Show("Please select a question format for Question 8", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxFormat8.Focus();
                return;
            }
            // Question 9
            else if (gbxQuestion9.Visible == true & String.IsNullOrEmpty(txtDescription9.Text))
            {
                MessageBox.Show("Please enter a question description for Question 9", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription9.Focus();
                return;
            }
            else if (gbxQuestion9.Visible == true & String.IsNullOrEmpty(cbxFormat9.Text))
            {
                MessageBox.Show("Please select a question format for Question 9", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxFormat9.Focus();
                return;
            }
            // Question 10
            else if (gbxQuestion10.Visible == true & String.IsNullOrEmpty(txtDescription10.Text))
            {
                MessageBox.Show("Please enter a question description for Question 10", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription10.Focus();
                return;
            }
            else if (gbxQuestion10.Visible == true & String.IsNullOrEmpty(cbxFormat10.Text))
            {
                MessageBox.Show("Please select a question format for Question 10", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxFormat10.Focus();
                return;
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM survey WHERE name='" + txtSurveyName.Text + "'", con);
                da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                con.Close();
                if (i > 0)
                {
                    MessageBox.Show("A survey with this name already exists. Please choose a different name.", "Consumer Survey System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSurveyName.Focus();
                    return;
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO survey (name) VALUES ('" + txtSurveyName.Text + "'); SELECT SCOPE_IDENTITY()", con);
                    con.Open();
                    int surveyID = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd = new SqlCommand("INSERT INTO question (survey_id, description, question_format, question_number) VALUES ('" + surveyID.ToString() + "', '" + txtDescription1.Text + "', '" + cbxFormat1.Text + "', '" + 1 +"')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    if (gbxQuestion2.Visible == true)
                    {
                        cmd = new SqlCommand("INSERT INTO question (survey_id, description, question_format, question_number) VALUES ('" + surveyID.ToString() + "', '" + txtDescription2.Text + "', '" +cbxFormat2.Text+ "', '" + 2 + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (gbxQuestion3.Visible == true)
                    {
                        cmd = new SqlCommand("INSERT INTO question (survey_id, description, question_format, question_number) VALUES ('" + surveyID.ToString() + "', '" + txtDescription3.Text + "', '" + cbxFormat3.Text + "', '" + 3 + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (gbxQuestion4.Visible == true)
                    {
                        cmd = new SqlCommand("INSERT INTO question (survey_id, description, question_format, question_number) VALUES ('" + surveyID.ToString() + "', '" + txtDescription4.Text + "', '" + cbxFormat4.Text + "', '" + 4 + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (gbxQuestion5.Visible == true)
                    {
                        cmd = new SqlCommand("INSERT INTO question (survey_id, description, question_format, question_number) VALUES ('" + surveyID.ToString() + "', '" + txtDescription5.Text + "', '" + cbxFormat5.Text + "', '" + 5 + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (gbxQuestion6.Visible == true)
                    {
                        cmd = new SqlCommand("INSERT INTO question (survey_id, description, question_format, question_number) VALUES ('" + surveyID.ToString() + "', '" + txtDescription6.Text + "', '" + cbxFormat6.Text + "', '" + 6 + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (gbxQuestion7.Visible == true)
                    {
                        cmd = new SqlCommand("INSERT INTO question (survey_id, description, question_format, question_number) VALUES ('" + surveyID.ToString() + "', '" + txtDescription7.Text + "', '" + cbxFormat7.Text + "', '" + 7 + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (gbxQuestion8.Visible == true)
                    {
                        cmd = new SqlCommand("INSERT INTO question (survey_id, description, question_format, question_number) VALUES ('" + surveyID.ToString() + "', '" + txtDescription8.Text + "', '" + cbxFormat8.Text + "', '" + 8 + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (gbxQuestion9.Visible == true)
                    {
                        cmd = new SqlCommand("INSERT INTO question (survey_id, description, question_format, question_number) VALUES ('" + surveyID.ToString() + "', '" + txtDescription9.Text + "', '" + cbxFormat9.Text + "', '" + 9 + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (gbxQuestion10.Visible == true)
                    {
                        cmd = new SqlCommand("INSERT INTO question (survey_id, description, question_format, question_number) VALUES ('" + surveyID.ToString() + "', '" + txtDescription10.Text + "', '" + cbxFormat10.Text + "', '" + 10 + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    MessageBox.Show("The survey has been created succesfully. Click the 'Refresh' button to update the data.", "Consumer Survey System", MessageBoxButtons.OK);
                    this.Close();

                }
            }
        }

    }
}
