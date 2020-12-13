using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaEnumeracoes
{
    public partial class Form1 : Form
    {
        Teste Jogador;

        public Form1()
        {
            InitializeComponent();

            Jogador = new Teste();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCima_Click(object sender, EventArgs e)
        {
            // MOVE PARA CIMA
            Jogador.Mover(Teste.Movimentos.Cima);
        }

        private void btnDireita_Click(object sender, EventArgs e)
        {
            // MOVE PARA DIREITA
            Jogador.Mover(Teste.Movimentos.Direira);
        }

        private void btnBaixo_Click(object sender, EventArgs e)
        {
            // MOVE PARA BAIXO
            Jogador.Mover(Teste.Movimentos.Baixo);
        }

        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            // MOVE PARA ESQUERDA
            Jogador.Mover(Teste.Movimentos.Esquerda);
        }
    }
}
