namespace VISTA
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.list_datos_persona = new System.Windows.Forms.ListBox();
            this.btn_iniciar_sesion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(105, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(117, 20);
            this.txt_id.TabIndex = 0;
            // 
            // txt_contra
            // 
            this.txt_contra.Location = new System.Drawing.Point(105, 38);
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.Size = new System.Drawing.Size(117, 20);
            this.txt_contra.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONTRA";
            // 
            // list_datos_persona
            // 
            this.list_datos_persona.FormattingEnabled = true;
            this.list_datos_persona.Location = new System.Drawing.Point(13, 143);
            this.list_datos_persona.Name = "list_datos_persona";
            this.list_datos_persona.Size = new System.Drawing.Size(240, 95);
            this.list_datos_persona.TabIndex = 4;
            // 
            // btn_iniciar_sesion
            // 
            this.btn_iniciar_sesion.Location = new System.Drawing.Point(13, 70);
            this.btn_iniciar_sesion.Name = "btn_iniciar_sesion";
            this.btn_iniciar_sesion.Size = new System.Drawing.Size(240, 51);
            this.btn_iniciar_sesion.TabIndex = 5;
            this.btn_iniciar_sesion.Text = "INICIAR SESION";
            this.btn_iniciar_sesion.UseVisualStyleBackColor = true;
            this.btn_iniciar_sesion.Click += new System.EventHandler(this.Btn_iniciar_sesion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DATOS:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 250);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_iniciar_sesion);
            this.Controls.Add(this.list_datos_persona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_contra);
            this.Controls.Add(this.txt_id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_contra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox list_datos_persona;
        private System.Windows.Forms.Button btn_iniciar_sesion;
        private System.Windows.Forms.Label label3;
    }
}

