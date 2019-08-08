using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_REQUERIDO_2
{
    abstract class Materia
    {
        #region var y init
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

        #region props
        public int Codigo { get => codigo; }
        public string Denominacion { get => denominacion; }
        public int Nota { get => nota;  }

        public virtual void asignarNota(int nota)
        {
            if(nota < 10)
            {
                this.nota = nota;
            }
        }
        public void modificar(int codigo, string denominacion)
        {
            this.codigo = codigo;
            this.denominacion = denominacion;
        }
        #endregion
    }

    class MateriaBasica : Materia
    {
        #region init
        public MateriaBasica(int codigo, string denominacion) : base(codigo, denominacion)
        {

        }
        #endregion
    }

    class MateriaEspecializada : Materia
    {
        #region var y init
        private int virtud;
        private bool notaMaxima;

        public MateriaEspecializada(int codigo, string denominacion) : base(codigo, denominacion)
        {
            notaMaxima = false;
            virtud = 0;
        }
        #endregion

        #region props
        public override void asignarNota(int nota)
        {
            base.asignarNota(nota);
            if (this.Nota >= 6 && this.Nota <= 9)
            {
                virtud++;
            }
            else if(this.Nota == 10)
            {
                notaMaxima = true;
            }
        }
        #endregion
    }

}
