using CalcularDescontosPersonalizados.Descontos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularDescontosPersonalizados
{
    public class Program
    {
        static void Main(string[] args)
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500.0);
            orcamento.AdicionaItem(new Item("CANETA", 250.0));
            orcamento.AdicionaItem(new Item("LAPIS", 250.0));

            double desconto = calculador.Calcula(orcamento);

            Console.WriteLine(desconto);
        }
    }
}
