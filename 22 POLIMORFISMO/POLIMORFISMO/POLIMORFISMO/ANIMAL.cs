using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIMORFISMO
{
    class ANIMAL
    {
        private string nombre;

        public string Nombre
        { get { return nombre; } set { nombre = value; } }

        //PENSARSE DE LA MANERA MAS GENERAL POSIBLE
        public virtual void moverse()
        {
            Console.WriteLine("el animal se mueve");
        }

        //TODOS TIENE NOMBRE PERO CADA UNO SE MUEVE DIFERENTE LAS AVES VUELAN PERO EL PEZ NADA
        //CARACTERISTICA COMUN NOMBRE Y MOVER, DIFIEREN EN COMO HACIENDO CON VIRTUAL
    }
}
