using System;

namespace km_e_ms
{
    class Program
    {
        static void Main(string[] args)
        {
            double km, ms;
            Console.WriteLine("Entre com a distancia em Km/h:");
            km = double.Parse(Console.ReadLine());

            ms = km /3.6 ;
            Console.WriteLine("Sua distancia em M/s eh:" +ms);
            Console.ReadKey();

        }
    }
}
