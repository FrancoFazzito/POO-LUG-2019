namespace SOCKET_CLIENTE_SERVIDOR_SERVERSIDE
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDatosSend = new System.Windows.Forms.TextBox();
            this.txtDatosParticularSend = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.IP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 185);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(378, 277);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(378, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "RUN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(397, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "CORRIENDO";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "ENVIAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtDatosSend
            // 
            this.txtDatosSend.Location = new System.Drawing.Point(13, 67);
            this.txtDatosSend.Name = "txtDatosSend";
            this.txtDatosSend.Size = new System.Drawing.Size(377, 20);
            this.txtDatosSend.TabIndex = 4;
            // 
            // txtDatosParticularSend
            // 
            this.txtDatosParticularSend.Location = new System.Drawing.Point(14, 143);
            this.txtDatosParticularSend.Name = "txtDatosParticularSend";
            this.txtDatosParticularSend.Size = new System.Drawing.Size(377, 20);
            this.txtDatosParticularSend.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(397, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "ENVIAR PARTICULAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(35, 117);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(156, 20);
            this.IP.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.txtDatosParticularSend);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtDatosSend);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDatosSend;
        private System.Windows.Forms.TextBox txtDatosParticularSend;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.Label label1;
    }
}

