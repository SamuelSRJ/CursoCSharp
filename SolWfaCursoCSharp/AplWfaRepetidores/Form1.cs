using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaRepetidores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBotao_Click(object sender, EventArgs e)
        {
            // *****************
            // FOR
            // *****************

            //for(int i =0; i<=50; i++)
            //{
            //    lstlLista.Items.Add(i);
            //}

            // *****************
            // WHILE
            // *****************

            //while (true)
            //{

            //}

            // *****************
            // DO WHILE
            // *****************

            //do
            //{

            //} while (true);

            // *****************
            // FOREACH
            // *****************
            //string frase = "Este ciclo é fantastico.";

            //foreach(char c in frase)
            //{
            //    lstlLista.Items.Add(c);
            //}

            List<string> listaNomes = new List<string>
            {
                "Larissa", "Leticia", "Eduarda", "Maira", "Victoria", "Emile"
            };

            foreach(string s in listaNomes)
            {
                lstlLista.Items.Add(s);
            }
        }
    }
}
