using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaMultiplosForms
{
    public partial class frmPrimeiro : Form
    {
        public frmPrimeiro()
        {
            InitializeComponent();
        }

        private void frmPrimeiro_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // geral.nome = txtNome.Text;
            frmUm formulario = new frmUm(txtNome.Text);
            formulario.ShowDialog();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            frmDois formulario = new frmDois();
            formulario.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // ENCERRA A APLICAÇÃO COMO UM TODO
            Application.Exit();
        }
    }
}
