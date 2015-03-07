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
            this.splPrincipal = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.repuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splPrincipal)).BeginInit();
            this.splPrincipal.Panel1.SuspendLayout();
            this.splPrincipal.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRepuesto,
            this.seguridadToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(563, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuRepuesto
            // 
            this.menuRepuesto.Name = "menuRepuesto";
            this.menuRepuesto.Size = new System.Drawing.Size(73, 20);
            this.menuRepuesto.Text = "Repuestos";
            this.menuRepuesto.Click += new System.EventHandler(this.menuRepuesto_Click);
            // 
            // splPrincipal
            // 
            this.splPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splPrincipal.Location = new System.Drawing.Point(0, 24);
            this.splPrincipal.Name = "splPrincipal";
            // 
            // splPrincipal.Panel1
            // 
            this.splPrincipal.Panel1.Controls.Add(this.menuStrip1);
            this.splPrincipal.Size = new System.Drawing.Size(563, 267);
            this.splPrincipal.SplitterDistance = 106;
            this.splPrincipal.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repuestoToolStripMenuItem,
            this.usuariosToolStripMenuItem1,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(98, 267);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // repuestoToolStripMenuItem
            // 
            this.repuestoToolStripMenuItem.Name = "repuestoToolStripMenuItem";
            this.repuestoToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.repuestoToolStripMenuItem.Size = new System.Drawing.Size(73, 19);
            this.repuestoToolStripMenuItem.Text = "Repuesto";
            this.repuestoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.repuestoToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.repuestoToolStripMenuItem.Click += new System.EventHandler(this.repuestoToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(73, 19);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ..";
            this.acercaDeToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem2});
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(85, 19);
            this.usuariosToolStripMenuItem1.Text = "Seguridad";
            this.usuariosToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // usuariosToolStripMenuItem2
            // 
            this.usuariosToolStripMenuItem2.Name = "usuariosToolStripMenuItem2";
            this.usuariosToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.usuariosToolStripMenuItem2.Text = "Usuarios";
            this.usuariosToolStripMenuItem2.Click += new System.EventHandler(this.usuariosToolStripMenuItem2_Click);
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
            this.splPrincipal.Panel1.ResumeLayout(false);
            this.splPrincipal.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splPrincipal)).EndInit();
            this.splPrincipal.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuRepuesto;
        private System.Windows.Forms.SplitContainer splPrincipal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem repuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem2;

    }
}