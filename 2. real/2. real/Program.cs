using System;

namespace _2._real
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimindo um numero real\n\n");
            double n;
            Console.WriteLine("Digite um numero real:\n");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("Numero real digitado eh:\n" + n);
            Console.ReadKey();
        }
    }
}
