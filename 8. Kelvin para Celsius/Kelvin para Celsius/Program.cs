using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelvin_para_Celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            double k;
            Console.WriteLine("Informe a temperatura em Kelvin :");
            k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} = {1}", k, ConvertTemp.ConverteKelvinToCelsius(k));
            Console.ReadKey();
        }
        static class ConvertTemp
        { public static double ConverteKelvinToCelsius(double k)
            {
                Console.WriteLine("Sua temperatura convertida eh:");
                return (k - 273.15);
                    }

           
        }
    }
}
