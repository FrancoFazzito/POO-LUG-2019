using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MICLASEcs
    {
        //AMBITO OBJETO
        //ESTOS DATOS SE PUEDEN VER EN TODA LA CLASE PERO NO FUERA DE ELLA
        private int b = 10;

        public void muestra()
        {
            //AMBITO LOCAL
            //CREAMOS UNA VARIABLE LOCAL EN EL METODO MUESTRA
            int m = 5;
            int b = 8;
            //MOSTRAR DATO LOCAL
            Console.WriteLine("m = {0}", m);

            //MOSTRAR DATO CLASS PROGRAM
            //NO SE PUEDE 
            //Console.WriteLine("A = {0}", a);
            //YA QUE El nombre 'a' no existe en el contexto actual   


            //MOSTRAR DATO CLASE
            Console.WriteLine("AMBITO LOCAL b = {0}", b);
            Console.WriteLine("AMBITO OBJETO this.b = {0}", this.b);
        }

        public void Multiplicador()
        {
            //int M = 7 se puede tener mismo nombre en distintos metodos
            //USO DEL DATO DE LA CLASE
            
            this.b = b * 10;

            //ESTA EN UN AMBITO LOCAL Y NO PUEDE USAR USADO EN OTRO METODO SOLO EXISATE EN EL METODO
            //m = m * 100;
            //YA QUE El nombre 'a' no existe en el contexto actual   
        }
    }
}
