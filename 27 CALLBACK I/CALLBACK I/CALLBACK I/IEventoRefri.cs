using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALLBACK_I
{
    interface IEventoRefri
    {
        //EVENTO DEL REFRI CUANDO TENGA POCOS ALIMENTOS
        void EventReservasBajas(int Kilos);
    }
}
