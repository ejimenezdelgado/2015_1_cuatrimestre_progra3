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
    public class RepuestoPostgres: IRepuestoSql
    {

        public void AgregarRepuesto(Repuesto repuesto)
        {
            var sql = new StringBuilder();

            sql.AppendLine("insert into repuesto (nombre,modelo,marca,cantidad,precio,impuesto,gravado) values (@nombre,@modelo,@marca,@cantidad,@precio,@impuesto,@gravado)");

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "nombre",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = repuesto.Nombre
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "modelo",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = repuesto.Modelo
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "marca",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = repuesto.Marca
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "cantidad",
                            NpgsqlDbType = NpgsqlDbType.Numeric,
                            NpgsqlValue = repuesto.Cantidad
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "precio",
                            NpgsqlDbType = NpgsqlDbType.Numeric,
                            NpgsqlValue = repuesto.Precio
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "impuesto",
                            NpgsqlDbType = NpgsqlDbType.Numeric,
                            NpgsqlValue = repuesto.Impuesto
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "gravado",
                            NpgsqlDbType = NpgsqlDbType.Bit,
                            NpgsqlValue = repuesto.Gravado
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

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "id",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = id
                        },
                    new NpgsqlParameter
                        {
                            ParameterName = "nombre",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = repuesto.Nombre
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "modelo",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = repuesto.Modelo
                        },
                        new NpgsqlParameter
                            {
                            ParameterName = "marca",
                            NpgsqlDbType = NpgsqlDbType.Varchar,
                            NpgsqlValue = repuesto.Marca
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "cantidad",
                            NpgsqlDbType = NpgsqlDbType.Numeric,
                            NpgsqlValue = repuesto.Cantidad
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "precio",
                            NpgsqlDbType = NpgsqlDbType.Numeric,
                            NpgsqlValue = repuesto.Precio
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "impuesto",
                            NpgsqlDbType = NpgsqlDbType.Numeric,
                            NpgsqlValue = repuesto.Impuesto
                        },
                         new NpgsqlParameter
                            {
                            ParameterName = "gravado",
                            NpgsqlDbType = NpgsqlDbType.Bit,
                            NpgsqlValue = repuesto.Gravado
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

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter
                        {
                            ParameterName = "id",
                            NpgsqlDbType = NpgsqlDbType.Integer,
                            NpgsqlValue = id
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
