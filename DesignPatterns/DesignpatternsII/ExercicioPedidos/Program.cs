using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido1 = new Pedido("Mauricio", 150.0);
            Pedido pedido2 = new Pedido("Marcelo", 250.0);

            FilaDeTrabalho fila = new FilaDeTrabalho();

            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));
            fila.Adiciona(new FinalizaPedido(pedido1));

            fila.Processa();
        }
    }
}
