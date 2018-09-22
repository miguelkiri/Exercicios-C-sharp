using System;

namespace _16._polegadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Polegadas para Centimetros\n");
            double p, c;
            Console.WriteLine("Digite o comprimento em Polegadas:\n");
            p = double.Parse(Console.ReadLine());
            c = p * 2.54;
            Console.WriteLine("Distancia em Centimetros:\n\n" + c);
            Console.ReadKey();
        }
    }
}
