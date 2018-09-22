using System;

namespace _15._radiando
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Radiandos para Graus");
            double r, g;
            Console.WriteLine("Digite um angulo em radiandos:\n");
            r = double.Parse(Console.ReadLine());
            g = r * 180 / 3.14;
            Console.WriteLine("Seu angulo em Graus:\n\n" + g);
            Console.ReadKey();
        }
    }
}
