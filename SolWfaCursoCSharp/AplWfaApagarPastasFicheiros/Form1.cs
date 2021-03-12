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

namespace AplWfaApagarPastasFicheiros
{
    public partial class Form1 : Form
    {
        string pastaorigem = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\";
        string pastadestino = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\temp\";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //string[] lista_ficheiros = Directory.GetFiles(pastaorigem, "*.txt");

            //foreach(string item in lista_ficheiros)
            //{
            //    //lstLista.Items.Add(item);
            //    //File.Move(item, Path.GetFileName(item));
            //    File.Move(item, (pastadestino + Path.GetFileName(item)));
            //}

            //File.Copy((pastaorigem + "arquivo1.txt"), (pastadestino + "arquivocopia.txt"));
            //File.Move((pastaorigem + "arquivo1.txt"), (pastadestino + "arquivocopia.txt"));
            //File.Delete(pastaorigem + "log.txt");

            if(Directory.Exists(pastadestino))
                Directory.Delete(pastadestino, true);

            //MessageBox.Show("Cópia realizada com sucesso!");
        }
    }
}
