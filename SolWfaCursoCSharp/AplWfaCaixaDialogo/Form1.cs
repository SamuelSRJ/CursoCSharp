using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaCaixaDialogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            // MESSAGEBOX
            // INFORMAÇÃO SIMPLES
            // MessageBox.Show("MessageBox Simples!");

            // TITULO BOTÕES E ICONES
            // MessageBox.Show("Texto da Mensagem", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // CAIXA DE DIALOGO COM RESULTADO
            if(MessageBox.Show("Deseja sair da aplicação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)return;

            // FECHA A APLICAÇÃO
            Application.Exit();

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog caixa = new OpenFileDialog();
            caixa.Title = "Escolher ficheiro";
            caixa.InitialDirectory = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            caixa.Filter = ".txt Files(*.txt)|*.txt|.doc Files(*.doc)|*.doc|.jpeg Files(*.jpg)|*.jpg";

            if(caixa.ShowDialog()== DialogResult.Cancel) return;

            // ABRE O FICHEIRO
            // MessageBox.Show("Ficheiro Selecionado: " + caixa.FileName);
            pcbImagem.BackgroundImage = Image.FromFile(caixa.FileName);
            caixa.Dispose();
        }
    }
}
