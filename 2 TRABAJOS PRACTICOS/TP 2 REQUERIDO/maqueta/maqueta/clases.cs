using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maqueta
{
    class Universidad
    {
        private List<Alumno> alumnos;

        internal List<Alumno> Alumnos { get => alumnos; set => alumnos = value; }

        public Universidad()
        {
            this.alumnos = new List<Alumno>();
        }
        public void sortAsc()
        {
            alumnos.Sort(new CompareApellidoAsc());
        }
        public void sortDes()
        {
            alumnos.Sort(new CompareApellidoDesc());
        }
        public void AddAlumno(int legajo, string nombre, string apellido)
        {
            Alumno alumno = new Alumno(legajo, nombre, apellido);
            bool existeAlumno = alumnos.Exists(a => a.Legajo == legajo);
            if (!existeAlumno)
            {
                alumnos.Add(alumno);
            }
            
        }
        class CompareApellidoAsc : IComparer<Alumno>
        {
            public int Compare(Alumno x, Alumno y)
            {
                return x.Apellido.CompareTo(y.Apellido);
            }
        }

        class CompareApellidoDesc : IComparer<Alumno>
        {
            public int Compare(Alumno x, Alumno y)
            {
                return -1 * x.Apellido.CompareTo(y.Apellido);
            }
        }

    }

    class Alumno
    {
        #region Var and Init
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

        #region ABM
        public void AddMateria(Materia add)
        {
            bool especial = IsEspecial(add);
            bool aprobada = IsAprobada(add);
            bool haveEspecial = GetCountEspeciales() < 1;

            if (!aprobada && haveEspecial)
            {
                materias.Add(add);
            }
            else if (!aprobada && !especial)
            {
                materias.Add(add);
            }

        }

        private static bool IsAprobada(Materia add)
        {
            return add.getNota() > 4;
        }

        public void DeleteMateria(int materiaCodigo)
        {
            Materia materiaToRemove = getMateria(materiaCodigo);
            if (verificarMateria(materiaToRemove))
            {
                materias.Remove(materiaToRemove);
            } 
        }

        public void ModifyMateria(int codigo, string denominacion, int newCodigo)
        {
            Materia materiaToModify = getMateria(codigo);
            if (verificarMateria(materiaToModify))
            {
                materiaToModify.modificar(newCodigo, denominacion);
            }
            
        }
        #endregion

        #region GetMethods
        private bool IsEspecial(Materia materiaToAdd)
        {
            return materiaToAdd is MateriasEspecializada;
        }

        private int GetCountEspeciales()
        {
            return materias.Count(busqueda => busqueda is MateriasEspecializada);
        }

        private Materia getMateria(int materiaCodigo)
        {
            return materias.Find(Busqueda => Busqueda.Codigo == materiaCodigo);
        }
        private static bool verificarMateria(Materia materiaToRemove)
        {
            return materiaToRemove != null;
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return string.Format("el alumno {0} con nombre {1} y apellido {2} y cursando {3}", this.legajo, this.nombre, this.apellido, GetNamesMaterias());
        }

        private string GetNamesMaterias()
        {
            string listadoNombres = "  ";
            foreach (var materiaIterada in materias)
            {
                listadoNombres = listadoNombres + materiaIterada.Denominacion + ",";
            }
            listadoNombres = listadoNombres.Remove(listadoNombres.Length - 1);

            return listadoNombres;
        }

        #endregion

        #region props
        public int Legajo { get => legajo; }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }
        public List<Materia> Materias { get => materias; }

        #endregion
    }
    abstract class Materia
    {
        #region Var and Init
        private int codigo; 
        private string denominacion;
        private int nota;
        protected Materia(int codigo, string denominacion)
        {
            this.codigo = codigo;
            this.denominacion = denominacion ?? throw new ArgumentNullException(nameof(denominacion));
            this.nota = 0;
        }
        #endregion

        #region metodosNota
        public virtual void AsignarNota(int notaToAsign)
        {
            if(notaToAsign < 10)
            this.nota = notaToAsign;
        }
        public virtual int getNota()
        {
            return this.nota;
        }
        #endregion

        #region props
        public int Codigo { get => codigo;  }
        public string Denominacion { get => denominacion;  }

        public virtual void modificar(int codigo, string denominacion)
        {
            this.codigo = codigo;
            this.denominacion = denominacion;
        }
        #endregion
    }

    class MateriaBasica : Materia
    {
        public MateriaBasica(int codigo, string denominacion) : base(codigo, denominacion)
        {
        }   
    }

    class MateriasEspecializada : Materia
    {
        #region Var and Init
        private int virtud;
        private bool notaMaxima;
        public MateriasEspecializada(int codigo, string denominacion) : base(codigo, denominacion)
        {
            virtud = 0;
            notaMaxima = false;
        }
        #endregion

        #region props
        public int Virtud { get => virtud;  }
        public bool NotaMaxima { get => notaMaxima;  }

        public override void AsignarNota(int notaToAsign)
        {
            if(notaToAsign >= 6 && notaToAsign <= 9)
            {
                virtud++;
            }
            else if(notaToAsign == 10)
            {
                notaMaxima = true;
            }
            base.AsignarNota(notaToAsign);
        }
        #endregion
    }
}
