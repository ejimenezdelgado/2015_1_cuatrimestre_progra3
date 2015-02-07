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
            agregarRepuesto
        };

        public frmDashboard()
        {
            InitializeComponent();
        }

        public void mostrarFormulario(formulario formulario)
        {
           if(splPrincipal.Panel2.Controls.Count>0)
           {
               foreach (Control item in splPrincipal.Panel2.Controls)
	           {
                   splPrincipal.Panel2.Controls.Remove(item);
	           }              
           }
         

           switch (formulario)
            {
                case formulario.agregarRepuesto:

                   frmAgregarRepuesto ofrmAgregarRepuesto = new frmAgregarRepuesto();
                   ofrmAgregarRepuesto.TopLevel = false;
                   ofrmAgregarRepuesto.FormBorderStyle = FormBorderStyle.None;
                   ofrmAgregarRepuesto.Dock = DockStyle.Fill;
                   this.splPrincipal.Panel2.Controls.Add(ofrmAgregarRepuesto);
                   this.splPrincipal.Panel2.Tag = ofrmAgregarRepuesto;
                   ofrmAgregarRepuesto.Show();


                    break;
                default:
                    break;
            }   
        }

        private void agregarRespuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarFormulario(formulario.agregarRepuesto);
        }

    }
        
}
