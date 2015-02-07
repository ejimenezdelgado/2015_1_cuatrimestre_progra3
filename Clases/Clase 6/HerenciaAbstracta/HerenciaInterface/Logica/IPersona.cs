using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaInterface.Logica
{
    public interface IPersona
    {
        void SetId(int id);
        void SetNombre(string nombre);
        void SetApellidos(string apellidos);
        string Impresion();

    }
}
