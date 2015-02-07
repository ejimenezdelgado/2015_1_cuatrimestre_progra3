namespace HerenciaInterface
{
    partial class frmHerencia
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblExtras = new System.Windows.Forms.Label();
            this.btnObtenerProfesor = new System.Windows.Forms.Button();
            this.btnObtenerEstudiante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(176, 43);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(40, 24);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "info";
            // 
            // lblExtras
            // 
            this.lblExtras.AutoSize = true;
            this.lblExtras.Location = new System.Drawing.Point(180, 82);
            this.lblExtras.Name = "lblExtras";
            this.lblExtras.Size = new System.Drawing.Size(36, 13);
            this.lblExtras.TabIndex = 1;
            this.lblExtras.Text = "Extras";
            // 
            // btnObtenerProfesor
            // 
            this.btnObtenerProfesor.Location = new System.Drawing.Point(76, 118);
            this.btnObtenerProfesor.Name = "btnObtenerProfesor";
            this.btnObtenerProfesor.Size = new System.Drawing.Size(106, 23);
            this.btnObtenerProfesor.TabIndex = 2;
            this.btnObtenerProfesor.Text = "Obtener Profesor";
            this.btnObtenerProfesor.UseVisualStyleBackColor = true;
            this.btnObtenerProfesor.Click += new System.EventHandler(this.btnObtenerProfesor_Click);
            // 
            // btnObtenerEstudiante
            // 
            this.btnObtenerEstudiante.Location = new System.Drawing.Point(188, 118);
            this.btnObtenerEstudiante.Name = "btnObtenerEstudiante";
            this.btnObtenerEstudiante.Size = new System.Drawing.Size(106, 23);
            this.btnObtenerEstudiante.TabIndex = 3;
            this.btnObtenerEstudiante.Text = "Obtener Estudiante";
            this.btnObtenerEstudiante.UseVisualStyleBackColor = true;
            this.btnObtenerEstudiante.Click += new System.EventHandler(this.btnObtenerEstudiante_Click);
            // 
            // frmHerencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 200);
            this.Controls.Add(this.btnObtenerEstudiante);
            this.Controls.Add(this.btnObtenerProfesor);
            this.Controls.Add(this.lblExtras);
            this.Controls.Add(this.lblInfo);
            this.Name = "frmHerencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Herencia Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblExtras;
        private System.Windows.Forms.Button btnObtenerProfesor;
        private System.Windows.Forms.Button btnObtenerEstudiante;
    }
}

