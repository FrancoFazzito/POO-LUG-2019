namespace _161_ADO_DATA_ADAPTER
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_modificar_telefono = new System.Windows.Forms.Button();
            this.btn_baja_telefono = new System.Windows.Forms.Button();
            this.btn_alta_telefono = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_numero_telefono = new System.Windows.Forms.TextBox();
            this.btn_modificar_alumno = new System.Windows.Forms.Button();
            this.btn_baja_alumno = new System.Windows.Forms.Button();
            this.btn_alta_alumno = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_apellido_alumno = new System.Windows.Forms.TextBox();
            this.txt_nombre_alumno = new System.Windows.Forms.TextBox();
            this.txt_legajo_alumno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(395, 24);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(360, 312);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(761, 25);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(153, 311);
            this.dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ALUMNOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(800, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "TELEFONOS";
            // 
            // btn_modificar_telefono
            // 
            this.btn_modificar_telefono.Location = new System.Drawing.Point(13, 207);
            this.btn_modificar_telefono.Name = "btn_modificar_telefono";
            this.btn_modificar_telefono.Size = new System.Drawing.Size(159, 23);
            this.btn_modificar_telefono.TabIndex = 35;
            this.btn_modificar_telefono.Text = "Modificar";
            this.btn_modificar_telefono.UseVisualStyleBackColor = true;
            this.btn_modificar_telefono.Click += new System.EventHandler(this.Btn_modificar_telefono_Click);
            // 
            // btn_baja_telefono
            // 
            this.btn_baja_telefono.Location = new System.Drawing.Point(12, 178);
            this.btn_baja_telefono.Name = "btn_baja_telefono";
            this.btn_baja_telefono.Size = new System.Drawing.Size(159, 23);
            this.btn_baja_telefono.TabIndex = 34;
            this.btn_baja_telefono.Text = "Baja";
            this.btn_baja_telefono.UseVisualStyleBackColor = true;
            this.btn_baja_telefono.Click += new System.EventHandler(this.Btn_baja_telefono_Click);
            // 
            // btn_alta_telefono
            // 
            this.btn_alta_telefono.Location = new System.Drawing.Point(12, 149);
            this.btn_alta_telefono.Name = "btn_alta_telefono";
            this.btn_alta_telefono.Size = new System.Drawing.Size(160, 23);
            this.btn_alta_telefono.TabIndex = 33;
            this.btn_alta_telefono.Text = "Alta";
            this.btn_alta_telefono.UseVisualStyleBackColor = true;
            this.btn_alta_telefono.Click += new System.EventHandler(this.Btn_alta_telefono_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Numero";
            // 
            // txt_numero_telefono
            // 
            this.txt_numero_telefono.Location = new System.Drawing.Point(228, 178);
            this.txt_numero_telefono.Name = "txt_numero_telefono";
            this.txt_numero_telefono.Size = new System.Drawing.Size(148, 20);
            this.txt_numero_telefono.TabIndex = 31;
            // 
            // btn_modificar_alumno
            // 
            this.btn_modificar_alumno.Location = new System.Drawing.Point(13, 82);
            this.btn_modificar_alumno.Name = "btn_modificar_alumno";
            this.btn_modificar_alumno.Size = new System.Drawing.Size(159, 23);
            this.btn_modificar_alumno.TabIndex = 30;
            this.btn_modificar_alumno.Text = "Modificar";
            this.btn_modificar_alumno.UseVisualStyleBackColor = true;
            this.btn_modificar_alumno.Click += new System.EventHandler(this.Btn_modificar_alumno_Click);
            // 
            // btn_baja_alumno
            // 
            this.btn_baja_alumno.Location = new System.Drawing.Point(12, 53);
            this.btn_baja_alumno.Name = "btn_baja_alumno";
            this.btn_baja_alumno.Size = new System.Drawing.Size(159, 23);
            this.btn_baja_alumno.TabIndex = 29;
            this.btn_baja_alumno.Text = "Baja";
            this.btn_baja_alumno.UseVisualStyleBackColor = true;
            this.btn_baja_alumno.Click += new System.EventHandler(this.Btn_baja_alumno_Click);
            // 
            // btn_alta_alumno
            // 
            this.btn_alta_alumno.Location = new System.Drawing.Point(12, 24);
            this.btn_alta_alumno.Name = "btn_alta_alumno";
            this.btn_alta_alumno.Size = new System.Drawing.Size(160, 23);
            this.btn_alta_alumno.TabIndex = 28;
            this.btn_alta_alumno.Text = "Alta";
            this.btn_alta_alumno.UseVisualStyleBackColor = true;
            this.btn_alta_alumno.Click += new System.EventHandler(this.Btn_alta_alumno_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Legajo";
            // 
            // txt_apellido_alumno
            // 
            this.txt_apellido_alumno.Location = new System.Drawing.Point(228, 84);
            this.txt_apellido_alumno.Name = "txt_apellido_alumno";
            this.txt_apellido_alumno.Size = new System.Drawing.Size(148, 20);
            this.txt_apellido_alumno.TabIndex = 24;
            // 
            // txt_nombre_alumno
            // 
            this.txt_nombre_alumno.Location = new System.Drawing.Point(228, 55);
            this.txt_nombre_alumno.Name = "txt_nombre_alumno";
            this.txt_nombre_alumno.Size = new System.Drawing.Size(148, 20);
            this.txt_nombre_alumno.TabIndex = 23;
            // 
            // txt_legajo_alumno
            // 
            this.txt_legajo_alumno.Location = new System.Drawing.Point(228, 25);
            this.txt_legajo_alumno.Name = "txt_legajo_alumno";
            this.txt_legajo_alumno.Size = new System.Drawing.Size(148, 20);
            this.txt_legajo_alumno.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "ALUMNOS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "TELEFONOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 341);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_modificar_telefono);
            this.Controls.Add(this.btn_baja_telefono);
            this.Controls.Add(this.btn_alta_telefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_numero_telefono);
            this.Controls.Add(this.btn_modificar_alumno);
            this.Controls.Add(this.btn_baja_alumno);
            this.Controls.Add(this.btn_alta_alumno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_apellido_alumno);
            this.Controls.Add(this.txt_nombre_alumno);
            this.Controls.Add(this.txt_legajo_alumno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_modificar_telefono;
        private System.Windows.Forms.Button btn_baja_telefono;
        private System.Windows.Forms.Button btn_alta_telefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_numero_telefono;
        private System.Windows.Forms.Button btn_modificar_alumno;
        private System.Windows.Forms.Button btn_baja_alumno;
        private System.Windows.Forms.Button btn_alta_alumno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_apellido_alumno;
        private System.Windows.Forms.TextBox txt_nombre_alumno;
        private System.Windows.Forms.TextBox txt_legajo_alumno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
    }
}

