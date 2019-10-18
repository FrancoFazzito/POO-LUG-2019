namespace _166_User_Control
{
    partial class Textbox_numerico
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_value = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Txt_value
            // 
            this.Txt_value.Location = new System.Drawing.Point(3, 3);
            this.Txt_value.Multiline = true;
            this.Txt_value.Name = "Txt_value";
            this.Txt_value.Size = new System.Drawing.Size(100, 20);
            this.Txt_value.TabIndex = 0;
            this.Txt_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_value_KeyPress);
            // 
            // Textbox_numerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Txt_value);
            this.Name = "Textbox_numerico";
            this.Size = new System.Drawing.Size(192, 150);
            this.Load += new System.EventHandler(this.Textbox_numerico_Load);
            this.Resize += new System.EventHandler(this.Textbox_numerico_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_value;
    }
}
