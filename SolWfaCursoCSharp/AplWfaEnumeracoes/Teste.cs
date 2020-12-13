using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplWfaEnumeracoes
{
    class Teste
    {
        // ENUMERAÇÃO DE DIAS DA SEMANA
        public enum DiasDaSemana
        {
            domindo, segunda, terça, quarta, quinta, sexta, sábado
        }

        // ENUMERAÇÃO DE MOVIMENTOS
        public enum Movimentos { Cima, Baixo, Esquerda, Direira }

        public void ApresentarDia(DiasDaSemana dia)
        {
            Console.WriteLine("O dia escolhido foi " + dia);
        }

        public void Mover(Movimentos direção)
        {
            Console.WriteLine("O Jogador moveu-se para " + direção);
        }
    }
}
