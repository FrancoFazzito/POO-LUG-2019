﻿namespace _166_User_Control
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
            this.textbox_numerico2 = new _166_User_Control.Textbox_numerico();
            this.SuspendLayout();
            // 
            // textbox_numerico2
            // 
            this.textbox_numerico2.Location = new System.Drawing.Point(27, 26);
            this.textbox_numerico2.Name = "textbox_numerico2";
            this.textbox_numerico2.Size = new System.Drawing.Size(167, 108);
            this.textbox_numerico2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 216);
            this.Controls.Add(this.textbox_numerico2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Textbox_numerico textbox_numerico1;
        private Textbox_numerico textbox_numerico2;
    }
}

