using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinamyc
{
    class claseConDynamic
    {
        private dynamic atributo;

        public dynamic propiedad
        {
            get
            {
                return atributo;
            }
            set
            {
                atributo = value;
            }
        }
        public dynamic Recibe(dynamic parametro)
        {
            if (parametro == 5)
            { 
                Console.WriteLine("recibi {0}", parametro);
            return 5;
            }
            else
            {
                return "juan;";

            }
        }
    }
}
