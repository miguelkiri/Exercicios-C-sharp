using System;

namespace _25._Conte
{
    class Program
    {
        static void Main(string[] args)
        {
            //laço da cetena
            for(int x = 1; x<=9; x++)
            {
                //laço da dezena
                for(int y=0; y<=9; y++)
                {
                    //if para controlar a cada 20 crar uma pausa
                    if(y %2==0 && y!=0)
                    {
                        Console.WriteLine("Precione qualquer tecla para continuar");
                        Console.ReadKey();
                    }
                    //laço da unidade
                    for(int z=0; z<=9; z++)
                    {
                        //texto mostra para cada numero de 100-999
                        Console.WriteLine("{0}({1}*{2}*{3})",(x * y * z), x, y, z);//calculo a ser feito
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
