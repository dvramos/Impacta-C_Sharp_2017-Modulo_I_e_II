using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManiulacaoDeTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Environment
            string pasta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string arquivo = "teste.txt";
            string path = Path.Combine(pasta, arquivo);

           //Escrendo em um arquivo
            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine("Escrevendo no arquivo de texto...");
            writer.WriteLine("Outra linha...");
            writer.Close();

            //Lendo um arquivo
            StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                string linha = reader.ReadLine();
                Console.WriteLine(linha);
                
            }

            Console.ReadLine();

        }
    }
}
