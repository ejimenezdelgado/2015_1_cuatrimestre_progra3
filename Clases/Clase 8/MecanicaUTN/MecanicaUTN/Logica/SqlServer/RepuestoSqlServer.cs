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

        public void AgregarRepuesto(Repuesto repuesto)
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

        public void EditarRepuesto(int id, Entidades.Repuesto repuesto)
        {
            var sql = new StringBuilder();

            sql.AppendLine("update repuesto set nombre=@nombre,modelo=@modelo,marca=@marca,cantidad=@cantidad,precio=@precio,impuesto=@impuesto,gravado=@gravado where id=@id");

            List<SqlParameter> parametros = new List<SqlParameter>
                {
                    new SqlParameter
                        {
                            ParameterName = "id",
                            SqlDbType = SqlDbType.Int,
                            SqlValue = id
                        },
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
            if (AccesoDatos.AccesoDatos.Instance.accesoDatos.HayError)
            {
                this.HayError = true;
                this.DescripcionError = AccesoDatos.AccesoDatos.Instance.accesoDatos.DescripcionError;
            }
        }

        public void EliminarRepuesto(int id)
        {
             var sql = new StringBuilder();

            sql.AppendLine("delete from repuesto where id=@id");

            List<SqlParameter> parametros = new List<SqlParameter>
                {
                    new SqlParameter
                        {
                            ParameterName = "id",
                            SqlDbType = SqlDbType.Int,
                            SqlValue = id
                        },
                };

             AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarSQL(sql.ToString(), parametros);
            if (AccesoDatos.AccesoDatos.Instance.accesoDatos.HayError)
            {
                this.HayError = true;
                this.DescripcionError = AccesoDatos.AccesoDatos.Instance.accesoDatos.DescripcionError;
            }
        }

        public List<Repuesto> TraerRepuestos()
        {
            var sql = new StringBuilder();

            sql.AppendLine("select * from repuesto");
            DataSet datos= AccesoDatos.AccesoDatos.Instance.accesoDatos.EjecutarConsultaSQL(sql.ToString());
            if (AccesoDatos.AccesoDatos.Instance.accesoDatos.HayError)
            {
                this.HayError = true;
                this.DescripcionError = AccesoDatos.AccesoDatos.Instance.accesoDatos.DescripcionError;
                return new List<Repuesto>();
            }
            List<Repuesto> repuestos= new List<Repuesto>();
            foreach (DataRow item in datos.Tables[0].Rows)
            {
                repuestos.Add(new Repuesto {
                    
                    Id=Convert.ToInt32(item["id"]),
                    Nombre = item["nombre"].ToString(),
                    Marca = item["marca"].ToString(),
                    Modelo = item["modelo"].ToString(),
                    Cantidad = Convert.ToDecimal(item["cantidad"]),
                    Precio = Convert.ToDecimal(item["precio"]),
                    Impuesto = Convert.ToDecimal(item["impuesto"]),
                    Gravado = Convert.ToBoolean(item["gravado"]),
                });
            }
            return repuestos;
        }

        public Boolean HayError { set; get; }

        public String DescripcionError { set; get; }
    }
}
