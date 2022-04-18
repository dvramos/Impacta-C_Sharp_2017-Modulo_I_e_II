using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeMetodos
{
    public class Impostos
    {
        // Método Construtor
        private decimal _porcentagemIndividual;

        public Impostos()
        {
            _porcentagemIndividual = 0.01m;
        }
        public Impostos(decimal porcentagemIndividual)
        {
            _porcentagemIndividual = porcentagemIndividual;
        }


        public decimal CalcularISS(string estado, decimal valorServico, bool empresaIndividual)
        {
            decimal porcentagem;
            if (empresaIndividual)
            {
                porcentagem = 0.01m;
            }
            else
            {

                if (estado == "SP")
                {
                    porcentagem = 0.06m;
                }
                else
                {
                    porcentagem = 0.05m;
                }
            }
            decimal valorImposto = valorServico * porcentagem;

            return valorImposto;
        }

            /*Modificador de Acesso (public)
            retorno é um valor (decimal)
            Nome do método é CalcularISS
            Parametros: estado(string), valor(decimal)
             */

            public decimal CalcularISS(string estado, decimal valorServico)
        {
            decimal porcentagem;
            if (estado == "SP")
            {
                porcentagem = 0.06m;
            }
            else
            {
                porcentagem = 0.05m;
            }

            decimal valorImposto = valorServico * porcentagem;

            return valorImposto;
        }
    }
}
