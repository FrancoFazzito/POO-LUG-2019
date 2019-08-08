using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_REQUERIDO_2
{
    class Alumno
    {
        #region vars y init
        private int legajo;
        private string nombre;
        private string apellido;

        private List<Materia> materias;
        public Alumno(int legajo, string nombre, string apellido)
        {
            this.legajo = legajo;
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
            this.materias = new List<Materia>();
        }
        #endregion

        #region asignarNota
        public void asignarNota(int codigoMateria,int nota)
        {
            Materia asignar = GetMateria(codigoMateria);
            asignar.asignarNota(nota);
        }
        #endregion
        
        #region crud

        #region create
        public void AddMateria(Materia materiaAdd)
        {
            bool aprobada = GetAprobada(materiaAdd);
            bool especial = GetEspecial(materiaAdd);
            bool noHayEspecial = GetNoHayEspecial();
            if (!aprobada && noHayEspecial)
            {
                materias.Add(materiaAdd);
            }
            else if (!aprobada && !especial)
            {
                materias.Add(materiaAdd);
            }
        }

        private static bool GetAprobada(Materia materiaAdd)
        {
            return materiaAdd.Nota >= 4;
        }

        private static bool GetEspecial(Materia materiaAdd)
        {
            return materiaAdd is MateriaEspecializada;
        }

        private bool GetNoHayEspecial()
        {
            return materias.Count(busqueda => busqueda is MateriaEspecializada) < 1;
        }
        #endregion

        #region delete
        public void DeleteMateria(int materiaCodigo)
        {
            Materia materiaDelete = GetMateria(materiaCodigo);
            if (exist(materiaDelete))
            {
                materias.Remove(materiaDelete);
            }
        }
        #endregion

        #region update
        public void ModificarMateria(int materiaCodigo, int nuevoCodigo, string nuevaDenominacion,  int nota)
        {
            Materia materiaModificar = GetMateria(materiaCodigo);
            cambiarValores(nuevaDenominacion, nuevoCodigo, nota, materiaModificar);
        }

        private static void cambiarValores(string nuevaDenominacion, int nuevoCodigo, int nota, Materia materiaModificar)
        {
            materiaModificar.modificar(nuevoCodigo, nuevaDenominacion);
            materiaModificar.asignarNota(nota);
        }
        #endregion

        #region metodos
        private bool exist(Materia busqueda)
        {
            return materias.Contains(busqueda);
        }

        public Materia GetMateria(int materiaCodigo)
        {
            return materias.Find(materia => materia.Codigo == materiaCodigo);
        }

        public List<Materia> GetListMaterias()
        {
            return this.materias;
        }

        #endregion

        #endregion

        #region props
        public int Legajo { get => legajo; }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public void modificar(int legajo,string nombre, string apellido)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion

        #region override
        public override string ToString()
        {
            return string.Format("el nombre es {0} y su apellido es {1} con legajo {2}",this.nombre,this.apellido,this.legajo);
        }
        #endregion
    }
}
