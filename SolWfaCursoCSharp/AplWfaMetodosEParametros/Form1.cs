using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaMetodosEParametros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            Matematica matematica = new Matematica();

            int resultado = matematica.operacoes(3, 7, "-");

            lbltexto.Text = resultado.ToString();
        }
    }
}
