using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Conceitos
{
    public class Produto
    {
        // Campos (Fields)
        private string nome;
        private decimal preco;


        public string Fornecedor { get; set; }


        //Propriedades
        public decimal Preco
        {
            get
            {
                return preco;
            }

            set
            {
                if (value >= 0)
                {
                    preco = value;
                }
                else
                {
                    preco = 0;
                }
                
            }
        }

        //Propriedades
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                if (value.Length < 3)
                {
                    nome = "!Erro...";
                }
                else
                {
                    nome = value;
                }
            }
        }
    }
}
