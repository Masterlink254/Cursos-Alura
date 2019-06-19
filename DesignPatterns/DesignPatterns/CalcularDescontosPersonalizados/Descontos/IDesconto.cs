using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularDescontosPersonalizados.Descontos
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        Desconto Proximo { private get; set; }
    }
}
