using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACES
{
    public interface IABM<T>
    {
        void Alta(T objetoAlta);
        void Modificacion(T objetoAlta);
        void Baja(T objetoAlta);
        void ObtenerTodos();
        void ObtenerDesdeHasta(T objetoDesde,T objetoHasta);
    }

    public interface IABM
    {
        void Alta();
        void Modificacion();
        void Baja();
        void ObtenerTodos();
        void ObtenerDesdeHasta();

    }
}
