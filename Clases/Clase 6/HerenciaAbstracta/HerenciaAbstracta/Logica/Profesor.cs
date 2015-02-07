using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaAbstracta.Logica
{
    public class Profesor:Persona
    {

        private int id;
        private string nombre;
        private string apellidos;

        public override int SetId(int id)
        {
            this.id = id;
            return id;
        }

        public override string SetNombre(string nombre)
        {
            this.nombre = nombre;
            return nombre;
        }

        public override string SetApellidos(string apellidos)
        {
            this.apellidos = apellidos;
            return apellidos;
        }

        public override string ToString()
        {
            return "El id es " + id + " , El nombre es : " + nombre + " " + apellidos;
        }

        #region Metodos de la clase

        public string Carrera { set; get; }

        public string Cursos { set; get; }

        #endregion


    }
}
