﻿namespace TaTeTi_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ImgBox1 = new System.Windows.Forms.PictureBox();
            this.ImgBox2 = new System.Windows.Forms.PictureBox();
            this.ImgBox3 = new System.Windows.Forms.PictureBox();
            this.ImgBox4 = new System.Windows.Forms.PictureBox();
            this.ImgBox5 = new System.Windows.Forms.PictureBox();
            this.ImgBox6 = new System.Windows.Forms.PictureBox();
            this.ImgBox7 = new System.Windows.Forms.PictureBox();
            this.ImgBox8 = new System.Windows.Forms.PictureBox();
            this.ImgBox9 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(402, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(565, 86);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 48);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Jugador Cliente";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtLog.Location = new System.Drawing.Point(13, 156);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(285, 674);
            this.txtLog.TabIndex = 15;
            this.txtLog.WordWrap = false;
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConectar.Location = new System.Drawing.Point(14, 86);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(284, 60);
            this.btnConectar.TabIndex = 12;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.BtnConectar_Click_1);
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtIP.Location = new System.Drawing.Point(14, 53);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(169, 30);
            this.txtIP.TabIndex = 9;
            this.txtIP.Text = "127.0.0.1";
            // 
            // txtPuerto
            // 
            this.txtPuerto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuerto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPuerto.Location = new System.Drawing.Point(191, 53);
            this.txtPuerto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(107, 30);
            this.txtPuerto.TabIndex = 11;
            this.txtPuerto.Text = "8050";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(186, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Puerto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(11, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "IP:";
            // 
            // ImgBox1
            // 
            this.ImgBox1.BackColor = System.Drawing.Color.Transparent;
            this.ImgBox1.Location = new System.Drawing.Point(409, 247);
            this.ImgBox1.Name = "ImgBox1";
            this.ImgBox1.Size = new System.Drawing.Size(140, 140);
            this.ImgBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgBox1.TabIndex = 16;
            this.ImgBox1.TabStop = false;
            this.ImgBox1.Click += new System.EventHandler(this.ImgBox1_Click);
            // 
            // ImgBox2
            // 
            this.ImgBox2.BackColor = System.Drawing.Color.Transparent;
            this.ImgBox2.Location = new System.Drawing.Point(567, 247);
            this.ImgBox2.Name = "ImgBox2";
            this.ImgBox2.Size = new System.Drawing.Size(140, 140);
            this.ImgBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgBox2.TabIndex = 17;
            this.ImgBox2.TabStop = false;
            this.ImgBox2.Click += new System.EventHandler(this.ImgBox2_Click);
            // 
            // ImgBox3
            // 
            this.ImgBox3.BackColor = System.Drawing.Color.Transparent;
            this.ImgBox3.Location = new System.Drawing.Point(725, 247);
            this.ImgBox3.Name = "ImgBox3";
            this.ImgBox3.Size = new System.Drawing.Size(140, 140);
            this.ImgBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgBox3.TabIndex = 18;
            this.ImgBox3.TabStop = false;
            this.ImgBox3.Click += new System.EventHandler(this.ImgBox3_Click);
            // 
            // ImgBox4
            // 
            this.ImgBox4.BackColor = System.Drawing.Color.Transparent;
            this.ImgBox4.Location = new System.Drawing.Point(410, 398);
            this.ImgBox4.Name = "ImgBox4";
            this.ImgBox4.Size = new System.Drawing.Size(140, 140);
            this.ImgBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgBox4.TabIndex = 19;
            this.ImgBox4.TabStop = false;
            this.ImgBox4.Click += new System.EventHandler(this.ImgBox4_Click);
            // 
            // ImgBox5
            // 
            this.ImgBox5.BackColor = System.Drawing.Color.Transparent;
            this.ImgBox5.Location = new System.Drawing.Point(567, 398);
            this.ImgBox5.Name = "ImgBox5";
            this.ImgBox5.Size = new System.Drawing.Size(140, 140);
            this.ImgBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgBox5.TabIndex = 20;
            this.ImgBox5.TabStop = false;
            this.ImgBox5.Click += new System.EventHandler(this.ImgBox5_Click);
            // 
            // ImgBox6
            // 
            this.ImgBox6.BackColor = System.Drawing.Color.Transparent;
            this.ImgBox6.Location = new System.Drawing.Point(725, 398);
            this.ImgBox6.Name = "ImgBox6";
            this.ImgBox6.Size = new System.Drawing.Size(140, 140);
            this.ImgBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgBox6.TabIndex = 21;
            this.ImgBox6.TabStop = false;
            this.ImgBox6.Click += new System.EventHandler(this.ImgBox6_Click);
            // 
            // ImgBox7
            // 
            this.ImgBox7.BackColor = System.Drawing.Color.Transparent;
            this.ImgBox7.Location = new System.Drawing.Point(409, 552);
            this.ImgBox7.Name = "ImgBox7";
            this.ImgBox7.Size = new System.Drawing.Size(140, 140);
            this.ImgBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgBox7.TabIndex = 22;
            this.ImgBox7.TabStop = false;
            this.ImgBox7.Click += new System.EventHandler(this.ImgBox7_Click);
            // 
            // ImgBox8
            // 
            this.ImgBox8.BackColor = System.Drawing.Color.Transparent;
            this.ImgBox8.Location = new System.Drawing.Point(567, 552);
            this.ImgBox8.Name = "ImgBox8";
            this.ImgBox8.Size = new System.Drawing.Size(140, 140);
            this.ImgBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgBox8.TabIndex = 23;
            this.ImgBox8.TabStop = false;
            this.ImgBox8.Click += new System.EventHandler(this.ImgBox8_Click);
            // 
            // ImgBox9
            // 
            this.ImgBox9.BackColor = System.Drawing.Color.Transparent;
            this.ImgBox9.Location = new System.Drawing.Point(725, 552);
            this.ImgBox9.Name = "ImgBox9";
            this.ImgBox9.Size = new System.Drawing.Size(140, 140);
            this.ImgBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgBox9.TabIndex = 24;
            this.ImgBox9.TabStop = false;
            this.ImgBox9.Click += new System.EventHandler(this.ImgBox9_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.Location = new System.Drawing.Point(681, 770);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(284, 60);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 844);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.ImgBox9);
            this.Controls.Add(this.ImgBox8);
            this.Controls.Add(this.ImgBox7);
            this.Controls.Add(this.ImgBox6);
            this.Controls.Add(this.ImgBox5);
            this.Controls.Add(this.ImgBox4);
            this.Controls.Add(this.ImgBox3);
            this.Controls.Add(this.ImgBox2);
            this.Controls.Add(this.ImgBox1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Cliente (Sin Conexion)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ImgBox1;
        private System.Windows.Forms.PictureBox ImgBox2;
        private System.Windows.Forms.PictureBox ImgBox3;
        private System.Windows.Forms.PictureBox ImgBox4;
        private System.Windows.Forms.PictureBox ImgBox5;
        private System.Windows.Forms.PictureBox ImgBox6;
        private System.Windows.Forms.PictureBox ImgBox7;
        private System.Windows.Forms.PictureBox ImgBox8;
        private System.Windows.Forms.PictureBox ImgBox9;
        private System.Windows.Forms.Button btnReset;
    }
}
