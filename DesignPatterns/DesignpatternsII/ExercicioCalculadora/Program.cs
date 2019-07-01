using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Impressora impressora = new Impressora();
           

            IExpressao esquerda = new Subtracao(new Numero(10), new Numero(5));
            IExpressao direita = new Soma(new Numero(2), new Numero(10));

            IExpressao conta = new Soma(esquerda, direita);

            int resultado = conta.Avalia();
            Console.WriteLine(resultado);
            conta.Aceita(impressora);
        }
    }
}
