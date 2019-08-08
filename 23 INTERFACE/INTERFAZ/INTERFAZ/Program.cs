using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFAZ
{
    class Program
    {
        static void Main(string[] args)
        {
            //INTERFACES: INDICAR COMPORTAMIENTOS QUE PUEDE TENER UNA CLASE CREANDO UNA ABSTRACCION 
            //VEHICULO PUEDE MOVERSE ESTACIONAR Y GIRAR
            //LUEGO HACER UNA BICI O UNA MOTO O UN COCHE E IMPLEMENTAR VEHICULO YA QUE ES GENERAL
            //LAS INTEFACES HACEN ESAS ACCIONES

            //CALCULADORA TIENE QUE HACER UN CALCULO Y MOSTRAR EL RESULTADO
            //LUEGO SE PUEDE ESPECIFICAR EN LAS DISTINTAS OPERACIONES

            //Suma suma = new Suma();
            //suma.calcular(4.5, 5.6);
            //suma.mostrar();

            //LA INTERFAZ PUEDE SER POLIMORFICA
            IOperacion operacion = new Suma();
            operacion.calcular(5, 8);
            operacion.mostrar();
            //SIN IMPORTAR SI ESTA EN HERENCIA O NO, SE DA SOBRE CUALQUIERA QUE LA IMPLEMENTE
            operacion = new Resta();
            operacion.calcular(5, 8);
            operacion.mostrar();

            operacion = new Division();
            operacion.calcular(5, 8);
            operacion.mostrar();

            operacion = new Multiplicacion();
            operacion.calcular(5, 8);
            operacion.mostrar();

            // IOperacion operacion = new Suma();
            // switch //menu de usuario
            // operacion.calcular(5, 8); lo general
            // operacion.mostrar();
            Console.ReadKey();
        }
    }
}
