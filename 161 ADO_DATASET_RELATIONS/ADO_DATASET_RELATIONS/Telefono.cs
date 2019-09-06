using System;

namespace ADO_DATASET_RELATIONS
{
    public class Telefono
    {
        #region variables
        private string numero;
        private int codigo;
        #endregion

        #region props
        //props
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        #endregion

        #region ctor
        //ctor
        public Telefono(string numero, int codigo)
        {
            this.numero = numero;
            this.codigo = codigo;
        }
        #endregion

        #region metodos
        public override string ToString()
        {
            return $"{codigo}: {numero}";
        }

        internal object[] getDatosArray(Alumno alumno)
        {
            return new object[] {  this.codigo, alumno.Legajo, this.numero };
        }
        #endregion
    }
}
