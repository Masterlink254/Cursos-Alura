using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMensagens
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IMensagem mensagem = new MensagemAdministrativa("victor");
            IEnviador enviador = new MensagemPorEmail();
            mensagem.Enviador = enviador;

            mensagem.Envia();

            IEnviador enviadorsms = new MensagemPorSMS();
            IMensagem mensagemsms = new MensagemCliente("mauricio");
            mensagemsms.Enviador = enviadorsms;

            mensagemsms.Envia();
        }
    }
}
