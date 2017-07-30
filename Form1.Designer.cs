namespace WindowsFormsApplication2
{
    partial class mainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombre = new System.Windows.Forms.TextBox();
            this.nombre_lbl = new System.Windows.Forms.Label();
            this.matricula = new System.Windows.Forms.TextBox();
            this.matricula_lbl = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(106, 56);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(183, 20);
            this.nombre.TabIndex = 0;
            // 
            // nombre_lbl
            // 
            this.nombre_lbl.AutoSize = true;
            this.nombre_lbl.Location = new System.Drawing.Point(56, 59);
            this.nombre_lbl.Name = "nombre_lbl";
            this.nombre_lbl.Size = new System.Drawing.Size(44, 13);
            this.nombre_lbl.TabIndex = 1;
            this.nombre_lbl.Text = "Nombre";
            this.nombre_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // matricula
            // 
            this.matricula.Location = new System.Drawing.Point(106, 99);
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(183, 20);
            this.matricula.TabIndex = 2;
            // 
            // matricula_lbl
            // 
            this.matricula_lbl.AutoSize = true;
            this.matricula_lbl.Location = new System.Drawing.Point(50, 106);
            this.matricula_lbl.Name = "matricula_lbl";
            this.matricula_lbl.Size = new System.Drawing.Size(50, 13);
            this.matricula_lbl.TabIndex = 3;
            this.matricula_lbl.Text = "Matricula";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(213, 156);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 4;
            this.send.Text = "Enviar";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 261);
            this.Controls.Add(this.send);
            this.Controls.Add(this.matricula_lbl);
            this.Controls.Add(this.matricula);
            this.Controls.Add(this.nombre_lbl);
            this.Controls.Add(this.nombre);
            this.Name = "mainForm";
            this.Text = "Proyecto Final";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label nombre_lbl;
        private System.Windows.Forms.TextBox matricula;
        private System.Windows.Forms.Label matricula_lbl;
        private System.Windows.Forms.Button send;
    }
}

