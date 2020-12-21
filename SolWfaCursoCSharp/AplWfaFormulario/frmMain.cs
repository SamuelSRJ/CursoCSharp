using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaFormulario
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //if (chkActivate.Checked)
            //{
            //    lblLabel.BackColor = Color.Green;
            //    lblLabel.Text = "Ativo";
            //}
            //else
            //{
            //    lblLabel.BackColor = Color.Red;
            //    lblLabel.Text = "Desligado";
            //    lblLabel.ForeColor = Color.White;
            //}
        }

        private void chkActivate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActivate.Checked)
            {
                lblLabel.BackColor = Color.Green;
                lblLabel.Text = "Ativo";
            }
            else
            {
                lblLabel.BackColor = Color.Red;
                lblLabel.Text = "Desligado";
                lblLabel.ForeColor = Color.White;
            }
        }
    }
}
