using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplWfaPolimorfismo
{
    // ===================================================
    abstract class forma_geometrica
    {
        int _largura;
        int _altura;

        // ----------------------------------------------------------
        public int Largura
        {
            get { return _largura; }
            set { _largura = value; }
        }

        // ----------------------------------------------------------
        public int Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        // ----------------------------------------------------------
        public void Apresentar()
        {
            Console.WriteLine("Este método pertence à classe base.");
        }

        // ----------------------------------------------------------
        // DEVE SER IMPLEMENTADO POR TODAS AS CLASSE DERIVADAS
        public abstract void Desenhar();

        // ----------------------------------------------------------
        public virtual void Desenhar_Outro()
        {
            Console.WriteLine("Método virtual da classe base.");
        }
    }

    // ===================================================
    class retangulo : forma_geometrica
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenha retangulo com as dimensões: " + Largura + "x" + Altura);
        }

        public override void Desenhar_Outro()
        {
            Console.WriteLine("Este é um método virtual substituido na classe derivada.");
        }
    }

    // ===================================================
    class triangulo : forma_geometrica
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenha triangulo com as dimensões: " + Largura + "x" + Altura);
        }
    }

    // ===================================================
    class circunferencia : forma_geometrica
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenha circunferencia com as dimensões: " + Largura + "x" + Altura);
        }
    }
}
