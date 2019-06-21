using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
    class ISS : Imposto
    {
        public ISS(Imposto outroImposto) : base(outroImposto) { }

        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
        }

        private double CalculoDoOutroImposto(orcamento)
        {
            return OutroImposto.Calcula(orcamento);
        }
    }
}
