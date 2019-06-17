using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestimentoSolution.Investimentos
{
    class Conservador : Investimento
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.08;
        }
    }
}
