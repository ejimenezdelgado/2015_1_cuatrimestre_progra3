using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MecanicaUTN.AccesoDatos;
using MecanicaUTN.Logica.Intefaces;
using MecanicaUTN.Logica.SqlServer;
using MecanicaUTN.Entidades;
using MecanicaUTN.Logica.Postgres;


namespace MecanicaUTN.Logica
{
    public class UsuarioSql:IUsuarioSql
    {
        /**/
        public Boolean HayError { set; get; }
        public String DescripcionError { set; get; }

        public IUsuarioSql ObtenerInstancia()
        {
            IUsuarioSql usuarioSql = null;
            switch (AccesoDatos.AccesoDatos.Instance.accesoDatos.ContextDataBase)
            {
                case ContextDataBase.SqlServer:
                    usuarioSql = null;
                    break;
                case ContextDataBase.PostgreSql:
                    usuarioSql = new UsuarioPostgres();
                    break;
                default:
                    break;
            }
            return usuarioSql;
        }

        public void AgregarUsuario(Usuario usuario)
        {
            IUsuarioSql usuarioSql = this.ObtenerInstancia();
            usuarioSql.AgregarUsuario(usuario);
            if (usuarioSql.HayError)
            {
                this.HayError = true;
                this.DescripcionError = usuarioSql.DescripcionError;
            }
        }

        public Usuario ValidarUsuario(Usuario usuario)
        {
            IUsuarioSql usuarioSql = this.ObtenerInstancia();
            Usuario usuarioSelecionado= usuarioSql.ValidarUsuario(usuario);
            if (usuarioSql.HayError)
            {
                this.HayError = true;
                this.DescripcionError = usuarioSql.DescripcionError;
            }
            return usuarioSelecionado;
        }
    }
}
