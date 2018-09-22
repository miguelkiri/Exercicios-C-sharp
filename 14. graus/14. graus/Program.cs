using System;

namespace _14._graus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Graus para Radiando\n");
            double g, r, pi;
            pi = 3.14;
            Console.WriteLine("Informe um angulo em graus:\n");
            g = double.Parse(Console.ReadLine());

            r = g * pi / 180;

            Console.WriteLine("Seu angulo em Radiando:\n\n" + r);
            Console.ReadKey();

        }
    }
}
