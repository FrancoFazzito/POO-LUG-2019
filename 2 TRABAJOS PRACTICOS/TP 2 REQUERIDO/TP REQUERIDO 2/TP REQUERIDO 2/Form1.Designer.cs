namespace TP_REQUERIDO_2
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
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewAlumnos = new System.Windows.Forms.DataGridView();
            this.Nombredata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajoData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LEGAJO = new System.Windows.Forms.TextBox();
            this.NOMBRE = new System.Windows.Forms.TextBox();
            this.APELLIDO = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.NEWLEGAJO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewAprobadas = new System.Windows.Forms.DataGridView();
            this.codigoData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denominacionData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCursando = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDesaprobados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PROMEDIOGENERAL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PROMEDIOAPROBADO = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.LEGAJOMATERIA = new System.Windows.Forms.TextBox();
            this.CODIGOMATERIA = new System.Windows.Forms.TextBox();
            this.DENOMINACIONMATERIA = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.NUEVOCODIGOMATERIA = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.LEGAJONOTA = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CODIGONOTA = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.NOTA = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAprobadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesaprobados)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "AGREGAR ALUMNO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridViewAlumnos
            // 
            this.dataGridViewAlumnos.AllowUserToAddRows = false;
            this.dataGridViewAlumnos.AllowUserToDeleteRows = false;
            this.dataGridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombredata,
            this.apellidoData,
            this.legajoData});
            this.dataGridViewAlumnos.Location = new System.Drawing.Point(3, 259);
            this.dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            this.dataGridViewAlumnos.ReadOnly = true;
            this.dataGridViewAlumnos.Size = new System.Drawing.Size(350, 207);
            this.dataGridViewAlumnos.TabIndex = 1;
            this.dataGridViewAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAlumnos_CellClick);
            // 
            // Nombredata
            // 
            this.Nombredata.HeaderText = "Nombre";
            this.Nombredata.Name = "Nombredata";
            this.Nombredata.ReadOnly = true;
            // 
            // apellidoData
            // 
            this.apellidoData.HeaderText = "Apellido";
            this.apellidoData.Name = "apellidoData";
            this.apellidoData.ReadOnly = true;
            // 
            // legajoData
            // 
            this.legajoData.HeaderText = "Legajo";
            this.legajoData.Name = "legajoData";
            this.legajoData.ReadOnly = true;
            // 
            // LEGAJO
            // 
            this.LEGAJO.Location = new System.Drawing.Point(157, 48);
            this.LEGAJO.Name = "LEGAJO";
            this.LEGAJO.Size = new System.Drawing.Size(100, 20);
            this.LEGAJO.TabIndex = 2;
            // 
            // NOMBRE
            // 
            this.NOMBRE.Location = new System.Drawing.Point(157, 96);
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Size = new System.Drawing.Size(100, 20);
            this.NOMBRE.TabIndex = 3;
            // 
            // APELLIDO
            // 
            this.APELLIDO.Location = new System.Drawing.Point(157, 142);
            this.APELLIDO.Name = "APELLIDO";
            this.APELLIDO.Size = new System.Drawing.Size(100, 20);
            this.APELLIDO.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "EDITAR ALUMNO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "ELIMINAR ALUMNO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // NEWLEGAJO
            // 
            this.NEWLEGAJO.Location = new System.Drawing.Point(263, 48);
            this.NEWLEGAJO.Name = "NEWLEGAJO";
            this.NEWLEGAJO.Size = new System.Drawing.Size(100, 20);
            this.NEWLEGAJO.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "LEGAJO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "APELLIDO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "NUEVO LEGAJO";
            // 
            // dataGridViewAprobadas
            // 
            this.dataGridViewAprobadas.AllowUserToAddRows = false;
            this.dataGridViewAprobadas.AllowUserToDeleteRows = false;
            this.dataGridViewAprobadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAprobadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoData,
            this.denominacionData,
            this.notaData});
            this.dataGridViewAprobadas.Location = new System.Drawing.Point(359, 259);
            this.dataGridViewAprobadas.Name = "dataGridViewAprobadas";
            this.dataGridViewAprobadas.ReadOnly = true;
            this.dataGridViewAprobadas.Size = new System.Drawing.Size(344, 206);
            this.dataGridViewAprobadas.TabIndex = 12;
            // 
            // codigoData
            // 
            this.codigoData.HeaderText = "codigo";
            this.codigoData.Name = "codigoData";
            this.codigoData.ReadOnly = true;
            // 
            // denominacionData
            // 
            this.denominacionData.HeaderText = "denominacion";
            this.denominacionData.Name = "denominacionData";
            this.denominacionData.ReadOnly = true;
            // 
            // notaData
            // 
            this.notaData.HeaderText = "nota";
            this.notaData.Name = "notaData";
            this.notaData.ReadOnly = true;
            // 
            // dataGridViewCursando
            // 
            this.dataGridViewCursando.AllowUserToAddRows = false;
            this.dataGridViewCursando.AllowUserToDeleteRows = false;
            this.dataGridViewCursando.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursando.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewCursando.Location = new System.Drawing.Point(709, 259);
            this.dataGridViewCursando.Name = "dataGridViewCursando";
            this.dataGridViewCursando.ReadOnly = true;
            this.dataGridViewCursando.Size = new System.Drawing.Size(344, 206);
            this.dataGridViewCursando.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "denominacion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "nota";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewDesaprobados
            // 
            this.dataGridViewDesaprobados.AllowUserToAddRows = false;
            this.dataGridViewDesaprobados.AllowUserToDeleteRows = false;
            this.dataGridViewDesaprobados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDesaprobados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridViewDesaprobados.Location = new System.Drawing.Point(1059, 259);
            this.dataGridViewDesaprobados.Name = "dataGridViewDesaprobados";
            this.dataGridViewDesaprobados.ReadOnly = true;
            this.dataGridViewDesaprobados.Size = new System.Drawing.Size(344, 206);
            this.dataGridViewDesaprobados.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "denominacion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "nota";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "APROBADAS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1198, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "DESAPROBADAS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(850, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "CURSANDO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "ALUMNOS";
            // 
            // PROMEDIOGENERAL
            // 
            this.PROMEDIOGENERAL.Location = new System.Drawing.Point(134, 472);
            this.PROMEDIOGENERAL.Name = "PROMEDIOGENERAL";
            this.PROMEDIOGENERAL.Size = new System.Drawing.Size(101, 20);
            this.PROMEDIOGENERAL.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 475);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "PROMEDIO GENERAL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 501);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "PROMEDIO APROBADO";
            // 
            // PROMEDIOAPROBADO
            // 
            this.PROMEDIOAPROBADO.Location = new System.Drawing.Point(134, 498);
            this.PROMEDIOAPROBADO.Name = "PROMEDIOAPROBADO";
            this.PROMEDIOAPROBADO.Size = new System.Drawing.Size(101, 20);
            this.PROMEDIOAPROBADO.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(369, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "AGREGAR MATERIA BASICA";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(369, 172);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 23);
            this.button5.TabIndex = 24;
            this.button5.Text = "ELIMINAR MATERIA";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(369, 132);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(180, 23);
            this.button6.TabIndex = 25;
            this.button6.Text = "MODIFICAR MATERIA";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(553, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "LEGAJO";
            // 
            // LEGAJOMATERIA
            // 
            this.LEGAJOMATERIA.Location = new System.Drawing.Point(556, 41);
            this.LEGAJOMATERIA.Name = "LEGAJOMATERIA";
            this.LEGAJOMATERIA.Size = new System.Drawing.Size(112, 20);
            this.LEGAJOMATERIA.TabIndex = 26;
            // 
            // CODIGOMATERIA
            // 
            this.CODIGOMATERIA.Location = new System.Drawing.Point(553, 134);
            this.CODIGOMATERIA.Name = "CODIGOMATERIA";
            this.CODIGOMATERIA.Size = new System.Drawing.Size(112, 20);
            this.CODIGOMATERIA.TabIndex = 28;
            // 
            // DENOMINACIONMATERIA
            // 
            this.DENOMINACIONMATERIA.Location = new System.Drawing.Point(556, 87);
            this.DENOMINACIONMATERIA.Name = "DENOMINACIONMATERIA";
            this.DENOMINACIONMATERIA.Size = new System.Drawing.Size(112, 20);
            this.DENOMINACIONMATERIA.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(553, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "CODIGO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(553, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "DENOMINACION";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(368, 86);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(181, 23);
            this.button7.TabIndex = 32;
            this.button7.Text = "AGREGAR MATERIA ESPECIAL";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(675, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "NUEVO CODIGO";
            // 
            // NUEVOCODIGOMATERIA
            // 
            this.NUEVOCODIGOMATERIA.Location = new System.Drawing.Point(675, 43);
            this.NUEVOCODIGOMATERIA.Name = "NUEVOCODIGOMATERIA";
            this.NUEVOCODIGOMATERIA.Size = new System.Drawing.Size(112, 20);
            this.NUEVOCODIGOMATERIA.TabIndex = 33;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(793, 40);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(167, 23);
            this.button8.TabIndex = 35;
            this.button8.Text = "ASIGNAR NOTA MATERIA";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(964, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "LEGAJO";
            // 
            // LEGAJONOTA
            // 
            this.LEGAJONOTA.Location = new System.Drawing.Point(967, 135);
            this.LEGAJONOTA.Name = "LEGAJONOTA";
            this.LEGAJONOTA.Size = new System.Drawing.Size(112, 20);
            this.LEGAJONOTA.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(967, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "CODIGO";
            // 
            // CODIGONOTA
            // 
            this.CODIGONOTA.Location = new System.Drawing.Point(967, 91);
            this.CODIGONOTA.Name = "CODIGONOTA";
            this.CODIGONOTA.Size = new System.Drawing.Size(112, 20);
            this.CODIGONOTA.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(967, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "NOTA";
            // 
            // NOTA
            // 
            this.NOTA.Location = new System.Drawing.Point(967, 43);
            this.NOTA.Name = "NOTA";
            this.NOTA.Size = new System.Drawing.Size(112, 20);
            this.NOTA.TabIndex = 40;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(267, 484);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(225, 23);
            this.button9.TabIndex = 42;
            this.button9.Text = "SORT POR APELLIDO ASCENDENTE";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(504, 484);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(223, 23);
            this.button10.TabIndex = 43;
            this.button10.Text = "SORT POR APELLIDO DESCENDENTE";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 521);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.NOTA);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.CODIGONOTA);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.LEGAJONOTA);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.NUEVOCODIGOMATERIA);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DENOMINACIONMATERIA);
            this.Controls.Add(this.CODIGOMATERIA);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LEGAJOMATERIA);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PROMEDIOAPROBADO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PROMEDIOGENERAL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewDesaprobados);
            this.Controls.Add(this.dataGridViewCursando);
            this.Controls.Add(this.dataGridViewAprobadas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NEWLEGAJO);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.APELLIDO);
            this.Controls.Add(this.NOMBRE);
            this.Controls.Add(this.LEGAJO);
            this.Controls.Add(this.dataGridViewAlumnos);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAprobadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesaprobados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewAlumnos;
        private System.Windows.Forms.TextBox LEGAJO;
        private System.Windows.Forms.TextBox NOMBRE;
        private System.Windows.Forms.TextBox APELLIDO;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox NEWLEGAJO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombredata;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoData;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajoData;
        private System.Windows.Forms.DataGridView dataGridViewAprobadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoData;
        private System.Windows.Forms.DataGridViewTextBoxColumn denominacionData;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaData;
        private System.Windows.Forms.DataGridView dataGridViewCursando;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dataGridViewDesaprobados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PROMEDIOGENERAL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PROMEDIOAPROBADO;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox LEGAJOMATERIA;
        private System.Windows.Forms.TextBox CODIGOMATERIA;
        private System.Windows.Forms.TextBox DENOMINACIONMATERIA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox NUEVOCODIGOMATERIA;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox LEGAJONOTA;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox CODIGONOTA;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox NOTA;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

