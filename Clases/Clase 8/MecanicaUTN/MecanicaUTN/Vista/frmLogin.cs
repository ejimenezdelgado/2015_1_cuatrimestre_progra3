using MecanicaUTN.Entidades;
using MecanicaUTN.Logica;
using MecanicaUTN.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MecanicaUTN
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            UsuarioSql oUsuarioSql = new UsuarioSql();
            Usuario oUsuario=new Usuario();
            oUsuario.Nombre=txtUsuario.Text;
            oUsuario.clave=txtClave.Text;
            Usuario usuarioSelecionado= oUsuarioSql.ValidarUsuario(oUsuario);
            if (usuarioSelecionado!=null)
            {
                this.Hide();
              /*  MessageBox.Show("Gracias por ingresar", "Información", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);*/
                frmDashboard ofrmDashboard = new frmDashboard();
                ofrmDashboard.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("Usuario y clave erróneos", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
