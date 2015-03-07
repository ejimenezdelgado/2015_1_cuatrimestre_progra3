using MecanicaUTN.Entidades;
using MecanicaUTN.Logica;
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
    public partial class frmUsuario : Form
    {
        bool esNuevo { set; get; }

        public frmUsuario()
        {
            InitializeComponent();
            this.CargarDatos();
            this.SoloLecturaObjetos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            UsuarioSql oUsuarioSql = new UsuarioSql();
            Usuario usuario = new Usuario();
            usuario.Nombre = txtNombre.Text;
            usuario.clave = txtClave.Text;
            usuario.EsAdmin = chkAdmin.Checked;
            if (esNuevo)
            {
                oUsuarioSql.AgregarUsuario(usuario);
                this.LimpiarObjetos();
                this.SoloLecturaObjetos();
                esNuevo = false;
            }
            else
            {
               // Repuesto repuestoSelecionado = (Repuesto)dtgRepuesto.SelectedRows[0].DataBoundItem;
               // oUsuarioSql.EditarRepuesto(repuestoSelecionado.Id, repuesto);
            }
            if (oUsuarioSql.HayError)
            {
                MessageBox.Show(oUsuarioSql.DescripcionError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                if (esNuevo)
                {
                    MessageBox.Show("Usuario agregado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario actulizado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.CargarDatos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            LimpiarObjetos();
            txtNombre.Focus();
            this.EditarObjetos();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            this.EditarObjetos();
         }

         private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
         {
             esNuevo = false;
             btnAceptar.Enabled = false;
             btnCancelar.Enabled = false;

             RepuestosSql oRepuestosCl = new RepuestosSql();
             Repuesto repuestoSelecionado = (Repuesto)dtgRepuesto.SelectedRows[0].DataBoundItem;
             DialogResult resultado = MessageBox.Show("Seguro quiere eliminar este elemento", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

             if (resultado == DialogResult.Yes)
             {

                 oRepuestosCl.EliminarRepuesto(repuestoSelecionado.Id);
                 if (oRepuestosCl.HayError)
                 {
                     MessageBox.Show(oRepuestosCl.DescripcionError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                 }
                 else
                 {
                     MessageBox.Show("Usuario eliminado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     this.CargarDatos();
                 }
             }
        }

        private void dtgRepuesto_SelectionChanged(object sender, EventArgs e)
        {

            if ((dtgRepuesto.SelectedRows.Count > 0) && !esNuevo)
            {
                this.SoloLecturaObjetos();
                Usuario usuario = (Usuario)dtgRepuesto.SelectedRows[0].DataBoundItem;

                txtNombre.Text = usuario.Nombre;
                chkAdmin.Checked = usuario.EsAdmin;
                txtNombre.Focus();
            }
        }

        #region
        
        private void CargarDatos()
        {
            UsuarioSql oUsuarioSql = new UsuarioSql();
          /*  List<Repuesto> repuestos = oUsuarioSql.TraerRepuestos();
            if (oUsuarioSql.HayError)
            {
                MessageBox.Show(oUsuarioSql.DescripcionError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            dtgRepuesto.DataSource = repuestos;*/
        }

        private void LimpiarObjetos()
        {
            txtNombre.Text = string.Empty;
            chkAdmin.Checked = false;
            txtClave.Text = string.Empty;
        }

        private void SoloLecturaObjetos()
        {
            txtNombre.ReadOnly = true;
            txtClave.ReadOnly = true;
            chkAdmin.Enabled = false;
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void EditarObjetos()
        {
            txtNombre.ReadOnly = false;
            txtClave.ReadOnly = true;
            chkAdmin.Enabled = true;
        }

        #endregion

    }
}
