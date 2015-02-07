using HerenciaAbstracta.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciaAbstracta
{
    public partial class frmHerencia : Form
    {
        public frmHerencia()
        {
            InitializeComponent();
        }

        private void btnObtenerProfesor_Click(object sender, EventArgs e)
        {
            Persona oPersona = new Profesor();
            Profesor oProfesor;

            oPersona.SetId(1);
            oPersona.SetNombre("Efren");
            oPersona.SetApellidos("Jimenez Delgado");

            oProfesor = (Profesor)oPersona;
            oProfesor.Carrera = "ISW";
            oProfesor.Cursos = "ISW 311";

            lblInfo.Text = oProfesor.ToString();
            lblExtras.Text = oProfesor.Carrera + "-"+oProfesor.Cursos;
        }

        private void btnObtenerEstudiante_Click(object sender, EventArgs e)
        {
            Persona oPersona = new Estudiante();
            Estudiante oEstudiante;

            oPersona.SetId(1);
            oPersona.SetNombre("Isabel");
            oPersona.SetApellidos("Perez Zeledon");

            oEstudiante = (Estudiante)oPersona;
            oEstudiante.Calificaciones = 100;
            oEstudiante.Notas = "Excelente estudiante";

            lblInfo.Text = oEstudiante.ToString();
            lblExtras.Text = oEstudiante.Calificaciones + "-" + oEstudiante.Notas;
        }

        
    }
}
