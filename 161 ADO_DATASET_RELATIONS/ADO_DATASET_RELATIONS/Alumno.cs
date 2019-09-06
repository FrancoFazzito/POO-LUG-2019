using System;

namespace ADO_DATASET_RELATIONS
{
    public class Alumno
    {
        #region variables
        private string legajo;
        private string nombre;
        private string apellido;
        #endregion

        #region props
        //props
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        #endregion

        #region ctor
        //ctor
        public Alumno(string legajo, string nombre, string apellido)
        {
            this.legajo = legajo;
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
        }
        #endregion

        #region metodos
        /// <summary>
        /// permite obtener un string de datos con el id,nombre,apellido del alumno
        /// </summary>
        public override string ToString()
        {
            return $"ID {this.legajo}  con nombre {this.nombre} y apellido {this.apellido}";
        }

        /// <summary>
        /// permite obtener un array de datos 
        /// donde la posicion[0] es id, la posicion[1] es nombre, la posicion[2] es apellido
        /// </summary>
        public object[] GetDatosArray()
        {
            object[] data = new object[]
            {
                this.legajo,
                this.nombre,
                this.apellido
            };
            return data;
        }
        #endregion
    }
}
