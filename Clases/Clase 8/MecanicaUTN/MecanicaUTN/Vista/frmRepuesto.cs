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
    public partial class frmRepuesto : Form
    {
        bool esNuevo { set; get; }

        public frmRepuesto()
        {
            InitializeComponent();
            this.CargarDatos();
            this.SoloLecturaObjetos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RepuestosSql oRepuestosSql = new RepuestosSql();
            Repuesto repuesto = new Repuesto();
            repuesto.Nombre = txtNombre.Text;
            repuesto.Modelo = txtModelo.Text;
            repuesto.Marca = txtMarca.Text;
            repuesto.Cantidad = (decimal)txtCantidad.Value;
            repuesto.Precio = (decimal)txtPrecio.Value;
            repuesto.Impuesto = (decimal)txtImpuesto.Value;
            repuesto.Gravado = chkGravado.Checked;
            if (esNuevo)
            {
                oRepuestosSql.AgregarRepuesto(repuesto);
                this.LimpiarObjetos();
                this.SoloLecturaObjetos();
                esNuevo = false;
            }
            else
            {
                Repuesto repuestoSelecionado = (Repuesto)dtgRepuesto.SelectedRows[0].DataBoundItem;
                oRepuestosSql.EditarRepuesto(repuestoSelecionado.Id, repuesto);
            }
            if (oRepuestosSql.HayError)
            {
                MessageBox.Show(oRepuestosSql.DescripcionError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                if (esNuevo)
                {
                    MessageBox.Show("Repuesto agregado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Repuesto actulizado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                     MessageBox.Show("Repuesto eliminado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     this.CargarDatos();
                 }
             }
        }

        private void dtgRepuesto_SelectionChanged(object sender, EventArgs e)
        {

            if ((dtgRepuesto.SelectedRows.Count > 0) && !esNuevo)
            {
                this.SoloLecturaObjetos();
                Repuesto repuesto = (Repuesto)dtgRepuesto.SelectedRows[0].DataBoundItem;

                txtNombre.Text = repuesto.Nombre;
                txtModelo.Text = repuesto.Modelo;
                txtMarca.Text = repuesto.Marca;
                txtCantidad.Value = repuesto.Cantidad;
                txtPrecio.Value = repuesto.Precio;
                txtImpuesto.Value = repuesto.Impuesto;
                chkGravado.Checked = repuesto.Gravado;
                txtNombre.Focus();
            }
        }

        #region
        
        private void CargarDatos()
        {
            RepuestosSql oRepuestosCl = new RepuestosSql();
            List<Repuesto> repuestos = oRepuestosCl.TraerRepuestos();
            if (oRepuestosCl.HayError)
            {
                MessageBox.Show(oRepuestosCl.DescripcionError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            dtgRepuesto.DataSource = repuestos;
        }

        private void LimpiarObjetos()
        {
            txtNombre.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtCantidad.Value = 0;
            txtPrecio.Value = 0;
            txtImpuesto.Value = 0;
            chkGravado.Checked = false;
        }

        private void SoloLecturaObjetos()
        {
            txtNombre.ReadOnly = true;
            txtModelo.ReadOnly = true;
            txtMarca.ReadOnly = true;
            txtCantidad.ReadOnly = true;
            txtPrecio.ReadOnly = true;
            txtImpuesto.ReadOnly = true;
            chkGravado.Enabled = false;
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void EditarObjetos()
        {
            txtNombre.ReadOnly = false;
            txtModelo.ReadOnly = false;
            txtMarca.ReadOnly = false;
            txtCantidad.ReadOnly = false;
            txtPrecio.ReadOnly = false;
            txtImpuesto.ReadOnly = false;
            chkGravado.Enabled = true;
        }

        #endregion

    }
}
