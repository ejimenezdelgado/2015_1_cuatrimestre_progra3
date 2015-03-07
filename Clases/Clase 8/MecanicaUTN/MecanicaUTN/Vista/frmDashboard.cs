using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MecanicaUTN.Vista
{
    public partial class frmDashboard : Form
    {
        public enum formulario
        {
            repuesto,
            usuario
        };

        public frmDashboard()
        {
            InitializeComponent();
        }

        public void mostrarFormulario(formulario formulario)
        {
            if (splPrincipal.Panel2.Controls.Count > 0)
            {
                foreach (Control item in splPrincipal.Panel2.Controls)
                {
                    splPrincipal.Panel2.Controls.Remove(item);
                }
            }


            switch (formulario)
            {
                case formulario.repuesto:
                    frmRepuesto ofrmRepuesto = new frmRepuesto();
                    ofrmRepuesto.TopLevel = false;
                    ofrmRepuesto.FormBorderStyle = FormBorderStyle.None;
                    ofrmRepuesto.Dock = DockStyle.Fill;
                    this.splPrincipal.Panel2.Controls.Add(ofrmRepuesto);
                    this.splPrincipal.Panel2.Tag = ofrmRepuesto;
                    ofrmRepuesto.Show();
                    break;
                case formulario.usuario:
                    frmUsuario ofrmUsuario = new frmUsuario();
                    ofrmUsuario.TopLevel = false;
                    ofrmUsuario.FormBorderStyle = FormBorderStyle.None;
                    ofrmUsuario.Dock = DockStyle.Fill;
                    this.splPrincipal.Panel2.Controls.Add(ofrmUsuario);
                    this.splPrincipal.Panel2.Tag = ofrmUsuario;
                    ofrmUsuario.Show();
                    break;
                default:
                    break;
            }           
            
        }

        private void menuRepuesto_Click(object sender, EventArgs e)
        {
            mostrarFormulario(formulario.repuesto);
        }

        private void repuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormulario(formulario.repuesto);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.oUsuario.EsAdmin)
            {
                mostrarFormulario(formulario.usuario);
            }
            else
            {
                MessageBox.Show( "Este usuario no tiene permisos para realizar esta accion","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usuariosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Program.oUsuario.EsAdmin)
            {
                mostrarFormulario(formulario.usuario);
            }
            else
            {
                MessageBox.Show("Advertencia", "Este usuario no tiene permisos para realizar esta accion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
        
}
