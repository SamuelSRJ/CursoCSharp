using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AplWfaConversao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            StreamWriter ficheiro = new StreamWriter(@"C:\Users\usuario\Music\dados.txt", false, Encoding.Default);

            // STRING
            ficheiro.WriteLine("Essa frase é alfanumérica.");

            // INT
            int valor = 150;
            ficheiro.WriteLine(valor);

            // BOOLEAN
            bool resultado = false;
            ficheiro.WriteLine(resultado);

            // DATA
            ficheiro.WriteLine(DateTime.Now);

            // COR
            Color cor = Color.FromArgb(30, 125, 232);
            ficheiro.WriteLine(cor.ToArgb());

            ficheiro.Dispose();
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            StreamReader ficheiro = new StreamReader(@"C:\Users\usuario\Music\dados.txt");

            // STRING
            string a = ficheiro.ReadLine();
            // INT
            //int b = int.Parse(ficheiro.ReadLine());
            int b = Convert.ToInt16(ficheiro.ReadLine());
            // BOOLEAN
            bool c = bool.Parse(ficheiro.ReadLine());
            // DATA
            DateTime d = DateTime.Parse(ficheiro.ReadLine());
            // COR
            Color cor = Color.FromArgb(int.Parse(ficheiro.ReadLine()));
            pcbCor.BackColor = cor;

            ficheiro.Dispose();
        }
    }
}
