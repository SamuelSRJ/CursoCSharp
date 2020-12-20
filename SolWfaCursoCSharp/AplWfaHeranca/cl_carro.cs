using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplWfaHeranca
{
    class cl_carro : cl_veiculo
    {
        public int velocidade_maxima { get; set; }

        public void LigarMotor()
        {

        }

        public override void Acelerar()
        {
            Console.WriteLine("Vruuuuuuuum!");
        }
    }
}
