using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1.Logica
{
    public class Estudiante
    {
        public string Calificacion(string nota)
        {
            if(nota=="A")
            {
                return "Calificación excelente";
            }
            else
            {
                return "Alumno regular";
            }
        }
    }
}
