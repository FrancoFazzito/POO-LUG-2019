namespace _162_ADO_DATA_ADAPTER
{
    class Alumno
    {
        #region var
        private int id;
        private string nombre;
        private string apellido;
        #endregion

        #region init
        public Alumno(int id, string nombre, string apellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion

        #region props
        public int Id { get => id; }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        #endregion

        #region ToString
        public override string ToString()
        {
            return $"[{this.id}]: {this.nombre} {this.apellido}";
        }
        #endregion
    }
}
