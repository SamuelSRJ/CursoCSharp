using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplWfaCassesEMetodos
{
    class Pessoa
    {
        public string nome;
        public string apelido;

        public void identificarSe()
        {
            System.Windows.Forms.MessageBox.Show(ConstruirNome());
        }

        private string ConstruirNome()
        {
            string nomecompleto = nome + " " + apelido;
            return nomecompleto;
        }
    }
}
