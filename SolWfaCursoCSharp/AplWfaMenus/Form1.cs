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

        private void btnCombo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // POPULAR COMBOBOX
            mnu_cmb1.Items.Add("Valor 1");
            mnu_cmb1.Items.Add("Valor 2");
            mnu_cmb1.Items.Add("Valor 3");
            mnu_cmb1.Items.Add("Valor 4");
            mnu_cmb1.Items.Add("Valor 5");

        }

        private void mnu_file_open_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OPEN!");
        }

        private void mnu_cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTexto.Text = mnu_cmb1.Text;

            if (mnu_cmb1.Text == "Valor 1")
                MessageBox.Show("OK!");
        }
    }
}
