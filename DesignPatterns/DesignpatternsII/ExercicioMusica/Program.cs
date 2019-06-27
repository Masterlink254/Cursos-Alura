using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMusica
{
    class Program
    {
        static void Main(string[] args)
        {
            Piano piano = new Piano();
            
            NotasMusicais notas = new NotasMusicais();

            List<INota> doReMiFa = new List<INota>() {
            notas.Pega("do"),
            notas.Pega("re"),
            notas.Pega("mi"),
            notas.Pega("fa"),
            notas.Pega("fa"),
            notas.Pega("fa"),

            notas.Pega("do"),
            notas.Pega("re"),
            notas.Pega("do"),
            notas.Pega("re"),
            notas.Pega("re"),
            notas.Pega("re"),

            notas.Pega("do"),
            notas.Pega("sol"),
            notas.Pega("fa"),
            notas.Pega("mi"),
            notas.Pega("mi"),
            notas.Pega("mi"),

            notas.Pega("do"),
            notas.Pega("re"),
            notas.Pega("mi"),
            notas.Pega("fa"),
            notas.Pega("fa"),
            notas.Pega("fa")
            };
            piano.Toca(doReMiFa);
        }

    }
    
}
