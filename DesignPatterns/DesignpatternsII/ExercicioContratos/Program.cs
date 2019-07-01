using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioContratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Historico historico = new Historico();

            Contrato contrato = new Contrato(DateTime.Now, "Mauricio", TipoContrato.Novo);
            historico.Adiciona(contrato.SalvaEstado());
            Console.WriteLine(contrato.Tipo);

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());
            Console.WriteLine(contrato.Tipo);


            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());
            Console.WriteLine(contrato.Tipo);


            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());
            Console.WriteLine(contrato.Tipo);

            Console.WriteLine(historico.Pega(2).Contrato.Tipo);

            Console.WriteLine(historico.Pega(0).Contrato.Tipo);

            Console.WriteLine(historico.Pega(3).Contrato.Tipo);

        }
    }
}
