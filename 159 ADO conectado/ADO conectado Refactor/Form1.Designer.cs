namespace ADO_conectado_Refactor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_alta_persona = new System.Windows.Forms.Button();
            this.btn_modificar_persona = new System.Windows.Forms.Button();
            this.btn_baja_persona = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_id_persona = new System.Windows.Forms.TextBox();
            this.txt_nombre_persona = new System.Windows.Forms.TextBox();
            this.txt_apellido_persona = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_personas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_filtrar_personas = new System.Windows.Forms.Button();
            this.txt_filtro = new System.Windows.Forms.TextBox();
            this.btn_borrar_todo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_count_row = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_alta_persona
            // 
            this.btn_alta_persona.Location = new System.Drawing.Point(15, 22);
            this.btn_alta_persona.Name = "btn_alta_persona";
            this.btn_alta_persona.Size = new System.Drawing.Size(75, 23);
            this.btn_alta_persona.TabIndex = 0;
            this.btn_alta_persona.Text = "ALTA";
            this.btn_alta_persona.UseVisualStyleBackColor = true;
            this.btn_alta_persona.Click += new System.EventHandler(this.Btn_alta_persona_Click);
            // 
            // btn_modificar_persona
            // 
            this.btn_modificar_persona.Location = new System.Drawing.Point(15, 51);
            this.btn_modificar_persona.Name = "btn_modificar_persona";
            this.btn_modificar_persona.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar_persona.TabIndex = 1;
            this.btn_modificar_persona.Text = "MODIFICAR";
            this.btn_modificar_persona.UseVisualStyleBackColor = true;
            this.btn_modificar_persona.Click += new System.EventHandler(this.Btn_modificar_persona_Click);
            // 
            // btn_baja_persona
            // 
            this.btn_baja_persona.Location = new System.Drawing.Point(15, 80);
            this.btn_baja_persona.Name = "btn_baja_persona";
            this.btn_baja_persona.Size = new System.Drawing.Size(75, 23);
            this.btn_baja_persona.TabIndex = 2;
            this.btn_baja_persona.Text = "BAJA";
            this.btn_baja_persona.UseVisualStyleBackColor = true;
            this.btn_baja_persona.Click += new System.EventHandler(this.Btn_baja_persona_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(113, 27);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Text = "ID";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(97, 56);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(54, 13);
            this.lbl_nombre.TabIndex = 4;
            this.lbl_nombre.Text = "NOMBRE";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(97, 85);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(59, 13);
            this.lbl_apellido.TabIndex = 5;
            this.lbl_apellido.Text = "APELLIDO";
            // 
            // txt_id_persona
            // 
            this.txt_id_persona.Location = new System.Drawing.Point(155, 24);
            this.txt_id_persona.Name = "txt_id_persona";
            this.txt_id_persona.Size = new System.Drawing.Size(100, 20);
            this.txt_id_persona.TabIndex = 6;
            // 
            // txt_nombre_persona
            // 
            this.txt_nombre_persona.Location = new System.Drawing.Point(155, 53);
            this.txt_nombre_persona.Name = "txt_nombre_persona";
            this.txt_nombre_persona.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_persona.TabIndex = 7;
            // 
            // txt_apellido_persona
            // 
            this.txt_apellido_persona.Location = new System.Drawing.Point(155, 82);
            this.txt_apellido_persona.Name = "txt_apellido_persona";
            this.txt_apellido_persona.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido_persona.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_apellido_persona);
            this.groupBox1.Controls.Add(this.btn_alta_persona);
            this.groupBox1.Controls.Add(this.txt_nombre_persona);
            this.groupBox1.Controls.Add(this.btn_modificar_persona);
            this.groupBox1.Controls.Add(this.txt_id_persona);
            this.groupBox1.Controls.Add(this.btn_baja_persona);
            this.groupBox1.Controls.Add(this.lbl_apellido);
            this.groupBox1.Controls.Add(this.lbl_id);
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 120);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ABM persona";
            // 
            // dgv_personas
            // 
            this.dgv_personas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_personas.Location = new System.Drawing.Point(13, 138);
            this.dgv_personas.Name = "dgv_personas";
            this.dgv_personas.Size = new System.Drawing.Size(406, 198);
            this.dgv_personas.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "SORT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_filtrar_personas
            // 
            this.btn_filtrar_personas.Location = new System.Drawing.Point(285, 68);
            this.btn_filtrar_personas.Name = "btn_filtrar_personas";
            this.btn_filtrar_personas.Size = new System.Drawing.Size(133, 23);
            this.btn_filtrar_personas.TabIndex = 12;
            this.btn_filtrar_personas.Text = "FILTRAR";
            this.btn_filtrar_personas.UseVisualStyleBackColor = true;
            this.btn_filtrar_personas.Click += new System.EventHandler(this.Btn_filtrar_personas_Click);
            // 
            // txt_filtro
            // 
            this.txt_filtro.Location = new System.Drawing.Point(286, 99);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(132, 20);
            this.txt_filtro.TabIndex = 13;
            // 
            // btn_borrar_todo
            // 
            this.btn_borrar_todo.Location = new System.Drawing.Point(329, 342);
            this.btn_borrar_todo.Name = "btn_borrar_todo";
            this.btn_borrar_todo.Size = new System.Drawing.Size(90, 41);
            this.btn_borrar_todo.TabIndex = 14;
            this.btn_borrar_todo.Text = "BORRAR TODO";
            this.btn_borrar_todo.UseVisualStyleBackColor = true;
            this.btn_borrar_todo.Click += new System.EventHandler(this.Btn_borrar_todo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 41);
            this.button2.TabIndex = 15;
            this.button2.Text = "CREAR PERSONAS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ROWS AFECTADAS";
            // 
            // lbl_count_row
            // 
            this.lbl_count_row.AutoSize = true;
            this.lbl_count_row.Location = new System.Drawing.Point(125, 342);
            this.lbl_count_row.Name = "lbl_count_row";
            this.lbl_count_row.Size = new System.Drawing.Size(16, 13);
            this.lbl_count_row.TabIndex = 17;
            this.lbl_count_row.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 395);
            this.Controls.Add(this.lbl_count_row);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_borrar_todo);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.btn_filtrar_personas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_personas);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ADO CONECTADO PRACTICA I";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_alta_persona;
        private System.Windows.Forms.Button btn_modificar_persona;
        private System.Windows.Forms.Button btn_baja_persona;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txt_id_persona;
        private System.Windows.Forms.TextBox txt_nombre_persona;
        private System.Windows.Forms.TextBox txt_apellido_persona;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_personas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_filtrar_personas;
        private System.Windows.Forms.TextBox txt_filtro;
        private System.Windows.Forms.Button btn_borrar_todo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_count_row;
    }
}

