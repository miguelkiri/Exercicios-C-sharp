using System;

namespace _5._quintaparte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quinta parte de um numero inteiro\n");
            int n;
            Console.WriteLine("Digite um numero inteiro:\n");
            n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("A quinta parte do numero digitado eh:\n\n" + n / 5);
            Console.ReadKey();
        }
    }
}
