namespace _162_ADO_DATA_ADAPTER
{
    class Telefono
    {
        #region var
        private int id;
        private string numero;
        #endregion

        #region init
        public Telefono(int id, string numero)
        {
            this.id = id;
            this.numero = numero;
        }
        #endregion

        #region props
        public int Id { get => id; set => id = value; }
        public string Numero { get => numero; set => numero = value; }
        #endregion

        #region ToString
        public override string ToString()
        {
            return $"[{this.id}] {this.numero}";
        }
        #endregion
    }
}