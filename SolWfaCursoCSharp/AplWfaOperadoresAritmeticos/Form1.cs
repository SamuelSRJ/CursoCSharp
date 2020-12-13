using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaOperadoresAritmeticos
{
    public partial class frmForm : Form
    {
        public frmForm()
        {
            InitializeComponent();
        }

        private void btnbotao_Click(object sender, EventArgs e)
        {
            //int parcela1 = int.Parse(txtnum1.Text);
            //int parcela2 = int.Parse(txtnum2.Text);
            //int resultado;

            //// adição (+)
            //resultado = parcela1 + parcela2;

            //// subtração (-)
            //resultado = parcela1 - parcela2;

            //// multiplicação (*)
            //resultado = parcela1 * parcela2;

            //// divisão (/)
            //resultado = parcela1 / parcela2;

            //// modulo (%)
            //resultado = parcela1 % parcela2;

            int resultado = 10;

            // resultado = resultado + 1;
            // resultado++;
            resultado += 5;

            lblresultado.Text = resultado.ToString();
        }
    }
}
