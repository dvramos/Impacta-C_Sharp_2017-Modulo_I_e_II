using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (inicio; condição; incremento) {}

            for (int i = 0; i<=10; i++)
            {
                Console.WriteLine(i);
            }

            
            //while (condição)

            string senha = "123";
            string senhaInformada = string.Empty;

            while (senha != senhaInformada)
            {
                Console.WriteLine("Digite a senha: ");
                senhaInformada = Console.ReadLine();
            }
            Console.WriteLine("Senha Correta!");

            int x = 1;
            while (x <= 10)
            {
                Console.WriteLine(x);
                x++;
            }

            // do while

            string senha1 = "123";
            string senhaInformada1 = string.Empty;

            do
            {
                Console.WriteLine("Digite a senha: ");
                senhaInformada1 = Console.ReadLine();
                if (senhaInformada1 != senha1)
                {
                    Console.WriteLine("Senha Incorreta!");
                }
            }
            while (senha1 != senhaInformada1);
            {
                
            }
            Console.WriteLine("Senha Correta!");



            Console.ReadLine();
        }
    }
}
