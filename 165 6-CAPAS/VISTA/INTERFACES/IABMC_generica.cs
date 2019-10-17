using System.Collections.Generic;

namespace INTERFACES
{
    public interface IABMC_generica<T>
    {
        void Alta(T value);
        void Baja(T value);
        void Modificacion(T value);
        List<T> Consultar();
        void ConsultarFiltro(T value);
    }

}
