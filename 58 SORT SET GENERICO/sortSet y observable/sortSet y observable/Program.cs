using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortSet_y_observable
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Coordenadas> coordenadas = new SortedSet<Coordenadas>();
            coordenadas.Add(new Coordenadas(1.2, 10));
            coordenadas.Add(new Coordenadas(1.0, 10));
            coordenadas.Add(new Coordenadas(1.5, 10));
            coordenadas.Add(new Coordenadas(1.8, 10));
            coordenadas.Add(new Coordenadas(1.9, 10));
            coordenadas.Add(new Coordenadas(0.5, 10));

            foreach (Coordenadas item in coordenadas)
            {
                Console.Write(item + " - " );
            }
            /*adcionar un handler y que se ejecute con cada cambio en la coleccion*/
            ObservableCollection<Coordenadas> Puntos = new ObservableCollection<Coordenadas>()
            { new Coordenadas(5.2, 10), new Coordenadas(3.2, 10) };

            Puntos.Add(new Coordenadas(15.4, 45));
            Console.ReadKey();
        }

        public static void Puntos_CollectionChanged(object sender, 
            System.Collections.Specialized.NotifyCollectionChangedAction paramE)
        {
            Console.WriteLine("el evento es {0}", paramE);
            if (System.Collections.Specialized.NotifyCollectionChangedAction.Remove == paramE)
            {
                Console.WriteLine("++");
            }

            if (System.Collections.Specialized.NotifyCollectionChangedAction.Add == paramE)
            {
                Console.WriteLine("--");
            }
            
        }
    }
}
