using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consumer_Survey_System
{
    public partial class frmEditSurvey : Form
    {
        public frmEditSurvey()
        {
            InitializeComponent();
        }

        private void btnAddQuestion2_Click(object sender, EventArgs e)
        {
            btnAddQuestion2.Visible = false;
            gbxQuestion2.Visible = true;
            btnAddQuestion3.Visible = true;
            btnRemoveQuestion2.Visible = true;
        }

        private void btnRemoveQuestion2_Click(object sender, EventArgs e)
        {
            btnAddQuestion2.Visible = true;
            gbxQuestion2.Visible = false;
            btnAddQuestion3.Visible = false;
            btnRemoveQuestion2.Visible = false;
        }

        private void btnAddQuestion3_Click(object sender, EventArgs e)
        {
            btnAddQuestion3.Visible = false;
            btnRemoveQuestion2.Visible = false;
            gbxQuestion3.Visible = true;
            btnAddQuestion4.Visible = true;
            btnRemoveQuestion3.Visible = true;
        }

        private void btnRemoveQuestion3_Click(object sender, EventArgs e)
        {
            btnAddQuestion3.Visible = true;
            gbxQuestion3.Visible = false;
            btnAddQuestion4.Visible = false;
            btnRemoveQuestion3.Visible = false;
        }

        private void btnAddQuestion4_Click(object sender, EventArgs e)
        {
            btnAddQuestion4.Visible = false;
            btnRemoveQuestion3.Visible = false;
            gbxQuestion4.Visible = true;
            btnAddQuestion5.Visible = true;
            btnRemoveQuestion4.Visible = true;
        }
    }
}
