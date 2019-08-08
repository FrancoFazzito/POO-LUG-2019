using System;
using System.Collections.Generic;

namespace TP_1_S_PUNTO_2
{
    class Banco
    {
        #region INIT
        private List<Titular> titulares;
        private List<Cuenta> cuentas;
        private List<cajaAhorro> cajasAhorro;
        private List<CuentaCorriente> cuentasCorriente;
        private const double DINERO_EVENTO = 1000;
        public Banco()
        {
            titulares = new List<Titular>();
            cuentas = new List<Cuenta>();
            cajasAhorro = new List<cajaAhorro>();
            cuentasCorriente = new List<CuentaCorriente>();
        }

        public event EventHandler DepositoEvent;
        public event EventHandler ImporteEvent;
        #endregion

        #region ABM TITULAR 
        public bool AñadirTitularr(string nombre , string apellido, double dni, string tipoDni)
        {
            if (NoExisteTitular(dni) && dni != 0)
            {
                Titular añadir = new Titular(nombre, apellido, dni, tipoDni);
                titulares.Add(añadir);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ModificarTitular(double dniOrigen, string nombre, string apellido, double dni, string tipoDni)
        {
            if (ExisteTitular(dniOrigen) && NoExisteTitular(dni))
            {
                Titular modificar = GetTitular(dniOrigen);
                modificar.Modificar(nombre, apellido, dni, tipoDni);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EliminarTitular(double dni)
        {
            if (ExisteTitular(dni))
            {
                Titular eliminar = GetTitular(dni);
                titulares.Remove(eliminar);
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region ABM CUENTA CORRIENTE

        public bool AñadirCuentaCorriente(double dineroDescubierto, double dineroCuenta, int id)
        {
            if (NoExisteCuenta(id) && id != 0)
            {
                CuentaCorriente añadirCuenta = new CuentaCorriente(dineroDescubierto, dineroCuenta, id);
                cuentas.Add(añadirCuenta);
                cuentasCorriente.Add(añadirCuenta);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ModificarCuentaCorriente(int idOrigen, double dineroDescubierto, double dineroCuenta, int id)
        {
            if (ExisteCuenta(idOrigen))
            {
                CuentaCorriente modificar = GetCuentaCorriente(idOrigen);
                modificar.Modificar(dineroDescubierto, dineroCuenta, id);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EliminarCuentaCorriente(int id)
        {
            if (ExisteCuenta(id))
            {
                CuentaCorriente eliminar = GetCuentaCorriente(id);
                cuentas.Remove(eliminar);
                cuentasCorriente.Remove(eliminar);
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region ABM CAJA AHORRO
        public bool AñadirCajaAhorro(double dineroCuenta, int id)
        {
            if (NoExisteCuenta(id) && id != 0)
            {
                cajaAhorro añadirCaja = new cajaAhorro(dineroCuenta, id);
                cajasAhorro.Add(añadirCaja);
                cuentas.Add(añadirCaja);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ModificarCajaAhorro(int idorigen, double dineroCuenta, int id)
        {
            if (ExisteCuenta(idorigen))
            {
                cajaAhorro modificarCaja = GetCajaAhorro(idorigen);
                modificarCaja.Modificar(dineroCuenta, id);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EliminarCajaAhorro(int id)
        {
            if (ExisteCuenta(id))
            {
                cajaAhorro eliminarCaja = GetCajaAhorro(id);
                cajasAhorro.Remove(eliminarCaja);
                cuentas.Remove(eliminarCaja);
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region MOVIMIENTOS CUENTAS 
        public bool ExtraccionCuentaCorriente(int id, double cantidadDinero)
        {
            if (ExisteCuenta(id))
            {
                CuentaCorriente ExtraccionCuenta = GetCuentaCorriente(id);
                bool resultado = ExtraccionCuenta.Extraccion(cantidadDinero);
                if (resultado)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public bool ExtraccionCajaAhorro(int id, double cantidadDinero)
        {
            if (ExisteCuenta(id))
            {
                cajaAhorro ExtraccionCaja = GetCajaAhorro(id);
                bool resultado = ExtraccionCaja.Extraccion(cantidadDinero);
                if (resultado)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public bool Depositar(int id, double cantidadDinero)
        {
            if (ExisteCuenta(id))
            {
                if (cantidadDinero >= DINERO_EVENTO)
                {
                    string mensaje = string.Format("el importe es {0}", cantidadDinero);
                    DepositoEvent?.Invoke(mensaje, new EventArgs());
                }
                Cuenta DepositarCuenta = GetCuenta(id);
                DepositarCuenta.Deposito(cantidadDinero);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TransferenciaCuentaCorriente(int idOrigen, double cantidadDinero, int idDestino)
        {
            if (ExisteCuenta(idOrigen) && ExisteCuenta(idDestino))
            {
                CuentaCorriente cuentaCorriente = GetCuentaCorriente(idOrigen);
                Cuenta cuenta = GetCuenta(idDestino);
                bool resultado = cuentaCorriente.Extraccion(cantidadDinero);
                if (resultado)
                {
                    if (cantidadDinero >= DINERO_EVENTO)
                    {
                        string mensaje = string.Format("el ID de la cuenta de origen es {0} y la cantidad de dinero es {1}", idOrigen, cantidadDinero);
                        ImporteEvent?.Invoke(mensaje, new EventArgs());
                    }
                    cuenta.Deposito(cantidadDinero);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
        public bool TransferenciaCajaAhorro(int idOrigen, double cantidadDinero, int idDestino)
        {
            if (ExisteCuenta(idOrigen) && ExisteCuenta(idDestino))
            {
                cajaAhorro cajaAhorro = GetCajaAhorro(idOrigen);
                Cuenta cuenta = GetCuenta(idDestino);
                bool resultado = cajaAhorro.Extraccion(cantidadDinero);
                if (resultado)
                {
                    if (cantidadDinero >= DINERO_EVENTO)
                    {
                        string mensaje = string.Format("el ID de la cuenta de origen es {0} y la cantidad de dinero es {1}", idOrigen,cantidadDinero);
                        ImporteEvent?.Invoke(mensaje, new EventArgs());
                    }
                    cuenta.Deposito(cantidadDinero);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
        #endregion

        #region MANEJO CUENTA-TITULAR
        public bool Añadir_Titular_Cuenta(int dni, int id)
        {
            if (ExisteTitular(dni) && ExisteCuenta(id))
            {
                Titular titular = GetTitular(dni);
                Cuenta cuenta = GetCuenta(id);
                titular.AddCuenta(cuenta);
                cuenta.AddTitular(titular);
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Eliminar_Titular_Cuenta(int dni, int id)
        {
            if (ExisteTitular(dni) && ExisteCuenta(id))
            {
                Titular titular = GetTitular(dni);
                Cuenta cuenta = GetCuenta(id);
                titular.DeleteCuenta(cuenta);
                cuenta.DeleteTitular(titular);
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region GET LIST
        public List<Titular> GetTitulares()
        {
            return titulares;
        }

        public List<Cuenta> GetCuentasDeTitulares(int index)
        {
            Titular titularBuscado = titulares[index];
            return titularBuscado.GetCuentas();
        }

        public List<Cuenta> GetCuentas()
        {
            return cuentas;
        }

        public List<CuentaCorriente> GetCuentaCorriente()
        {
            return cuentasCorriente;
        }
        public List<Titular> GetTitularesDeCuentas(int index)
        {
            Cuenta cuentaBusqueda = cuentas[index]; //uso de indexer de la lista
            return cuentaBusqueda.GetTitulares();
        }

        #endregion

        #region BUSQUEDA
        private Titular GetTitular(double dni)
        {
            Titular titularBuscado = titulares.Find(buscado => buscado.DNI == dni);
            return titularBuscado;
        }

        private Cuenta GetCuenta(int id)
        {
            Cuenta cuentaBuscada = cuentas.Find(buscada => buscada.Id == id);
            return cuentaBuscada;
        }

        private cajaAhorro GetCajaAhorro(int id)
        {
            cajaAhorro cajaBuscada = cajasAhorro.Find(buscada => buscada.Id == id);
            return cajaBuscada;
        }

        private CuentaCorriente GetCuentaCorriente(int id)
        {
            CuentaCorriente cuentaBuscada = cuentasCorriente.Find(buscada => buscada.Id == id);
            return cuentaBuscada;
        }

        private bool ExisteCuenta(int id)
        {
            Cuenta buscada = GetCuenta(id);
            if (buscada != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ExisteTitular(double dni)
        {
            Titular buscado = GetTitular(dni);
            if (buscado != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool NoExisteCuenta(int id)
        {
            Cuenta buscada = GetCuenta(id);
            if (buscada == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool NoExisteTitular(double dni)
        {
            Titular buscado = GetTitular(dni);
            if (buscado == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
