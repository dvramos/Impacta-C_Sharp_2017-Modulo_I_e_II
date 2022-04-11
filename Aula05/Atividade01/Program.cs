using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Obtendo os Valores
            Console.Write("Digite o valor do produto: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a quantidade: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            // Calculos
            // Operadores: +  -  *  /  %
            decimal resultado = quantidade * valor;

            // Exibição
            Console.Write("Total da Compra: {0:c}", resultado);
            Console.ReadLine();

            // Parcelamento         
            Console.Write("Digite a quantidade de parcelas: ");
            int parcelas = Convert.ToInt32(Console.ReadLine());

            decimal pagamento = resultado / parcelas;

            // Exibição
            Console.Write("A compra ficou em {0} parcelas de {1:c}", parcelas, pagamento);
            Console.ReadLine();

            

        }
    }
}
