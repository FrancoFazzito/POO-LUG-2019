using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_REQUERIDO_2
{
    class Universidad
    {
        #region var
        private List<Alumno> alumnos;
        public event EventHandler eventoPromedio;

        public Universidad()
        {
            this.alumnos = new List<Alumno>();
        }
        #endregion

        #region crud Alumno

        #region create
        public void AddAlumno(int legajo = 0, string nombre = "", string apellido = "")
        {
            bool verificarLinq = existeLegajo(legajo);
            if (nombre != "" && apellido != "" && verificarLinq)
            {
                Alumno nuevoAlumno = new Alumno(legajo, nombre, apellido);
                alumnos.Add(nuevoAlumno);
            }
        }
        #endregion

        #region delete
        public void DeleteAlumno(int legajoEliminar)
        {
            Alumno eliminarAlumno = getAlumno(legajoEliminar);
            if (!existeLegajo(legajoEliminar))
            {
                alumnos.Remove(eliminarAlumno);
            }
        }
        #endregion

        #region update
        public void modificarAlumno(int legajoModificar, int nuevoCodigo, string nuevoNombre, string nuevoApellido)
        {
            Alumno modificarAlumno = getAlumno(legajoModificar);
            if (!existeLegajo(legajoModificar))
            {
                modificarAlumno.modificar(nuevoCodigo, nuevoNombre, nuevoApellido);
            }
        }
        #endregion

        #endregion

        #region crud materias

        public void addMateriaEspecial(int legajoAlumno, int codigoMateria, string nombreMateria)
        {
            
            Alumno alumno = getAlumno(legajoAlumno);
            MateriaEspecializada materia = new MateriaEspecializada(codigoMateria, nombreMateria);
            alumno.AddMateria(materia);
        }

        public void addMateriaBasica(int legajoAlumno, int codigoMateria, string nombreMateria)
        {
            Alumno alumno = getAlumno(legajoAlumno);
            MateriaBasica materia = new MateriaBasica(codigoMateria, nombreMateria);
            alumno.AddMateria(materia);
        }

        public void ModificarMateria(int legajoAlumno, int codigoMateria, int nuevoCodigo, string nuevoNombre, int nuevaNota)
        {
            Alumno alumno = getAlumno(legajoAlumno);
            alumno.ModificarMateria(codigoMateria, nuevoCodigo, nuevoNombre, nuevaNota);
        }

        public void DeleteMateria(int legajoAlumno, int codigoMateria)
        {
            Alumno alumno = getAlumno(legajoAlumno);
            alumno.DeleteMateria(codigoMateria);
        }

        #endregion

        #region modificar materia global
        public void modificarMateriaGlobal(int codigoMateria,int nuevoCodigo, string nuevaDenominacion)
        {
            modificarMateria(codigoMateria, nuevoCodigo, nuevaDenominacion);
        }

        private void modificarMateria(int codigoMateria, int nuevoCodigo, string nuevaDenominacion)
        {

            foreach (Materia materia in from alumno in alumnos let materia = alumno.GetMateria(codigoMateria) select materia)
            {
                materia.modificar(nuevoCodigo, nuevaDenominacion);
            }
        }
        #endregion

        #region asignacion nota
        public void asignarNota(int legajoAlumno, int codigoMateria, int nota)
        {
            Alumno alumno = getAlumno(legajoAlumno);
            alumno.asignarNota(codigoMateria, nota);
        }
        #endregion

        #region obtenerListas
        public List<Materia> getMateriasAprobadas(int codigoAlumno)
        {
            Alumno alumno = getAlumno(codigoAlumno);
            IEnumerable<Materia> aprobadas = alumno.GetListMaterias().Where(materia => materia.Nota >= 4);
            return aprobadas.ToList();
        }
        public List<Materia> getMateriasDesaprobadas(int codigoAlumno)
        {
            Alumno alumno = getAlumno(codigoAlumno);
            IEnumerable<Materia> desaprobadas = alumno.GetListMaterias().Where(materia => materia.Nota < 4 && materia.Nota > 0);
            return desaprobadas.ToList();
        }
        public List<Materia> getMateriasCursando(int codigoAlumno)
        {
            Alumno alumno = getAlumno(codigoAlumno);
            IEnumerable<Materia> cursando = alumno.GetListMaterias().Where(materia => materia.Nota == 0);
            return cursando.ToList();
        }

        public List<Alumno> GetAlumnos()
        {
            return this.alumnos;
        }
        #endregion

        #region metodos
        private bool existeLegajo(int legajo)
        {
            return getAlumno(legajo) == null;

        }
        private Alumno getAlumno(int legajo)
        {
            return alumnos.Find(alumno => alumno.Legajo == legajo);
        }
        #endregion

        #region comparer interfaces
        public void sortAsc()
        {
            alumnos.Sort(new CompareApellidoAsc());
        }
        public void sortDes()
        {
            alumnos.Sort(new CompareApellidoDesc());
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
        #endregion

        #region promedio y evento
        public double calcularPromedioGeneral(int legajoAlumno)
        {
            Alumno alumno = getAlumno(legajoAlumno);
            double promedioNotas = alumno.GetListMaterias().Where(materia => materia.Nota > 0).Average(materia => materia.Nota);
            if(promedioNotas >= 9)
            {
               string mensaje = string.Format("el alumno {0} obtuvo {1} siendo mayor a 9",alumno.Nombre,promedioNotas);
               eventoPromedio?.Invoke(mensaje, new EventArgs());
            }
            return promedioNotas;
        }
        public double calcularPromedioAprobadas(int legajoAlumno)
        {
           return getMateriasAprobadas(legajoAlumno).Average(materia => materia.Nota);
        }
        #endregion
    }
}
