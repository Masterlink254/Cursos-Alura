using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestimentoSolution.Investimentos
{
    class Arrojado : Investimento
    {
        bool escolhido = new Random().Next(101) > 20;

        private Random random;

        public Arrojado()
        {
            this.random = new Random();
        }
        public double Calcula(Orcamento conta)
        {
            int chute = random.Next(10);
            if (chute >= 0 && chute <= 1) return conta.Valor * 0.5;
            else if (chute >= 2 && chute <= 4) return conta.Valor * 0.3;
            else return conta.Valor * 0.006;
        }
    }
}
