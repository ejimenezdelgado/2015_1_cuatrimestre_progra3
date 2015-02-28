using MecanicaUTN.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicaUTN.Logica.Intefaces
{
    public interface IUsuarioSql
    {
        void AgregarUsuario(Usuario usuario);

        void ValidarUsuario(Usuario usuario);
    }
}
