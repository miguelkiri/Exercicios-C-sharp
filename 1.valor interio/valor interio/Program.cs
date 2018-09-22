using System;

namespace tres_valores_inteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,resultado;

            Console.WriteLine("Entre com o valor:");
            n1 = Int32.Parse(Console.ReadLine());

           

            resultado = n1;
            Console.WriteLine("Seu Valor é:");
            Console.Write(resultado);

            Console.ReadKey();


        }
    }
}
