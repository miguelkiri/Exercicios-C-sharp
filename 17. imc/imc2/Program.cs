using System;

namespace imc2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            double Idade, Altura, Peso, Imc;

            Console.WriteLine("Diga-me o seu nome jovem gafanhoto");
            Nome = (Console.ReadLine());

            Console.WriteLine("Qual a sua idade?");
            Idade = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora me fale seu peso jovem gafanhoto!");
            Peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Estamos acabando so falta a sua altura!");
            Altura = Convert.ToDouble(Console.ReadLine());

            Imc = Peso / (Altura * 2);
            {
                if (Imc < 18.5)
                {
                    Console.WriteLine("Abaixo do peso, va comer bolo!");
                }
                else if ((Imc >= 18.5) && (Imc <= 24.9))
                {
                    Console.WriteLine("Saudavel, PARABENS");
                }

                else if ((Imc >= 25) && (Imc <= 29.9))
                {
                    Console.WriteLine("Peso em Excesso,Bora se correr");
                }
                else if ((Imc >= 30) && (Imc <= 34.9))
                {
                    Console.WriteLine("Obesidade Grau I");
                }
                else if ((Imc >= 35) && (Imc <= 39.9))
                {
                    Console.WriteLine("Obesidade Grau II (SEVERA)");
                }
                else if (Imc >= 40)
                {
                    Console.WriteLine("Obsidade Grau III");
                }
            }
            Console.WriteLine("IMC: " + Imc);
            Console.ReadKey();
        }
        
    }  
                    }
               
               
            
        
    

