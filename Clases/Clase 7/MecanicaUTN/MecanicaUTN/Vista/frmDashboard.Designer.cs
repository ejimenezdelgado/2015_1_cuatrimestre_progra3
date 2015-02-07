namespace MecanicaUTN.Vista
{
    partial class frmDashboard
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuRepuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarRespuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splPrincipal = new System.Windows.Forms.SplitContainer();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splPrincipal)).BeginInit();
            this.splPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRepuesto});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(563, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuRepuesto
            // 
            this.menuRepuesto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarRespuestoToolStripMenuItem});
            this.menuRepuesto.Name = "menuRepuesto";
            this.menuRepuesto.Size = new System.Drawing.Size(73, 20);
            this.menuRepuesto.Text = "Repuestos";
            // 
            // agregarRespuestoToolStripMenuItem
            // 
            this.agregarRespuestoToolStripMenuItem.Name = "agregarRespuestoToolStripMenuItem";
            this.agregarRespuestoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.agregarRespuestoToolStripMenuItem.Text = "Agregar respuesto";
            this.agregarRespuestoToolStripMenuItem.Click += new System.EventHandler(this.agregarRespuestoToolStripMenuItem_Click);
            // 
            // splPrincipal
            // 
            this.splPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splPrincipal.Location = new System.Drawing.Point(0, 24);
            this.splPrincipal.Name = "splPrincipal";
            this.splPrincipal.Size = new System.Drawing.Size(563, 267);
            this.splPrincipal.SplitterDistance = 106;
            this.splPrincipal.TabIndex = 1;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 291);
            this.Controls.Add(this.splPrincipal);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splPrincipal)).EndInit();
            this.splPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuRepuesto;
        private System.Windows.Forms.ToolStripMenuItem agregarRespuestoToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splPrincipal;

    }
}