using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplWfaEncapsulamento
{
    class cl_calculo
    {
        private int percentagem1 = 5;
        private int percentagem2 = 12;
        private int percentagem3 = 23;

        public int CalcularPrecoFinal(int preco_inicial, int tipo_produto)
        {
            int preco_final = 0;

            // CALCULO DO PREÇO FINAL
            switch (tipo_produto)
            {
                // ALIMENTO
                case 1:
                    preco_final = preco_inicial + (preco_inicial * percentagem1/100);
                    break;                               
                                                         
                // FERRAMENTA                            
                case 2:                                  
                    preco_final = preco_inicial + (preco_inicial * percentagem2 / 100);
                    break;                               
                                                         
                // BELEZA                                
                case 3:                                  
                    preco_final = preco_inicial + (preco_inicial * percentagem3 / 100);
                    break;
            }

            return preco_final;
        }
    }
}
