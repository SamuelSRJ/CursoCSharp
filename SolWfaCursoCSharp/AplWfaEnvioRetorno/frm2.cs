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
    public partial class frm2 : Form
    {
        public string nome { get; set; }

        public frm2(string nome)
        {
            InitializeComponent();

            txtNome.Text = nome;
            //this.nome = nome;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // DEFINI O VALOR A SER RETORNADO
            if (txtNome.Text == "")
                nome = null;
            else
                nome = txtNome.Text;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // FECHA O FORMULÁRIO SEM ENVIAR VALOR
            nome = null;
            this.Close();
        }
    }
}
