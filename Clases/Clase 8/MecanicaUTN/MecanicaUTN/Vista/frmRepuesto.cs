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
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RepuestosSql oRepuestosSql = new RepuestosSql();
            Repuesto repuesto = new Repuesto();
            repuesto.Nombre=txtNombre.Text;
            repuesto.Modelo= txtModelo.Text;
            repuesto.Marca= txtMarca.Text;
            repuesto.Cantidad= (int)txtCantidad.Value;
            repuesto.Precio= (double)txtPrecio.Value;
            repuesto.Impuesto= (int)txtImpuesto.Value;
            repuesto.Gravado= chkGravado.Checked;

            oRepuestosSql.AgregarRepuesto(repuesto);

            if (oRepuestosSql.HayError)
            {
                MessageBox.Show(oRepuestosSql.DescripcionError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                MessageBox.Show("Repuesto agregado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.CargarDatos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatos()
        {
            RepuestosSql oRepuestosCl = new RepuestosSql();
           // dtgRepuesto.DataSource=oRepuestosCl.ObtenerRepuestos();
        }



        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            txtNombre.Focus();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;

            txtNombre.Text = dtgRepuesto.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;

            RepuestosSql oRepuestosCl = new RepuestosSql();
           /* oRepuestosCl.EliminarRepuesto(dtgRepuesto.SelectedRows[0].Cells[0].Value.ToString());
            if (oRepuestosCl.HayError)
            {
                MessageBox.Show(oRepuestosCl.DescripcionError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                MessageBox.Show("Repuesto eliminado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.CargarDatos();
            }*/
        }



    }
}
