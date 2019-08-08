namespace creacion_de_controles
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.boton1 = new creacion_de_controles.boton();
            this.customControl11 = new creacion_de_controles.CustomControl1();
            this.SuspendLayout();
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(12, 12);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(75, 23);
            this.boton1.TabIndex = 0;
            this.boton1.Text = "boton1";
            this.boton1.UseVisualStyleBackColor = true;
            // 
            // customControl11
            // 
            this.customControl11.Activado = false;
            this.customControl11.Location = new System.Drawing.Point(136, 148);
            this.customControl11.Name = "customControl11";
            this.customControl11.Presionado = false;
            this.customControl11.Size = new System.Drawing.Size(380, 192);
            this.customControl11.TabIndex = 1;
            this.customControl11.Text = "hola";
            this.customControl11.Click += new System.EventHandler(this.customControl11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 352);
            this.Controls.Add(this.customControl11);
            this.Controls.Add(this.boton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private boton boton1;
        private CustomControl1 customControl11;
    }
}

