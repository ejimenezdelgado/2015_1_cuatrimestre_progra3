using MecanicaUTN.Entidades;
using MecanicaUTN.Logica.Intefaces;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicaUTN.Logica.Postgres
{
    public class UsuarioPostgres : IUsuarioSql
    {
        public void AgregarUsuario(Usuario usuario)
        {

            var sql = new StringBuilder();

            sql.AppendLine("insert into usuario (nombre,clave,admin) values (@nombre,md5(@clave),@admin)");

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "nombre",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = usuario.Nombre
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "clave",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = usuario.clave
                        },                        
                         new NpgsqlParameter
                            {
                            ParameterName = "admin",
                            NpgsqlDbType = NpgsqlDbType.Boolean,
                            NpgsqlValue = usuario.EsAdmin
                        },
                };

            AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.AccesoDatos.Instance.accesoDatos.HayError)
            {
                this.HayError = true;
                this.DescripcionError = AccesoDatos.AccesoDatos.Instance.accesoDatos.DescripcionError;
            }
        }

        public Usuario ValidarUsuario(Usuario usuario)
        {
            var sql = new StringBuilder();
            Usuario usuarioSelecionado=new Usuario();

            sql.AppendLine("select * from usuario where nombre=@nombre and clave=md5(@clave)");
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "nombre",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = usuario.Nombre
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "clave",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = usuario.clave
                        }
                };

            DataSet datos = AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString(),parametros);
            if (AccesoDatos.AccesoDatos.Instance.accesoDatos.HayError)
            {
                this.HayError = true;
                this.DescripcionError = AccesoDatos.AccesoDatos.Instance.accesoDatos.DescripcionError;
            }
            if (datos.Tables.Count > 0)
            {
                if (datos.Tables[0].Rows.Count > 0)
                {
                    usuarioSelecionado = new Usuario();
                    usuarioSelecionado.Nombre = datos.Tables[0].Rows[0]["nombre"].ToString();
                    usuarioSelecionado.Nombre = usuario.clave;
                    usuarioSelecionado.EsAdmin =(Boolean) datos.Tables[0].Rows[0]["admin"];
                }

            }
            return usuarioSelecionado;
        }

        public Boolean HayError { set; get; }

        public String DescripcionError { set; get; }

        

        
    }
}
