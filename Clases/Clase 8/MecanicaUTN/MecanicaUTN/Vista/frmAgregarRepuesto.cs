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
    public partial class frmAgregarRepuesto : Form
    {
        public frmAgregarRepuesto()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RepuestosCL oRepuestosCl = new RepuestosCL();
          /*  oRepuestosCl.AgregarRepuesto(txtNombre.Text, txtModelo.Text,
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
                this.Close();
            }*/
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
