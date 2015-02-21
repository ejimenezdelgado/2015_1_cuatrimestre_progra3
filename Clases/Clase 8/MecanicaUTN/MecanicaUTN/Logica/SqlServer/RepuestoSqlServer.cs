using MecanicaUTN.Entidades;
using MecanicaUTN.Logica.Intefaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicaUTN.Logica.SqlServer
{
    public class RepuestoSqlServer:IRepuestoSql
    {

        public void Agregar(Repuesto repuesto)
        {
            var sql = new StringBuilder();

            sql.AppendLine("insert into repuesto (nombre,modelo,marca,cantidad,precio,impuesto,gravado) values (@nombre,@modelo,@marca,@cantidad,@precio,@impuesto,@gravado)");

            List<SqlParameter> parametros = new List<SqlParameter>
                {
                    new SqlParameter
                        {
                            ParameterName = "nombre",
                            SqlDbType = SqlDbType.VarChar,
                            SqlValue = repuesto.Nombre
                        },
                        new SqlParameter
                            {
                            ParameterName = "modelo",
                            SqlDbType = SqlDbType.VarChar,
                            SqlValue = repuesto.Modelo
                        },
                        new SqlParameter
                            {
                            ParameterName = "marca",
                            SqlDbType = SqlDbType.VarChar,
                            SqlValue = repuesto.Marca
                        },
                         new SqlParameter
                            {
                            ParameterName = "cantidad",
                            SqlDbType = SqlDbType.Int,
                            SqlValue = repuesto.Cantidad
                        },
                         new SqlParameter
                            {
                            ParameterName = "precio",
                            SqlDbType = SqlDbType.Float,
                            SqlValue = repuesto.Precio
                        },
                         new SqlParameter
                            {
                            ParameterName = "impuesto",
                            SqlDbType = SqlDbType.Float,
                            SqlValue = repuesto.Impuesto
                        },
                         new SqlParameter
                            {
                            ParameterName = "gravado",
                            SqlDbType = SqlDbType.Bit,
                            SqlValue = repuesto.Gravado
                        },
                };

            AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if(AccesoDatos.AccesoDatos.Instance.accesoDatos.HayError)
            {
                this.HayError = true;
                this.DescripcionError = AccesoDatos.AccesoDatos.Instance.accesoDatos.DescripcionError;
            }
        }

        public void Editar(int id, Entidades.Repuesto repuesto)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Entidades.Repuesto> TraerRepuestos()
        {
            throw new NotImplementedException();
        }

        public Boolean HayError { set; get; }

        public String DescripcionError { set; get; }
    }
}
