using System;

namespace _19.__soma
{
    class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            int num, result = 0;
            string texto = "";

            //entrada de dados
            Console.WriteLine("Digite um número");
            num = Convert.ToInt32(Console.ReadLine());

            //looping rodará o tanto de vezes do numero digitado
            for(int i =1; i<=num; i++)
            {
                //verifica se o resto da divisao é 0, sendo, entao é um divisor
                if(num % i ==0)
                {
                    //verifica se nao é o numero difitado, nao sendo, entao some-os na variavek result
                    if (num!=i)
                    {
                        result += i;

                        //monta texto
                        //se i=1, texto ="1"
                        if(i==1)
                        {
                            texto = "1";
                        }
                        //senao texto = +1
                        else
                        {
                            texto += " + " + i;
                        }
                    }
                }
            }
            //saida
            Console.WriteLine("Soma dos divisores:{0} = {1}", texto, result);
            Console.ReadKey();
        }
    }
}
