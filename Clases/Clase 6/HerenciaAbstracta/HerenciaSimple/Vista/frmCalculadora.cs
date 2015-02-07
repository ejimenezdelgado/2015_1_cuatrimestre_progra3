using HerenciaSimple.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciaSimple
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CalculadoraMejorada oCalculadoraMejorada =new CalculadoraMejorada();

            oCalculadoraMejorada.A = Convert.ToInt32(txtNumero1.Text);
            oCalculadoraMejorada.B = Convert.ToInt32(txtNumero2.Text);

            if(cmbOperacion.SelectedIndex==0)
            {
                lblResultado.Text = oCalculadoraMejorada.ResultadoSumatoria().ToString();
            }

            if (cmbOperacion.SelectedIndex == 1)
            {
                lblResultado.Text = oCalculadoraMejorada.ResultadoResta().ToString();
            }

            if (cmbOperacion.SelectedIndex == 2)
            {
                lblResultado.Text = oCalculadoraMejorada.ResultadoDivision().ToString();
            }

            if (cmbOperacion.SelectedIndex == 3)
            {
                lblResultado.Text = oCalculadoraMejorada.ResultadoMultiplicacion().ToString();
            }
        }
    }
}
