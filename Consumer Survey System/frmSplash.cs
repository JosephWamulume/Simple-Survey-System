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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void tmrProgress_Tick(object sender, EventArgs e)
        {
            pnlProgressFore.Width += 3;
            if (pnlProgressFore.Width >= 700)
            {
                tmrProgress.Stop();
                frmLogin flogin = new frmLogin();
                flogin.Show();
                this.Hide();
            }
        }

    }
}
