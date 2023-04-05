using System;
using TesteTriangulo.App;


namespace TesteTriangulo.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();

            Console.WriteLine("Digite os valores dos lados do triangulo:");
            Console.Write("Lado 1:");
            triangulo.Lado1 = double.Parse(Console.ReadLine());
            Console.Write("Lado 2:");
            triangulo.Lado2 = double.Parse(Console.ReadLine());
            Console.Write("Lado 3:");
            triangulo.Lado3 = double.Parse(Console.ReadLine());


            triangulo.DefinirTipo();
        }
    }
}

