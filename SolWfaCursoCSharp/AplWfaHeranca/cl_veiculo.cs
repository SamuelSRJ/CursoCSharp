using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplWfaHeranca
{
    abstract class cl_veiculo
    {
        public string cor { get; set; }
        public string marca { get; set; }

        abstract public void Acelerar();
    }
}
