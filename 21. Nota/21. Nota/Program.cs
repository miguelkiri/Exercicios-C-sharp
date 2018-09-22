using System;

namespace media
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double n1, n2, n3, me, mf;
            Console.WriteLine("Calculo de media de aluno\n");

            Console.WriteLine("Digite a primeira nota:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota:");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota:");
            n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a media dos exercicios:");
            me = double.Parse(Console.ReadLine());

            mf = (n1 + n2 * 2 + n3 * 3 + me) / 7;

            if (mf >= 9)
            {
                Console.WriteLine("Nota A");
            }
            else if ((mf >= 7.5) && (mf <= 8.9))
            {
                Console.WriteLine("Nota B");
            }
            else if ((mf >= 6) && (mf <= 7.4))
            {
                Console.WriteLine("Nota C");
            }
            else if ((mf >= 4) && (mf <= 5.9))
            {
                Console.WriteLine("Nota D");
            }
            else if (mf < 4)
            {
                Console.WriteLine("Nota E");
            }
            Console.WriteLine("Nota:" + mf);
            Console.ReadKey();

        }
    }
}