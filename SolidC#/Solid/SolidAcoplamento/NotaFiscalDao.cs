using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidAcoplamento
{
    class NotaFiscalDao
    {
        public void Persiste(NotaFiscal nf)
        {
            Console.WriteLine("Persistindo nota");
        }
    }
}
