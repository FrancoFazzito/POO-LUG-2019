namespace _164_6_tier_capas
{
    partial class vista_form
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
            this.btn_alta = new System.Windows.Forms.Button();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.btn_baja = new System.Windows.Forms.Button();
            this.btn_modificacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DGV_persona = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_persona)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_alta
            // 
            this.btn_alta.Location = new System.Drawing.Point(13, 13);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(136, 23);
            this.btn_alta.TabIndex = 0;
            this.btn_alta.Text = "Alta";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.Btn_alta_Click);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(204, 16);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 1;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(204, 44);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 2;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(204, 73);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido.TabIndex = 3;
            // 
            // btn_baja
            // 
            this.btn_baja.Location = new System.Drawing.Point(13, 42);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(136, 23);
            this.btn_baja.TabIndex = 4;
            this.btn_baja.Text = "Baja";
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.Click += new System.EventHandler(this.Btn_baja_Click);
            // 
            // btn_modificacion
            // 
            this.btn_modificacion.Location = new System.Drawing.Point(13, 71);
            this.btn_modificacion.Name = "btn_modificacion";
            this.btn_modificacion.Size = new System.Drawing.Size(136, 23);
            this.btn_modificacion.TabIndex = 5;
            this.btn_modificacion.Text = "Modificacion";
            this.btn_modificacion.UseVisualStyleBackColor = true;
            this.btn_modificacion.Click += new System.EventHandler(this.Btn_modificacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido";
            // 
            // DGV_persona
            // 
            this.DGV_persona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_persona.Location = new System.Drawing.Point(13, 114);
            this.DGV_persona.Name = "DGV_persona";
            this.DGV_persona.Size = new System.Drawing.Size(499, 150);
            this.DGV_persona.TabIndex = 9;
            // 
            // vista_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 275);
            this.Controls.Add(this.DGV_persona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_modificacion);
            this.Controls.Add(this.btn_baja);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.btn_alta);
            this.Name = "vista_form";
            this.Text = "VISTA";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_persona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Button btn_modificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGV_persona;
    }
}

