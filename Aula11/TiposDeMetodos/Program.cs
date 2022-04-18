using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var impostos = new Impostos(0.10m);
            var impostos1 = new Impostos();

            decimal valorISS = impostos.CalcularISS("SP", 500);
            decimal valorISSIndividual = impostos.CalcularISS("SP", 500, true);

            decimal valorISS1 = impostos1.CalcularISS("SP", 500);
            decimal valorISSIndividual1 = impostos1.CalcularISS("SP", 500, true);

            Console.WriteLine("Valor do Serviço em São Paulo: {0:C}", valorISS);
            Console.WriteLine("Valor do Serviço em São Paulo para empresa individual: {0:C}", valorISSIndividual);

            Console.WriteLine("Valor do Serviço em São Paulo: {0:C}", valorISS1);
            Console.WriteLine("Valor do Serviço em São Paulo para empresa individual: {0:C}", valorISSIndividual1);


            Console.ReadLine();

        }
    }
}
