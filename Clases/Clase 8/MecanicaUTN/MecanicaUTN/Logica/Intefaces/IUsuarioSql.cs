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
        Usuario ValidarUsuario(Usuario usuario);
        Boolean HayError { set; get; }
        String DescripcionError { set; get; }
    }
}
