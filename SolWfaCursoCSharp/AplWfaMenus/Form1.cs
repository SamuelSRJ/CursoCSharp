using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaMenus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnu_file_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            if (mnu_file_open.Enabled)
                mnu_file_open.Enabled = false;
            else
                mnu_file_open.Enabled = true;
        }
    }
}
