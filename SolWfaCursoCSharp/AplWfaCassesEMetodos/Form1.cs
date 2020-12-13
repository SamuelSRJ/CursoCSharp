using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaCassesEMetodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Pessoa p1 = new Pessoa();
            p1.nome = "João";
            p1.apelido = "Ribeiro";

            // Identificar-se
            p1.identificarSe();
        }
    }
}
