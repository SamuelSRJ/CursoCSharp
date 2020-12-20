using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplWfaHeranca
{
    class cl_bicicleta : cl_veiculo
    {
        public void pedalar()
        {

        }

        public override void Acelerar()
        {
            Console.WriteLine("Pedalando....");
        }
    }
}
