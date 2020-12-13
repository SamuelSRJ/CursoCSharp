using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplWfaClassesParametros
{
    class Teste
    {
        //public int acrescentar(int valor = 20)  // PODE SER SETADO UM VALOR DEFAULT, CASO O USUÁRIO INSIRA ALGUM DADO, ESTE SUBSTITUIRÁ O DEFAULT.
        //{
        //    valor += 10;
        //    return valor;
        //}
        
       public int acrescentar(int x, int v = 20) // NESTE EXEMPLO PODEMOS DEIXAR UM VALOR CORINGA QUE SERÁ SUBSTITUIDO PELO USUÁRIO, O "v" CONTINUA NORMAL.
        {
            v = v + x;
            return v;
        }
        
        public void diminuir(ref int valor) // VALOR REFERENCIADO ATRAVÉS DO ref
        {
            valor -= 5;
        }
    }
}
