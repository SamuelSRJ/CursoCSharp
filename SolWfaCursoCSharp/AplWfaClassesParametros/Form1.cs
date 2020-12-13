using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaClassesParametros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teste objeto = new Teste();
            int v = 10;

            v = objeto.acrescentar(300);

            //          objeto.diminuir(ref v); // ref REFERENCIA QUAL VARIÁVEL SERÁ PASSADA, DESTE MODO É POSSÍVEL UTILIZA-LA EM OUTRA CLASSE

            label1.Text = v.ToString();
        }
    }
}
