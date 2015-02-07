using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaAbstracta.Logica
{
    public abstract class Persona
    {
        public abstract int SetId(int id);

        public abstract string SetNombre(string nombre);

        public abstract string SetApellidos(string apellidos);

        public abstract string ToString();
    }
}
