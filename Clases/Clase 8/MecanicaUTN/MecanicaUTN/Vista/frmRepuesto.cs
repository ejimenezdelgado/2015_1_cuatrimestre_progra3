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
            RepuestosCL oRepuestosCl = new RepuestosCL();
           /* oRepuestosCl.AgregarRepuesto(txtNombre.Text, txtModelo.Text,
                                         txtMarca.Text, (int)txtCantidad.Value,
                                         (int)txtPrecio.Value,
                                         (int)txtImpuesto.Value,
                                         chkGravado.Checked);

            if (oRepuestosCl.HayError)
            {
                MessageBox.Show(oRepuestosCl.DescripcionError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                MessageBox.Show("Repuesto agregado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.CargarDatos();
            }*/
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatos()
        {
            RepuestosCL oRepuestosCl = new RepuestosCL();
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

            RepuestosCL oRepuestosCl = new RepuestosCL();
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
