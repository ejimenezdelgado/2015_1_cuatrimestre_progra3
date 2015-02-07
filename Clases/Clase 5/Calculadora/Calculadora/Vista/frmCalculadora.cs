using Calculadora.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        Operacion oOperacion;
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            oOperacion = new Operacion();

            lblResultado.Text = oOperacion.Suma(
                Convert.ToDouble(txtNumero1.Text), 
                Convert.ToDouble(txtNumero2.Text)).ToString();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            oOperacion = new Operacion();

            lblResultado.Text = oOperacion.Resta(
                Convert.ToDouble(txtNumero1.Text),
                Convert.ToDouble(txtNumero2.Text)).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            oOperacion = new Operacion();

            lblResultado.Text = oOperacion.Multiplicacion(
                Convert.ToDouble(txtNumero1.Text),
                Convert.ToDouble(txtNumero2.Text)).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            oOperacion = new Operacion();

            lblResultado.Text = oOperacion.Division(
                Convert.ToDouble(txtNumero1.Text),
                Convert.ToDouble(txtNumero2.Text)).ToString();
        }
    }
}
