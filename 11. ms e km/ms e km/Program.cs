using System;

namespace ms_e_km
{
    class Program
    {
        static void Main(string[] args)
        {
            double ms, km;
            Console.WriteLine("Entre com a distancia em M/s:");
            ms = double.Parse(Console.ReadLine());

            km = ms * 3.6;
            Console.WriteLine("Sua distancia em Km/h eh:" + km);
            Console.ReadKey();
        }
    }
}
