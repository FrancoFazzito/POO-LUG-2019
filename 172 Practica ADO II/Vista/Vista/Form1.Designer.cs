namespace Vista
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
            this.dgv_cliente = new System.Windows.Forms.DataGridView();
            this.btn_alta = new System.Windows.Forms.Button();
            this.btn_baja = new System.Windows.Forms.Button();
            this.btn_modificacion = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.control_seguridad = new Vista.Seguridad();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cliente
            // 
            this.dgv_cliente.AllowUserToAddRows = false;
            this.dgv_cliente.AllowUserToDeleteRows = false;
            this.dgv_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cliente.Location = new System.Drawing.Point(230, 12);
            this.dgv_cliente.Name = "dgv_cliente";
            this.dgv_cliente.ReadOnly = true;
            this.dgv_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cliente.Size = new System.Drawing.Size(279, 311);
            this.dgv_cliente.TabIndex = 0;
            // 
            // btn_alta
            // 
            this.btn_alta.Location = new System.Drawing.Point(12, 65);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(212, 23);
            this.btn_alta.TabIndex = 1;
            this.btn_alta.Text = "ALTA";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.Btn_alta_Click);
            // 
            // btn_baja
            // 
            this.btn_baja.Location = new System.Drawing.Point(12, 95);
            this.btn_baja.Name = "btn_baja";
            this.btn_baja.Size = new System.Drawing.Size(212, 23);
            this.btn_baja.TabIndex = 2;
            this.btn_baja.Text = "BAJA";
            this.btn_baja.UseVisualStyleBackColor = true;
            this.btn_baja.Click += new System.EventHandler(this.Btn_baja_Click);
            // 
            // btn_modificacion
            // 
            this.btn_modificacion.Location = new System.Drawing.Point(12, 125);
            this.btn_modificacion.Name = "btn_modificacion";
            this.btn_modificacion.Size = new System.Drawing.Size(212, 23);
            this.btn_modificacion.TabIndex = 3;
            this.btn_modificacion.Text = "MODIFICACION";
            this.btn_modificacion.UseVisualStyleBackColor = true;
            this.btn_modificacion.Click += new System.EventHandler(this.Btn_modificacion_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(75, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(149, 20);
            this.txt_id.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "NOMBRE:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(75, 39);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(149, 20);
            this.txt_nombre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "BARRA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "TORTA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "CODIGO SEGURIDAD";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "grafico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "grafico";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // control_seguridad
            // 
            this.control_seguridad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.control_seguridad.Location = new System.Drawing.Point(12, 178);
            this.control_seguridad.Name = "control_seguridad";
            this.control_seguridad.Size = new System.Drawing.Size(212, 26);
            this.control_seguridad.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 643);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.control_seguridad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_modificacion);
            this.Controls.Add(this.btn_baja);
            this.Controls.Add(this.btn_alta);
            this.Controls.Add(this.dgv_cliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cliente;
        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.Button btn_baja;
        private System.Windows.Forms.Button btn_modificacion;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Seguridad control_seguridad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

