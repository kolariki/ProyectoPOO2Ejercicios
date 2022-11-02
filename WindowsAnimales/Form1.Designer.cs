namespace WindowsAnimales
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
            this.btnLeon = new System.Windows.Forms.Button();
            this.btnLoro = new System.Windows.Forms.Button();
            this.btnConejo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeon
            // 
            this.btnLeon.Location = new System.Drawing.Point(308, 141);
            this.btnLeon.Name = "btnLeon";
            this.btnLeon.Size = new System.Drawing.Size(75, 23);
            this.btnLeon.TabIndex = 0;
            this.btnLeon.Text = "Leon";
            this.btnLeon.UseVisualStyleBackColor = true;
            this.btnLeon.Click += new System.EventHandler(this.btnLeon_Click);
            // 
            // btnLoro
            // 
            this.btnLoro.Location = new System.Drawing.Point(308, 196);
            this.btnLoro.Name = "btnLoro";
            this.btnLoro.Size = new System.Drawing.Size(75, 23);
            this.btnLoro.TabIndex = 1;
            this.btnLoro.Text = "Loro";
            this.btnLoro.UseVisualStyleBackColor = true;
            this.btnLoro.Click += new System.EventHandler(this.btnLoro_Click);
            // 
            // btnConejo
            // 
            this.btnConejo.Location = new System.Drawing.Point(308, 243);
            this.btnConejo.Name = "btnConejo";
            this.btnConejo.Size = new System.Drawing.Size(75, 23);
            this.btnConejo.TabIndex = 2;
            this.btnConejo.Text = "Conejo";
            this.btnConejo.UseVisualStyleBackColor = true;
            this.btnConejo.Click += new System.EventHandler(this.btnConejo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConejo);
            this.Controls.Add(this.btnLoro);
            this.Controls.Add(this.btnLeon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeon;
        private System.Windows.Forms.Button btnLoro;
        private System.Windows.Forms.Button btnConejo;
    }
}

