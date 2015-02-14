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
            repuesto
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
                case formulario.repuesto:

                    frmRepuesto ofrmRepuesto = new frmRepuesto();
                    ofrmRepuesto.TopLevel = false;
                    ofrmRepuesto.FormBorderStyle = FormBorderStyle.None;
                    ofrmRepuesto.Dock = DockStyle.Fill;
                    this.splPrincipal.Panel2.Controls.Add(ofrmRepuesto);
                    this.splPrincipal.Panel2.Tag = ofrmRepuesto;
                    ofrmRepuesto.Show();


                    break;
                default:
                    break;
            }   
        }

        private void menuRepuesto_Click(object sender, EventArgs e)
        {
            mostrarFormulario(formulario.repuesto);
        }

    }
        
}
