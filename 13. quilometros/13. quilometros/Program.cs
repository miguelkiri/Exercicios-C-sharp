using System;

namespace _13._quilometros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de quilometros para milhas!\n");
            double k, m;
            Console.WriteLine("Digite sua distancia em Quilometros:\n");
            k = double.Parse(Console.ReadLine());

            m = k / 1.61;

            Console.WriteLine("Distancia convertida em Milhas:\n\n" + m);
            Console.ReadKey();
        }
    }
}
