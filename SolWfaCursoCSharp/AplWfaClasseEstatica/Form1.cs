using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaClasseEstatica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = Estatica.NomePrograma;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Normal objeto1 = new Normal();
            objeto1.Nome = "Samuel Souza";
            objeto1.ApresentarNome();

            Normal objeto2 = new Normal();
            objeto2.Nome = "Dias Ribeiro";
            objeto2.ApresentarNome();

            Estatica.Nome = "Samuel";
            Estatica.ApresentarNome();
        }
    }
}
