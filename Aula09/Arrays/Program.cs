using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array

            int[] numeros = new int[6];

            //Preenchendo
            numeros[0] = 40;
            numeros[1] = 5;
            numeros[2] = 52;
            numeros[3] = 17;
            numeros[4] = 6;
            numeros[5] = 10;

            //Percorrendo
            foreach(int n  in numeros)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("---------");

            //Ordenar
            Array.Sort(numeros);

            //Percorrendo
            foreach (int n in numeros)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("---------");

            //Pesquisar
            int indice = Array.IndexOf(numeros, 40);
            if (indice == -1)
            {
                Console.WriteLine("40 não encontrado!");
            }
            else
            {
                Console.WriteLine("Encontrado:{0} na posição {1}",numeros[indice], indice);
            }
            Console.WriteLine("---------");

            //Inverter
            Array.Reverse(numeros);

            foreach (int n in numeros)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("---------");

            //Tamanho
            int tamanho = numeros.Length;
            Console.WriteLine("Tamanho:{0}", tamanho);

            Console.WriteLine("---------");

            string[] arquivos = Directory.GetFiles(@"C:\windows\web", ".", SearchOption.AllDirectories);
            foreach (string arq in arquivos)
            {
                Console.WriteLine(arq);
            }
           

            Console.ReadLine();
        }
    }
}
