using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTRO_GENERICO
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(5);
            /*ingresa como object*/
            int r = 0;
            for (int i = 0; i < arrayList.Count; i++)
            {
                r = (int)arrayList[0];
                /*casteao a int*/
                /*uno necesita hacer de int a object y de object a int por lo cual doble trabajo*/
                Console.WriteLine(r);
            }

            List<int> valores = new List<int>();
            /*tendremos una lista de valores de int T representa al tipo pero si queremos hacer 
             *que trabaje con cualquier tipo osea en terminos de T*/

            valores.Add(76);
            valores.Add(611);
            valores.Add(58);
            valores.Add(44);
            valores.Add(3);

            for (int i = 0; i < valores.Count; i++)
            {
                /*NO HAY casteao a int MAYOR RENDIMIENTO*/
                r = valores[i];
                Console.WriteLine(r);
            }
            Console.WriteLine(valores.Contains<int>(5));
            Console.WriteLine(valores.Contains<int>(50));
            Console.WriteLine(valores.IndexOf(2));
            valores.Insert(2, 49);
            foreach (int item in valores)
            {
                Console.Write("-" + item);
               
            }
            Console.WriteLine();
            /*valor*/
            valores.Remove(5);
            /*indice*/
            valores.RemoveAt(2);
            valores.Reverse();

            foreach (int item in valores)
            {
                Console.Write("-" + item);
                
            }
            Console.WriteLine();
            valores.Sort();
            foreach (int item in valores)
            {
                Console.Write("-" + item);
                
            }
            Console.WriteLine();


            //CON CLASES
            List<Cordenadas> Listcordenadas = new List<Cordenadas>() { new Cordenadas(5.2,5.7) };

            Listcordenadas.Add(new Cordenadas(5.6, 6.8));
            Listcordenadas.Add(new Cordenadas(5.7, 6.9));
            Listcordenadas.Add(new Cordenadas(5.8, 7));

            /*para sort necesitamos icomparabale*/
            /*istcordenadas.Sort();*/

            foreach (Cordenadas item in Listcordenadas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("array");

            Cordenadas[] arrayPuntos = Listcordenadas.ToArray();

            for (int i = 0; i < arrayPuntos.Length; i++)
            {
                Console.WriteLine(arrayPuntos[i]);
            }

            Console.ReadKey();


        }
    }
}
