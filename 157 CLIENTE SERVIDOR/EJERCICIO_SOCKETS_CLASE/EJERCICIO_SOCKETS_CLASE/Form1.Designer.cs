namespace EJERCICIO_SOCKETS_CLASE
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
            this.btn_connect = new System.Windows.Forms.Button();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.lbl_port = new System.Windows.Forms.Label();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.lbl_send_message = new System.Windows.Forms.Label();
            this.lbl_received_message = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_nick_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(180, 32);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(90, 70);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(12, 58);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(163, 20);
            this.txt_ip.TabIndex = 1;
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(12, 98);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(163, 20);
            this.txt_port.TabIndex = 2;
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Location = new System.Drawing.Point(10, 42);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(20, 13);
            this.lbl_ip.TabIndex = 3;
            this.lbl_ip.Text = "IP:";
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(12, 82);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(40, 13);
            this.lbl_port.TabIndex = 4;
            this.lbl_port.Text = "PORT:";
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(10, 157);
            this.txt_message.Multiline = true;
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(164, 137);
            this.txt_message.TabIndex = 5;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(181, 157);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(89, 29);
            this.btn_send.TabIndex = 6;
            this.btn_send.Text = "send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // lbl_send_message
            // 
            this.lbl_send_message.AutoSize = true;
            this.lbl_send_message.Location = new System.Drawing.Point(10, 141);
            this.lbl_send_message.Name = "lbl_send_message";
            this.lbl_send_message.Size = new System.Drawing.Size(78, 13);
            this.lbl_send_message.TabIndex = 7;
            this.lbl_send_message.Text = "send message:";
            // 
            // lbl_received_message
            // 
            this.lbl_received_message.AutoSize = true;
            this.lbl_received_message.Location = new System.Drawing.Point(10, 301);
            this.lbl_received_message.Name = "lbl_received_message";
            this.lbl_received_message.Size = new System.Drawing.Size(98, 13);
            this.lbl_received_message.TabIndex = 8;
            this.lbl_received_message.Text = "received messages";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(10, 318);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 95);
            this.listBox1.TabIndex = 9;
            // 
            // lbl_nick_name
            // 
            this.lbl_nick_name.AutoSize = true;
            this.lbl_nick_name.Location = new System.Drawing.Point(10, 3);
            this.lbl_nick_name.Name = "lbl_nick_name";
            this.lbl_nick_name.Size = new System.Drawing.Size(41, 13);
            this.lbl_nick_name.TabIndex = 11;
            this.lbl_nick_name.Text = "NAME:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(12, 19);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(163, 20);
            this.txt_name.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 423);
            this.Controls.Add(this.lbl_nick_name);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_received_message);
            this.Controls.Add(this.lbl_send_message);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.lbl_port);
            this.Controls.Add(this.lbl_ip);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label lbl_send_message;
        private System.Windows.Forms.Label lbl_received_message;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_nick_name;
        private System.Windows.Forms.TextBox txt_name;
    }
}

