using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaConstantesEstruturas
{
    public partial class Form1 : Form
    {
        struct estrutura_pessoa
        {
            public string Nome;
            public string Apelido;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Normal objeto1 = new Normal();
            Console.WriteLine(objeto1.Nome);
            Console.WriteLine(Estatica.Nome);

            Pessoa p1 = new Pessoa();
            p1.Nome = "Samuel";
            p1.Apelido = "Souza";

            // estrutura_pessoa p2 = new estrutura_pessoa() { Nome = "Carlos", Apelido = "Eduardo" };
            estrutura_pessoa p2 = new estrutura_pessoa();
            p2.Nome = "Carlos";
            p2.Apelido = "Eduardo";
            Console.WriteLine(p2.Nome + " " + p2.Apelido);
        }
    }
}
