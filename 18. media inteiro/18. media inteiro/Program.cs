using System;

namespace _18._media_inteiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, acc = 0, media; // variaveis

            Console.WriteLine("Quantas vezes?");
            // armazenando o que foi digitado em x
            x = Convert.ToInt32(Console.ReadLine());

            // looping
            for (int i = 0; i < x; i++) // poderia ser i = 1 e i <=x, da na mesma
            {
                Console.WriteLine("Digite um número:");
                // converte o texto digitado em int e ja soma com a variavel acc
                acc += Convert.ToInt32(Console.ReadLine());
            }

            // calcula media
            media = acc / x;

            // mostra resultado
            Console.WriteLine("Média: {0}", media);

            // só da um pause no final
            Console.ReadKey();
        }
    }
}
