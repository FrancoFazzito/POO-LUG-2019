using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobrecargaoperadoresbinarios
{
    class Imaginario
    {
        //operadores binarios que serian el mas el menos el por y el dividendo
        private double entero;
        private double imaginarioo;

        public Imaginario(double entero, double imaginarioo)
        {
            this.entero = entero;
            this.imaginarioo = imaginarioo;
        }

        public double Entero

        { get { return entero; } set { entero = value; } }

        public double Imaginarioo

        { get { return imaginarioo; } set { imaginarioo = value; } }

        public override string ToString()
        {
            string retorno = "";
            if (imaginarioo < 0)
            {
                retorno = string.Format("{0} {1}i", entero, imaginarioo);
            }
            else
            {
                retorno = string.Format("{0} + {1}i", entero, imaginarioo);
            }
            return retorno;
        }

        //STATIC PARA NO INICIALIZAR SEGUIDO DEL TIPO DE RETORNO (EN ESTE CASO IMAGINARIO) Y OPERATOR LUEGO DEL SIGNO
        public static Imaginario operator +(Imaginario I1, Imaginario I2)
        {
            double re = 0;
            double ri = 0;

            re = I1.Entero + I2.Entero;
            ri = I1.Imaginarioo + I2.Imaginarioo;

            Imaginario imaginario = new Imaginario(ri, re);

            return imaginario;
        }

        public static Imaginario operator ++(Imaginario I1)
        {
            Imaginario imaginario = new Imaginario(I1.entero + 1, I1.imaginarioo + 1);

            return imaginario;
        }
    }
}
