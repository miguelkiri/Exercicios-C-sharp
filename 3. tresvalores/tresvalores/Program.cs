using System;

namespace tres_valores_inteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, resultado;

            Console.WriteLine("Entre com o primeiro valor:");
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o segundo valor:");
            n2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o terceiro valor:");
            n3 = Int32.Parse(Console.ReadLine());

            resultado = n1 + n2 + n3;
            Console.WriteLine("Seu resultado é:");/* esse console write line é pq nao estava conseguindo exibir a mensagem apos resultado*/
            Console.Write(resultado);

            Console.ReadKey();


        }
    }
}
