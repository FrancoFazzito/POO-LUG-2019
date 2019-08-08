using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro
{
    class Caldera
    {
        private int temperaturaMAX = 120;
        private int temperatura = 0;
        private string marca = "";
        private bool funciona = true;

        public Caldera(int temperatura, string marca)
        {
            this.temperatura = temperatura;
            this.marca = marca;
            //this.marca = marca ?? throw new ArgumentNullException(nameof(marca));
        }

        public int Temperatura { get => temperatura; set => temperatura = value; }
        public string Marca { get => marca; set => marca = value; }
        public bool Funciona { get => funciona; set => funciona = value; }


        public void Trabajar(int aumento)
        {
            if (!funciona)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("no funciona");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("funciona");
                temperatura += aumento;
                Console.WriteLine("funciona con {0}", temperatura);

                if (temperatura > temperaturaMAX)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("{0} supero la temp, tiene {1}", marca, temperatura);
                    temperatura = temperaturaMAX;
                    funciona = false;
                    calderaExepcion exepcion = new calderaExepcion("caldera hizo PUM", DateTime.Now, "mucha temp");

                    throw exepcion;
                    
                }
            }
        }
    }/*finaliza clase de la cual se hara su clase exception*/
    public class calderaExepcion : ApplicationException
    {
        /*tiene que ser publica*/
        /*herencia de clase apliacionexepcion*/

        private string mensaje = ""; /*por el to string*/
        private DateTime momemto;
        private string causa;

        public calderaExepcion(string mensaje, DateTime momemto, string causa)
        {
            this.mensaje = mensaje;
            this.momemto = momemto;
            this.causa = causa ?? throw new ArgumentNullException(nameof(causa)); /*si el argumento es nulo*/
        }

        public DateTime Momemto { get => momemto; set => momemto = value; }
        public string Causa { get => causa; set => causa = value; }

        /*override a la propiedad exception.message*/
        public override string Message
        {
            get
            {
                return string.Format("mensaje fue {0}", mensaje);
            }
        }

        //public override string Source {
        // 
        //}
        public class calderaExepcion2 : ApplicationException
        {
            /*tiene que ser publica*/
            /*herencia de clase apliacionexepcion*/

            private string mensaje = ""; /*por el to string*/
            private DateTime momemto;
            private string causa;

            //public calderaExepcion(string mensaje , DateTime momemto, string causa)
            //{
            //    this.mensaje = mensaje;
            //    this.momemto = momemto;
            //    this.causa = causa ?? throw new ArgumentNullException(nameof(causa)); /*si el argumento es nulo*/
            //}

            public calderaExepcion2(string mensaje, DateTime momemto, string causa) : base(mensaje) /*recibimos el mensaje de herencia*/
            {
                this.momemto = momemto;
                this.causa = causa ?? throw new ArgumentNullException(nameof(causa)); /*si el argumento es nulo*/
            }

            public DateTime Momemto { get => momemto; set => momemto = value; }
            public string Causa { get => causa; set => causa = value; }

            /*override a la propiedad exception.message*/
            //public override string Message
            //{
            //    get
            //    {
            //        return string.Format("mensaje fue {0}", mensaje);
            //    }
            //}

            //public override string Source {
            // 
            //}

        }
    }

}
