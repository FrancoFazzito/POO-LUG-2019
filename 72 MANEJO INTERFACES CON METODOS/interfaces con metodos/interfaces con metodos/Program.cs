using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces_con_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*arreglo interfaz*/
            IElectronico[] electronicos = { new tele("JVC"), new radio("daiutsu"), new tele("ASUS") };
            /*se permite hacer un arreglo de los comunes a ielectronico*/
            

            foreach (IElectronico implementados in electronicos)
            {
                Console.WriteLine(implementados); /*ARREGLO POLIMORFICO*/
            }

            Console.WriteLine("*---*");

            tele tele = new tele("sharpey");
            radio radio = new radio("stanley");
            muestra(tele);
            muestra(radio);
            Console.WriteLine("*---*");

            IElectronico electronico = null;
            electronico = CrearAparato();
            electronico.encender(false);
            Console.WriteLine(electronico); /*to muestra comun podriamos agregar*/
            Console.ReadKey();
        }
        static void muestra(IElectronico electronico)
        {
            electronico.encender(true);
            /*codigo comun a todos las clases electronicos*/
            if (electronico is IElectronico)
            {
                Console.WriteLine("es electrico");
            }
            if (electronico is radio)
            {
                Console.WriteLine("es una radio tambien");
            }
            if (electronico is tele)
            {
                Console.WriteLine("es una tele tambien");
            }
        }
        static IElectronico CrearAparato()
        {
            /*en vez de llamar a return radio o tele puedo regresar un Ielectronico*/
            //IElectronico aparato = null;
            //aparato = new tele("tele polimorfica");
            //return aparato;
            IElectronico aparato = null;
            aparato = new radio("radio polimorfica");
            return aparato;
        }
    }
}
