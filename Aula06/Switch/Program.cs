using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hora = DateTime.Now.Hour;
            string mensagem = string.Empty;

            switch (hora)
            {
                case 10:
                case 15:
                    mensagem = "Hora do Intervalo";
                    break;
                case 12:
                    mensagem = "Hora do Almoço";
                    break;
                case 20:
                    mensagem = "Hora da Janta";
                    break;
                case 22:
                    mensagem = "Boa Noite!!";
                    break;
                default:
                    mensagem = string.Empty;
                    break;
            }
            Console.WriteLine(mensagem);
            Console.ReadLine();
        }
    }
}
