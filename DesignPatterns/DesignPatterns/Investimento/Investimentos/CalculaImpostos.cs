using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestimentoSolution.Investimentos
{
    class CalculaImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Investimento investimento)
        {
            double valor = investimento.Calcula(orcamento);
            
            Console.WriteLine(valor);
        }
    }
}
