using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposPrimitivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipos Primitivos");
            
            System.String nome = "José"; // Classe
            string nome1 = "José";

            System.Int32 numero = 10;
            Int32 numero1 = 11;
            int numero2 = 12;

            System.Int64 numero3 = 10;
            Int64 numero4 = 11;
            long numero5 = 12;

            string texto = "Texto";

            short quantidade = 100;
            int numero0 = 20;
            long numeroGrande = 120000;
            byte item = 20;

            double comissao = 32.45;
            decimal valor = Convert.ToDecimal(1000.56);
            decimal valor1 = 1000.56m;

            DateTime data = DateTime.Now;
            DateTime dataExemplo = new DateTime(2050, 12, 31);
            
            Console.WriteLine(data);
            Console.WriteLine("{0:d}", dataExemplo);
            Console.WriteLine("{0:D}", dataExemplo);
            Console.WriteLine("{0:ddd}", dataExemplo);

            Console.WriteLine("{0:c}", valor1);

            Console.ReadLine();

        }
    }
}
