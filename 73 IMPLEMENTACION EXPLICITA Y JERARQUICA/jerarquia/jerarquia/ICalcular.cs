using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jerarquia
{
    /*objeto que implementa calcular tiene que implementar mostrar*/
    interface ICalcular : IMostrar
    {
        int calculo(int a, int b);
    }
}
