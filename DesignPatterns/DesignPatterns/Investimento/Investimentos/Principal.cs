using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestimentoSolution.Investimentos
{
    class Principal
    {
        static void Main(string[] args)
        {
            Investimento moderado = new Moderado();
            Investimento conservador = new Conservador();
            Orcamento orcamento = new Orcamento(500);
            CalculaImpostos calculador = new CalculaImpostos();

            calculador.RealizaCalculo(orcamento, moderado);

            calculador.RealizaCalculo(orcamento, conservador);


            Console.ReadKey();
        }
    }
}
