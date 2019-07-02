using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class CalculadoraDeSalario
    {
        public double calcula(Funcionario funcionario)
        {
            return funcionario.Cargo.Regra.Calcula(funcionario);
            
        }

       

      
    }
}
