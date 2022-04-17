using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Conceitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando um objeto/instância da classe Calculos

            Calculos calc = new Calculos();
            int total = calc.Somar(1, 5, 15);
            int resto = calc.Subtrair(10, 3);

            Console.WriteLine("Total: {0}", total);
            Console.WriteLine("Resto: {0}", resto);


            Produto prod = new Produto();
            prod.Nome = "Mo";
            prod.Preco = -100;

            Console.WriteLine("Nome: {0}", prod.Nome);
            Console.WriteLine("Preço: {0:c}", prod.Preco);


            Console.ReadLine(); 
        }
    }
}
