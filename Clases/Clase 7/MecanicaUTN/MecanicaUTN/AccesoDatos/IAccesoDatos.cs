using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicaUTN.AccesoDatos
{
    public interface IAccesoDatos
    {
        void Conectar();

        void Escribir(string hilera);

        string Leer();

        void Editar(string id, string modificar);

        void Eliminar(string id);

        bool HayError { set; get; }

        string DescripcionError { set; get; }

    }
}
