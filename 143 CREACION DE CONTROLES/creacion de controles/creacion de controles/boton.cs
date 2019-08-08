using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
namespace creacion_de_controles
{
    class boton : Button
    {
        private bool gigante = true;
        [Description("SI EL BOTON ES GIGANTE")]
        [Category("COSAS GRNADES")]
        [DefaultValue(true)]
        //DECORACION PARA QUE APAREZCA EN PROP  
        public bool Gigante { get => gigante; set => gigante = value; }
        protected override void OnMouseEnter(EventArgs e)
        {
            if (gigante)
            {
                this.Size = new System.Drawing.Size(150, 150);
            }
            base.OnMouseEnter(e);
        }
        protected override void OnMouseHover(EventArgs e)
        {
            if (gigante)
            {
                this.Size = new System.Drawing.Size(150,150);
            }
            base.OnMouseHover(e);
        }
    }
}
