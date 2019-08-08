using System.Collections.Generic;

namespace TP_1_S_PUNTO_2
{
    class Titular
    {
        #region INIT
        private string nombre;
        private string apellido;
        private double dni;
        private string tipoDNI;
        private List<Cuenta> cuentas;

        public Titular(string nombre, string apellido, double dni, string tipoDNI)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.tipoDNI = tipoDNI;
            this.cuentas = new List<Cuenta>();
        }

        public double DNI { get => dni; }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public string TipoDNI { get => tipoDNI; }
        public void Modificar(string nombre, string apellido, double dni, string tipoDNI)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.tipoDNI = tipoDNI;
        }
        #endregion

        #region MANEJO CUENTAS
        public void AddCuenta(Cuenta añadir)
        {
            bool contieneCuenta = cuentas.Contains(añadir);
            if (!contieneCuenta)
            {
                this.cuentas.Add(añadir);
            }
        }

        public void DeleteCuenta(Cuenta eliminar)
        {
            bool contieneCuenta = cuentas.Contains(eliminar);
            if (contieneCuenta)
            {
                this.cuentas.Remove(eliminar);
            }

        }
        public List<Cuenta> GetCuentas()
        {
            return this.cuentas;
        }
        #endregion
    }
}

