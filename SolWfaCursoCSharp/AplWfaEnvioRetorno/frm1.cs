using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaEnvioRetorno
{
    public partial class frm1 : Form
    {
        string nome = null;

        public frm1()
        {
            InitializeComponent();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            // DEFINE NOME
            if (lblTexto.Text != "")
                nome = lblTexto.Text;

            frm2 formulario = new frm2(nome);
            formulario.ShowDialog();

            if(formulario.nome != null)
                lblTexto.Text = formulario.nome;
        }
    }
}
