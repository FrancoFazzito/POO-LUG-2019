namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblEstado = new System.Windows.Forms.Label();
            this.opennotepad = new System.Windows.Forms.Button();
            this.CERRAR = new System.Windows.Forms.Button();
            this.proceso = new System.Diagnostics.Process();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aBREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cIERRAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(24, 62);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 13);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "lblEstado";
            // 
            // opennotepad
            // 
            this.opennotepad.Location = new System.Drawing.Point(27, 23);
            this.opennotepad.Name = "opennotepad";
            this.opennotepad.Size = new System.Drawing.Size(75, 23);
            this.opennotepad.TabIndex = 1;
            this.opennotepad.Text = "ABRIR";
            this.opennotepad.UseVisualStyleBackColor = true;
            this.opennotepad.Click += new System.EventHandler(this.opennotepad_Click);
            // 
            // CERRAR
            // 
            this.CERRAR.Location = new System.Drawing.Point(118, 23);
            this.CERRAR.Name = "CERRAR";
            this.CERRAR.Size = new System.Drawing.Size(75, 23);
            this.CERRAR.TabIndex = 3;
            this.CERRAR.Text = "CERRAR";
            this.CERRAR.UseVisualStyleBackColor = true;
            this.CERRAR.Click += new System.EventHandler(this.CERRAR_Click);
            // 
            // proceso
            // 
            this.proceso.StartInfo.Domain = "";
            this.proceso.StartInfo.FileName = "C:\\Windows\\System32\\notepad.exe";
            this.proceso.StartInfo.LoadUserProfile = false;
            this.proceso.StartInfo.Password = null;
            this.proceso.StartInfo.StandardErrorEncoding = null;
            this.proceso.StartInfo.StandardOutputEncoding = null;
            this.proceso.StartInfo.UserName = "";
            this.proceso.StartInfo.WorkingDirectory = "%system%system32";
            this.proceso.SynchronizingObject = this;
            this.proceso.Exited += new System.EventHandler(this.proceso_Exited);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "OPEN NOTEPAD PROGRAM";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ABRE APPS ESTO ES TEXT";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBREToolStripMenuItem,
            this.cIERRAToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // aBREToolStripMenuItem
            // 
            this.aBREToolStripMenuItem.Name = "aBREToolStripMenuItem";
            this.aBREToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aBREToolStripMenuItem.Text = "ABRE";
            this.aBREToolStripMenuItem.Click += new System.EventHandler(this.aBREToolStripMenuItem_Click);
            // 
            // cIERRAToolStripMenuItem
            // 
            this.cIERRAToolStripMenuItem.Name = "cIERRAToolStripMenuItem";
            this.cIERRAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cIERRAToolStripMenuItem.Text = "CIERRA";
            this.cIERRAToolStripMenuItem.Click += new System.EventHandler(this.cIERRAToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 124);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CERRAR);
            this.Controls.Add(this.opennotepad);
            this.Controls.Add(this.lblEstado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button opennotepad;
        private System.Windows.Forms.Button CERRAR;
        private System.Diagnostics.Process proceso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aBREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cIERRAToolStripMenuItem;
    }
}

