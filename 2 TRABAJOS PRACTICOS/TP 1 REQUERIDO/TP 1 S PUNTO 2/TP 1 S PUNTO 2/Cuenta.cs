using System.Collections.Generic;

namespace TP_1_S_PUNTO_2
{
    #region INIT

    abstract class Cuenta
    {
        private double dineroCuenta;
        private int id;
        private List<Titular> titulares;

        public int Id { get => id; set => id = value; }
        public double DineroCuenta { get => dineroCuenta; set => dineroCuenta = value; }

        protected Cuenta(double dineroCuenta, int id)
        {
            this.dineroCuenta = dineroCuenta;
            this.id = id;
            titulares = new List<Titular>();
        }

        #region metodos cambio dinero
        public virtual bool Extraccion(double cantidadDinero)
        {
            if (cantidadDinero <= dineroCuenta)
            {
                dineroCuenta -= cantidadDinero;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Deposito(double cantidadDinero)
        {
            dineroCuenta += cantidadDinero;
        }
        #endregion

        #region modificar
        public void Modificar(double cantidadDinero, int id)
        {
            dineroCuenta = cantidadDinero;
            this.id = id;
        }
        #endregion

        #region titulares
        public List<Titular> GetTitulares()
        {
            return titulares;
        }

        public void AddTitular(Titular añadir)
        {
            bool contieneTitular = titulares.Contains(añadir);
            if (!contieneTitular)
            {
                titulares.Add(añadir);
            }
        }

        public void DeleteTitular(Titular eliminar)
        {
            bool contieneTitular = titulares.Contains(eliminar);
            if (contieneTitular)
            {
                titulares.Remove(eliminar);
            }
        }
        #endregion
    }

    #endregion

    #region caja ahorro
    class cajaAhorro : Cuenta
    {
        public cajaAhorro(double dineroCuenta, int id) : base(dineroCuenta, id)
        {
        }
    }
    #endregion

    #region cuentaCorriente
    class CuentaCorriente : Cuenta
    {
        private double dineroDescubierto;
        public CuentaCorriente(double dineroDescubierto, double dineroCuenta, int id) : base(dineroCuenta, id)
        {
            this.dineroDescubierto = dineroDescubierto;
        }

        public double DineroDescubierto { get => dineroDescubierto; set => dineroDescubierto = value; }

        public override bool Extraccion(double cantidadDinero)
        {
            double dineroTotal = DineroCuenta + dineroDescubierto;
            if (cantidadDinero <= dineroTotal)
            {
                DineroCuenta -= cantidadDinero;
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Modificar(double dineroDescubierto, double dineroCuenta, int id)
        {
            this.dineroDescubierto = dineroDescubierto;
            DineroCuenta = dineroCuenta;
            Id = id;
        }

    }
    #endregion
}
