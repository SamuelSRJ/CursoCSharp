using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplWfaClasses
{
    class Funcionario
    {
        public int id;
        public string nome;
        public int idade;
        public string cargo;

        public void cadastrar()
        {
            System.Windows.Forms.MessageBox.Show("Usuário cadastrado com sucesso");
        }
    }
}
