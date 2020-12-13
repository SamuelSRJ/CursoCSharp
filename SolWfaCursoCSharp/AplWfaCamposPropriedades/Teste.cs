using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplWfaCamposPropriedades
{
    class Teste
    {
        // definição de um CAMPO
        private string _nome;

        public string apelido;

        // definição de uma PROPRIEDADE
        public string Nome { get; set; }

        //public string Nome
        //{
        //    set { _nome = value; }

        //    get { return _nome; }
        //}
        public void Apresentar()
        {
            System.Windows.Forms.MessageBox.Show(Nome);
        }
    }
}
