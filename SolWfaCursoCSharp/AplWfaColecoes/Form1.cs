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

        private void btnList2_Click(object sender, EventArgs e)
        {
            List<int> listInt = new List<int>() { 5, 10, 20, 40, 80, 160 };
            foreach (int item in listInt)
                lstLista.Items.Add(item);
        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            HashSet<string> lista_nomes = new HashSet<string>()
            {
                "João", "Carlos", "Rui", "Marco"
            };

            lista_nomes.Add("Nuno");
            // O NOME "João" É AUTOMATICAMENTE IGNORADO, POIS, JÁ EXISTE
            if(!lista_nomes.Add("João"))
            {
                MessageBox.Show("Esse nome já existe!");
            }

            foreach (string nome in lista_nomes)
                lstLista.Items.Add(nome);
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> lista_valores;
            lista_valores = new Dictionary<string, string>();

            lista_valores.Add("1","João");
            lista_valores.Add("2", "Antonio");

            foreach (KeyValuePair<string, string> item in lista_valores)
            {
                lstLista.Items.Add(item.Key);
            }
        }
    }
}
