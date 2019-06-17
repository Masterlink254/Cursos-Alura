using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestimentoSolution.Investimentos
{
    class Arrojado : Investimento
    {
        bool escolhido = new Random().Next(101) > 50;

        public double Calcula(Orcamento orcamento)
        {

        }
}
