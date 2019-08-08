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
        public bool Funciona { get => Funciona1; set => Funciona1 = value; }
        public bool Funciona1 { get => funciona; set => funciona = value; }

        /*UNO*/
        //public void Trabajar(int aumento)
        //{
        //    if (!funciona)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Blue;
        //        Console.WriteLine("no funciona");
        //    }else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("funciona");
        //        temperatura += aumento;
        //        Console.WriteLine("funciona con {0}", temperatura);

        //        if(temperatura > temperaturaMAX)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Yellow;
        //            Console.WriteLine("{0} supero la temp, tiene {1}", marca, temperatura);
        //            temperatura = temperaturaMAX;
        //            funciona = false;
        //        }


        //    }
        //}

        /*DOS*/
        //public void Trabajar(int aumento)
        //{
        //    if (!funciona)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Blue;
        //        Console.WriteLine("no funciona");
        //    }
        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("funciona");
        //        temperatura += aumento;
        //        Console.WriteLine("funciona con {0}", temperatura);

        //        if (temperatura > temperaturaMAX)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Yellow;
        //            Console.WriteLine("{0} supero la temp, tiene {1}", marca, temperatura);
        //            temperatura = temperaturaMAX;
        //            funciona = false;
                            /*lanzamos exception*/
        //            throw new Exception(string.Format("caldera se sobrecalienta"));
        //        }


        //    }
        //}

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

                    Exception excepcion = new Exception(string.Format("caldera se sobrecalienta"));
                    excepcion.HelpLink = "https://stackoverflow.com/";
                    excepcion.Data.Add("momento:", string.Format("ocurrio en {0}", DateTime.Now)); /*momento es key y su valor es la hora*/
                    excepcion.Data.Add("temperatura:", string.Format("tenia grados {0}", temperatura));
                    excepcion.Data.Add("incremento:", string.Format("aumento un total de {0}", aumento));
                    throw excepcion;
                    
                }


            }
        }
    }
}
