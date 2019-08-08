using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disposable
{
    class prueba : IDisposable
    {
        private int a;
        private bool UsoDispose;
        public prueba(int a)
        {
            this.a = a;
        }

        public int A { get => a; set => a = value; }

        public override string ToString()
        {
            return string.Format("el valor de a es {0}", a);
        }

        ~prueba()
        {
            Console.Beep(500, 400);
            Console.WriteLine("SI ES USA DISPOSE NO HACE FALTA EL DESTRUCTOR");
        }
        public void Dispose()
        {
            /*clase que lo tiene es close de los streams*/
            Console.WriteLine("estamos en dispose, aqui liberamos lo no administrado", a);
            /*EL OBJETO DE FINALIZAR LO NO ADMINISTRADO SE BORRA Y LUEGO EL DESTRUCTOR LO INVOCA DE VUELTA PUEDE DARLE ERROR*/
            GC.SuppressFinalize(this); /*se omita el destructor*/
        }

        //~prueba()
        //{

        //    limpieza();
        //}

        //public void Dispose()
        //{
        //    /*clase que lo tiene es close de los streams*/
        //    limpieza();
        //    /*EL OBJETO DE FINALIZAR LO NO ADMINISTRADO SE BORRA Y LUEGO EL DESTRUCTOR LO INVOCA DE VUELTA PUEDE DARLE ERROR*/
        //    GC.SuppressFinalize(this); /*se omita el destructor*/
        //}

        //public void limpieza()
        //{
        //    if (!UsoDispose)
        //    {
        //        Console.WriteLine("estamos en limpieza, aqui liberamos lo no administrado", a);
        //    }
        //    UsoDispose = true;

        //}
    }
}
