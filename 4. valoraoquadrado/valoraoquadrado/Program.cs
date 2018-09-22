using System;

namespace valoraoquadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, resultado;

            Console.WriteLine("Entre com o primeiro valor:");
            n1 = Int32.Parse(Console.ReadLine());

            resultado = n1 * n1;
            Console.WriteLine("Seu resultado é:");/* esse console write line é pq nao estava conseguindo exibir a mensagem apos resultado*/
            Console.Write(resultado);

            Console.ReadKey();
        }
    }
}
