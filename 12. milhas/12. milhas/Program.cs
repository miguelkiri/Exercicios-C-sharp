using System;

namespace _12._milhas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de milhas para quilometros\n");
            double M, Km;
            Console.WriteLine("Digite a distancia em milhas:\n");
            M = double.Parse(Console.ReadLine());

            Km = M*1.61;

            Console.WriteLine("Sua distancia em quilometros eh:\n\n" + Km);
            Console.ReadKey();

        }
    }
}
