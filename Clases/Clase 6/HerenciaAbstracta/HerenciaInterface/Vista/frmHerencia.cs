using HerenciaInterface.Logica;
using HerenciaInterface.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciaInterface
{
    public partial class frmHerencia : Form
    {
        public frmHerencia()
        {
            InitializeComponent();
        }

        private void btnObtenerProfesor_Click(object sender, EventArgs e)
        {
            IPersona oPersona = new Profesor();
            Profesor oProfesor;

            oPersona.SetId(1);
            oPersona.SetNombre("Efren");
            oPersona.SetApellidos("Jimenez Delgado");

            oProfesor = (Profesor)oPersona;
            oProfesor.Carrera = "ISW";
            oProfesor.Cursos = "ISW 311";

            lblInfo.Text = oProfesor.Impresion();
            lblExtras.Text = oProfesor.Carrera + "-"+oProfesor.Cursos;
        }

        private void btnObtenerEstudiante_Click(object sender, EventArgs e)
        {
            IPersona oPersona = new Estudiante();
            Estudiante oEstudiante;

            oPersona.SetId(1);
            oPersona.SetNombre("Isabel");
            oPersona.SetApellidos("Perez Zeledon");

            oEstudiante = (Estudiante)oPersona;
            oEstudiante.Calificaciones = 100;
            oEstudiante.Notas = "Excelente estudiante";

            lblInfo.Text = oEstudiante.Impresion();
            lblExtras.Text = oEstudiante.Calificaciones + "-" + oEstudiante.Notas;
        }

        
    }
}
