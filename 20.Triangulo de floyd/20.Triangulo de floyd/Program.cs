using System;

namespace _20.Triangulo_de_floyd
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeLinhas = 6;
            int quantidadeColunas = 2;
            int ultimoValor = 1;
            string saida = ultimoValor.ToString() + "\n";
            for (int i = 0; i < quantidadeLinhas - 1; i++)
            {
                for (int j = 0; j < quantidadeColunas; j++)
                {
                    ultimoValor++;
                    saida += ultimoValor.ToString() + " ";
                }

                saida += "\n";
                quantidadeColunas++;
            }
            Console.WriteLine(saida);
            Console.ReadKey();
        }
    }
}
