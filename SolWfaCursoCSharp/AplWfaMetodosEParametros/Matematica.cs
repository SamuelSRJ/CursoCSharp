using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplWfaMetodosEParametros
{
    class Matematica
    {
        int num1;
        int num2;
        public int operacoes(int num1, int num2, string op)
        {
            this.num1 = num1;
            this.num2 = num2;

            int resultado = 0;

            if (op == "+")
            {
                resultado = adicao();
            }

            else if(op == "-")
            {
                resultado = subtracao();
            }

            else if (op == "*")
            {
                resultado = multiplicacao();
            }

            else if (op == "/")
            {
                resultado = divisao();
            }
            return resultado;
        }

        private int adicao()
        {
            return num1 + num2;
        }

        private int subtracao()
        {
            return num1 - num2;
        }

        private int multiplicacao()
        {
            return num1 * num2;
        }

        private int divisao()
        {
            return num1 / num2;
        }
    }
}

//switch (op)
//{
//    case "+":
//        return num1 + num2;
//        break;

//    case "-":
//        return num1 - num2;
//        break;

//    case "*":
//        return num1 * num2;
//        break;

//    case "/":
//        return num1 / num2;
//        break;

//    default:
//        return -1;
//        break;
//}



//if(op == "+")
//{
//    return num1 + num2;
//}
//else if (op == "-")
//{
//    return num1 - num2;
//}
//else if(op == "*")
//{
//    return num1 * num2;
//}
//else if (op == "/")
//{
//    return num1 / num2;
//}
//else
//{
//    return -1000000;
//}