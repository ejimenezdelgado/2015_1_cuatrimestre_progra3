using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerenciaInterface.Logica;

namespace HerenciaInterface.Logica
{
    public class Profesor:IPersona
    {

        private int id;
        private string nombre;
        private string apellidos;

        #region Metodos de la herencia

        public void SetId(int id)
        {
            this.id = id;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetApellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }

        public string Impresion()
        {
            return "El id es " + id + " , El nombre es : " + nombre + " " + apellidos;
        }

        #endregion

        #region Metodos de la clase

        public string Carrera { set; get; }

        public string Cursos { set; get; }

        #endregion


    }
}
