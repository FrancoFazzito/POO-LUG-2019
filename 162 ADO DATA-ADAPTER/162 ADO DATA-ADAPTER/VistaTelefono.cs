namespace _162_ADO_DATA_ADAPTER
{
    class VistaTelefono
    {
        #region var
        private int id;
        private int idAlumno;
        private string numero;
        #endregion

        #region init
        public VistaTelefono(int id, string numero, int idAlumno)
        {
            this.id = id;
            this.numero = numero;
            this.idAlumno = idAlumno;
        }
        #endregion

        #region props
        public int Id { get => id; set => id = value; }
        public string Numero { get => numero; set => numero = value; }
        public int IdAlumno { get => idAlumno; set => idAlumno = value; }
        #endregion

    }
}
