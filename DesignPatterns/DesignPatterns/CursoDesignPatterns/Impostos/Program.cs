using CursoDesignPatterns.Impostos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iccc = new ICCC();
            Imposto iss = new ISS();
            Orcamento orcamento = new Orcamento(500.0);
            CalculadorDeImposto calculador = new CalculadorDeImposto();

            calculador.RealizaCalculo(orcamento, iss);

            calculador.RealizaCalculo(orcamento, iccc);

            Console.ReadKey();
        }
    }
}
