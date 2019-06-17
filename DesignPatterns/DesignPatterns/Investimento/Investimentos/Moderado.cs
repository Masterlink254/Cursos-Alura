using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestimentoSolution.Investimentos
{
    class Moderado : Investimento
    {
        bool escolhido = new Random().Next(101) > 50;

        public double Calcula(Orcamento orcamento)
        {
            if (escolhido == true)
            {
                return orcamento.Valor * 2.05;
            } else
                return orcamento.Valor * 0.07;
        }
    }
}
