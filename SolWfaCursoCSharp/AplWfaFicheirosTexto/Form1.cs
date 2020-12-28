using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AplWfaFicheirosTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            // Gravar ficheiro de texto
            // ASSINATURAS (LOCAL DO ARQUIVO E SEU NOME, APPEND, ENCONDING)
            // APPEND TRUE -> Todo texto atualizado será ADIOCIONADO no arquivo
            // APPEND FALSE -> Todo texto atualizado SUBSTITUIRÁ o conteudo no arquivo

            int valor = 200;
            StreamWriter ficheiro = new StreamWriter(@"C:\Users\usuario\Music\file.txt", true, Encoding.Default);
            //ficheiro.WriteLine("Overwrited successfully!");
            //ficheiro.WriteLine(valor);
            ficheiro.WriteLine(txtTexto.Text);
            txtTexto.Clear();
            txtTexto.Focus();
            ficheiro.Dispose();
        }
    }
}
