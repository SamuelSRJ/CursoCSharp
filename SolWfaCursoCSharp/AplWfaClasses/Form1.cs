using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaClasses
{
    public partial class frmForm : Form
    {
        public frmForm()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();
            Funcionario f3 = new Funcionario();

            f1.id = 1010101;
            f1.nome = "Samuel de Souza";
            f1.idade = 21;
            f1.cargo = "Consultor Técnico";

            f2.id = 1010102;
            f2.nome = "Larissa Furlan";
            f2.idade = 20;
            f2.cargo = "Estagiária";

            f3.id = 1010103;
            f3.nome = "Leticia Barbieri";
            f3.idade = 26;
            f3.cargo = "Estagiária";

            if (Convert.ToInt32(txtCod.Text) == 1)
                lblresultado.Text = "ID: " + f1.id + "\nNOME: " + f1.nome + "\nIDADE: " + f1.idade + "\nCARGO: " + f1.cargo;
            else if (Convert.ToInt32(txtCod.Text) == 2)
                lblresultado.Text = "ID: " + f2.id + "\nNOME: " + f2.nome + "\nIDADE: " + f2.idade + "\nCARGO: " + f2.cargo;
            else if (Convert.ToInt32(txtCod.Text) == 3)
                lblresultado.Text = "ID: " + f3.id + "\nNOME: " + f3.nome + "\nIDADE: " + f3.idade + "\nCARGO: " + f3.cargo;
            else
                lblresultado.Text = "USUÁRIO NÃO CADASTRADO NA BASE DE DADOS.";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario f1 = new Funcionario();

            f1.cadastrar();
        }
    }
}
