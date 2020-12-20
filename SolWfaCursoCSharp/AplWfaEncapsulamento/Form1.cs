using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaEncapsulamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            // APRESENTAR O VALOR FINAL DOS PRODUTOS
            cl_calculo calculadora = new cl_calculo();

            int preco_inicial = Convert.ToInt16(txtPreco.Text);
            int tipo_produto = 0;
            if (rd1.Checked)
                tipo_produto = 1;
            else if (rd2.Checked)
                tipo_produto = 2;
            else if (rd3.Checked)
                tipo_produto = 3;

            MessageBox.Show("PREÇO FINAL = " + calculadora.CalcularPrecoFinal(preco_inicial, tipo_produto));
        }
    }
}
