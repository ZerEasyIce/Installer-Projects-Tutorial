using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer_Projects_Tutorial
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            lblText.BackColor = Color.Red;
            lblText.Focus();
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            lblText.BackColor = Color.Yellow;
            lblText.Focus();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            lblText.BackColor = Color.Blue;
            lblText.Focus();
        }
    }
}
