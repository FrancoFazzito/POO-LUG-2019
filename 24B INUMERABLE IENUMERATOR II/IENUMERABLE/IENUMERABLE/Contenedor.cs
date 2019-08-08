using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IENUMERABLE
{
    class Contenedor : IEnumerable
    {
        private int[] valores = new int[10];

        public Contenedor()
        {
            //RELLENO
            for (int i = 0; i < valores.Length; i++)
            { 
                valores[i] = i * i;
            }
        }

        //SE NECESITA DEFININIR EL GETENUMERATOR PARA IENUMERATOR DESDE IENUMERABLE
        //1 LO CONVOCA DESDE AQUI
        IEnumerator IEnumerable.GetEnumerator()
        {
            //OBTENIENDO EL ENUMERATOR
            //    INSTANCIAMOS EL ENUMERADOR Y LO REGRESAMOS
            return (new ContenedorEnum(valores));
            //ENUM ME DA EL VALOR DE LOS ELEMENTOS ENUMERANDOLOS
        }

        //el foreach necesita del inumerable e inumerator 
        //para implementar el ienumerator necesitamos get numerator
        //lo conseguimos desde ienumerable.getenumerator()
        //returnando los valores para saber que enumerar y a traves de ienumerable podemos enviar
        //los datos a enumerar atraves de next current y reset
    }
    class ContenedorEnum: IEnumerator
    {
        public int[] arreglo;
        private int posicion = -1;

        public ContenedorEnum(int[] arreglo)
        {
            //al contenenedor del enum le llega el arreglo a enumerar
            this.arreglo = arreglo;
        }

        public bool MoveNext()
        {
            //se busca el siguiente
            posicion++;
            if(posicion < arreglo.Length)
            {
                //SI ES TRUE OBTIENE EL VALOR
                return true;
            }
            else
            {
                //SINO LE DICE STOP
                return false;
            }
        }

        public void Reset()
        {
            posicion = -1;
        }
        public object Current
        {
            get
            {
                //SI ES TRUE ENVIA EL ELEMENTO
                return arreglo[posicion];
            }
        }

    }
}
