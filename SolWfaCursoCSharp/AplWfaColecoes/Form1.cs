using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaColecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            // ARRAY
            string[] nomes;
            nomes = new string[5];

            nomes[0] = "João";
            nomes[1] = "Maria";
            nomes[2] = "Carlos";
            nomes[3] = "Carla";
            nomes[4] = "Felipe";

            // COLEÇÃO - LIST
            List<string> NOMES = new List<string>();
            NOMES.Add("Nome1");
            NOMES.Add("Nome2");
            NOMES.Add("Nome3");
            NOMES.Add("Nome4");
            NOMES.Add("Nome5");
            NOMES.Add("Nome6");
            NOMES.Add("Fernanda");
            NOMES.Add("Nome8");

            NOMES.Remove("Nome4");
            NOMES.Remove("Fernanda");

            foreach (string item in NOMES)
                lstLista.Items.Add(item);

            if (NOMES.Contains("Fernanda"))
            {
                MessageBox.Show("Sim!");
            }
            else
            {
                MessageBox.Show("Não!");
            }

            //MessageBox.Show(NOMES.Count.ToString());
        }
    }
}
