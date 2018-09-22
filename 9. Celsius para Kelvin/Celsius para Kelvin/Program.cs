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
            double bala;
            Console.WriteLine("Informe o produto :");
            bala = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} = {1}", C, ConvertTemp.ConverteBalaValor(bala));
            Console.ReadKey();
        }
        static class ConvertTemp
        {
            public static double ConverteBalaValor(double bala)
            {
                Console.WriteLine("o valor do seu produto é");
                return (bala >=50/0.05);
            }


        }
    }
}
