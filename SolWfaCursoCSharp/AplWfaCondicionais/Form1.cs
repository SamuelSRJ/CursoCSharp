using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaCondicionais
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            // if

            //int valor = 10;

            //if(valor >= 20)
            //{
            //    lblresultado.Text = "OK";
            //}
            //else
            //{
            //    lblresultado.Text = "NÃO";
            //}

            int valor = 50;

            // condição ternaria
            lblresultado.Text = valor == 10 ? "SIM" : "NÃO";
        }
    }
}
