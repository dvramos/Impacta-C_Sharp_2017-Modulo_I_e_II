using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            lista.Add("São Paulo");
            lista.Add("Rio de Janeiro");
            lista.Add("Santos");
         // lista.Add(10);  Permite inserir e não dá erro de compilação, apenas na execução

            string cidade = Convert.ToString(lista[1]);

            foreach (string cid in lista)
            {
                Console.WriteLine(cid);
            }
            Console.WriteLine("---------");

            lista.Remove("Santos");
            lista.Insert(0,"Londres");
            foreach (string cid in lista)
            {
                Console.WriteLine(cid);
            }
            Console.WriteLine("---------");

            int tamanho = lista.Count;
            Console.WriteLine("Tamanho: {0}", tamanho);
            Console.WriteLine("---------");


            List<string> cidades = new List<string>();
            cidades.Add("São Paulo");
            cidades.Add("Rio de Janeiro");
            cidades.Add("Santos");


            List<int> numeros = new List<int>();
            numeros.Add(10);
            numeros.Add(20);
            numeros.Add(16);

            foreach ( string c in cidades )
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("---------");

            foreach (int n in numeros)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("---------");

            // Fila - FIFO -> First In First Out
            Queue   <string> fila = new Queue<string>();
            fila.Enqueue("Processo 1");
            fila.Enqueue("Processo 2");
            fila.Enqueue("Processo 3");

            while (fila.Count > 0)
            {
                string item = fila.Dequeue();
                Console.WriteLine(item);
            }
            Console.WriteLine("---------");

            // Pilha - FILO -> First In Last Out
            Stack<string> pilha = new Stack<string>();
            pilha.Push("Processo 1");
            pilha.Push("Processo 2");
            pilha.Push("Processo 3");

            while (pilha.Count > 0)
            {
                string item2 = pilha.Pop();
                Console.WriteLine(item2);
            }
            Console.WriteLine("---------");


            // Dictionary - 

            Dictionary<string, string> dados = new Dictionary<string, string>();

            dados.Add("Nome", "José da Silva");
            dados.Add("RG", "23.234.1234");
            dados.Add("Telefone", "(11) 91234-4321");

            Console.WriteLine(dados["Nome"]);
            Console.WriteLine(dados["RG"]);
            Console.WriteLine(dados["Telefone"]);

            Console.WriteLine("---------");


            Console.ReadLine();
        }
    }
}
