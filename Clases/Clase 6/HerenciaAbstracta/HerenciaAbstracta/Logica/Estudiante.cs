using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaAbstracta.Logica
{
    public class Estudiante:Persona
    {
        private int id;
        private string nombre;
        private string apellidos;

        #region Metodos de la herencia

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

        #endregion

        #region Metodos de la clase

        public int Calificaciones { set; get; }

        public string Notas { set; get; }


        #endregion
    }
}
