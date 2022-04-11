using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número entre 1 e 10: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Operadores: > (Maior que)    < (Menor que)
            // Operador: || (ou)    && (e)

            if (n < 1 || n > 10)
            {
                Console.WriteLine("Número errado!");
            }
            else
            {
                Console.WriteLine("Obrigado!");
            }

            int hora = DateTime.Now.Hour;
            if (hora > 17)
            {
                Console.WriteLine("Boa Noite!");
            }
            else if (hora > 11)
            {
                Console.WriteLine("Boa Tarde!");
            }
            else 
            {
                Console.WriteLine("Bom Dia!");
            }


            Console.ReadLine();
        }
    }
}
