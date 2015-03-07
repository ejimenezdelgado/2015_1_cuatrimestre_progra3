namespace MecanicaUTN.Vista
{
    partial class frmUsuario
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.splRepuesto = new System.Windows.Forms.SplitContainer();
            this.dtgRepuesto = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splRepuesto)).BeginInit();
            this.splRepuesto.Panel1.SuspendLayout();
            this.splRepuesto.Panel2.SuspendLayout();
            this.splRepuesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRepuesto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(166, 304);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(73, 304);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 43;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Location = new System.Drawing.Point(73, 100);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(89, 17);
            this.chkAdmin.TabIndex = 42;
            this.chkAdmin.Text = "Administrador";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(229, 20);
            this.txtNombre.TabIndex = 31;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 30;
            this.lblNombre.Text = "Nombre:";
            // 
            // splRepuesto
            // 
            this.splRepuesto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splRepuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splRepuesto.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splRepuesto.Location = new System.Drawing.Point(0, 0);
            this.splRepuesto.Name = "splRepuesto";
            // 
            // splRepuesto.Panel1
            // 
            this.splRepuesto.Panel1.Controls.Add(this.lblClave);
            this.splRepuesto.Panel1.Controls.Add(this.txtClave);
            this.splRepuesto.Panel1.Controls.Add(this.btnCancelar);
            this.splRepuesto.Panel1.Controls.Add(this.btnAceptar);
            this.splRepuesto.Panel1.Controls.Add(this.lblNombre);
            this.splRepuesto.Panel1.Controls.Add(this.chkAdmin);
            this.splRepuesto.Panel1.Controls.Add(this.txtNombre);
            // 
            // splRepuesto.Panel2
            // 
            this.splRepuesto.Panel2.Controls.Add(this.dtgRepuesto);
            this.splRepuesto.Panel2.Controls.Add(this.menuStrip1);
            this.splRepuesto.Size = new System.Drawing.Size(741, 466);
            this.splRepuesto.SplitterDistance = 320;
            this.splRepuesto.SplitterWidth = 10;
            this.splRepuesto.TabIndex = 45;
            // 
            // dtgRepuesto
            // 
            this.dtgRepuesto.AllowUserToAddRows = false;
            this.dtgRepuesto.AllowUserToDeleteRows = false;
            this.dtgRepuesto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgRepuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRepuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRepuesto.Location = new System.Drawing.Point(0, 47);
            this.dtgRepuesto.MultiSelect = false;
            this.dtgRepuesto.Name = "dtgRepuesto";
            this.dtgRepuesto.ReadOnly = true;
            this.dtgRepuesto.Size = new System.Drawing.Size(407, 415);
            this.dtgRepuesto.TabIndex = 0;
            this.dtgRepuesto.SelectionChanged += new System.EventHandler(this.dtgRepuesto_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(407, 47);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = global::MecanicaUTN.Properties.Resources._1423367308_Add;
            this.nuevoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 43);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = global::MecanicaUTN.Properties.Resources.accessories_text_editor;
            this.editarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 43);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = global::MecanicaUTN.Properties.Resources.descarga;
            this.eliminarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 43);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(12, 68);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(37, 13);
            this.lblClave.TabIndex = 45;
            this.lblClave.Text = "Clave:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(73, 61);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(229, 20);
            this.txtClave.TabIndex = 46;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 466);
            this.Controls.Add(this.splRepuesto);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUsuario";
            this.Text = "Usuario";
            this.splRepuesto.Panel1.ResumeLayout(false);
            this.splRepuesto.Panel1.PerformLayout();
            this.splRepuesto.Panel2.ResumeLayout(false);
            this.splRepuesto.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splRepuesto)).EndInit();
            this.splRepuesto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRepuesto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.SplitContainer splRepuesto;
        private System.Windows.Forms.DataGridView dtgRepuesto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
    }
}