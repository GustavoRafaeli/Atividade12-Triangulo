using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTriangulo.App
{
    public class Triangulo
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }

        public void DefinirTipo()
        {
            if (Lado1 < Lado2 + Lado3 && Lado2 < Lado1 + Lado3 && Lado3 < Lado1 + Lado2)
            {
                if (Lado1 == Lado2 && Lado1 == Lado3)
                {
                    Console.WriteLine("Este triangulo é equilátero");
                }
                else if (Lado1 != Lado2 && Lado1 != Lado3 && Lado2 != Lado3)
                {
                    Console.WriteLine("Este triangulo é escaleno");
                }
                else
                {
                    Console.WriteLine("Este triangulo é um Isósceles");
                }
            }
            else
            {
                Console.WriteLine("Não é um Triangulo");
            }
        }
    }
}
