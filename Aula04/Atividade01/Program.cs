using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    //Classe
    internal class Program
    {
        //Método Principal
        static void Main(string[] args)
        {
            //Somar dois números
            int n1, n2, resultado;

            //Obtendo os valores
            Console.Write("Digite o primeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            //Processando
            resultado = n1 + n2;

            //Exibindo
            Console.WriteLine("A soma de {0} e {1} é {2}!",n1, n2, resultado);
            Console.ReadLine();


        }
    }
}
