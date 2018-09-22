using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double c;
            Console.WriteLine("Informe a temparatura em graus C : ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} = {1}", c, ConvertTemp.ConverteCelsiusToFahrenheit(c));
            Console.ReadKey();
        }

        static class ConvertTemp
        {

            public static double ConverteCelsiusToFahrenheit(double c)
            {
                return ((9.0 / 5.0) * c) + 32;
            }
        }
    }
}