using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicaUTN.AccesoDatos
{
    public class AccesoDatosPosgrest : IAccesoDatos
    {

        // Constructor
        public AccesoDatosPosgrest(String servidor, String usuario, String contrasena, String baseDatos)
        {
            this.LimpiarEstado();
            Conexion = new NpgsqlConnection("Data Source=" + servidor + ";UID=" + usuario + ";PWD=" + contrasena + ";Initial Catalog=" + baseDatos);

            Instancias += 1;
            // no puede haber + de una instancia de la clase
            if (Instancias > 1)
                return;
            try
            {
                Conexion.Open();
            }
            catch (Exception error)
            {
                this.HayError = true;
                this.DescripcionError = "Error de Conexión \n";
                this.DescripcionError += error.Message;
                Instancias = 0;
            }
        }


        // destructor
        ~AccesoDatosPosgrest()
        {
            try
            {
                Conexion.Close();
            }
            catch (Exception error)
            {
                this.HayError = true;
                this.DescripcionError = "Error de Conexión \n";
                this.DescripcionError += error.Message;
            }
        }

        #region Métodos de conexion

        // Indica el estado de la persistencia
        public Boolean Estado()
        {
            string mensaje = "";
            this.LimpiarEstado();
            // estado dela conexión
            switch (Conexion.State)
            {
                case System.Data.ConnectionState.Broken: mensaje = "Quebrada";
                    break;
                case System.Data.ConnectionState.Closed: mensaje = "Cerrada";
                    break;
                case System.Data.ConnectionState.Connecting: mensaje = "Conectandose";
                    break;
                case System.Data.ConnectionState.Executing: mensaje = "Ejecutando";
                    break;
                case System.Data.ConnectionState.Fetching: mensaje = "Extrayendo";
                    break;
                case System.Data.ConnectionState.Open: mensaje = "Abierta";
                    break;
            }

            // cargar la propiedad con el estado de la conexion
            this.DescripcionError = mensaje;

            if ((Conexion.State == ConnectionState.Open) ||
                  (Conexion.State == ConnectionState.Executing) ||
                  (Conexion.State == ConnectionState.Fetching))
                return true;
            return false;
        }

        public DataSet EjecutarConsultaSQL(String sql)
        {
            this.LimpiarEstado();
            var oDataSet = new DataSet();
            try
            {
                var oDataAdapter = new NpgsqlDataAdapter(sql, Conexion);
                if (this.HayTransaccion)
                {
                    oDataAdapter.SelectCommand.Transaction = this.Transaccion;
                }
                oDataAdapter.Fill(oDataSet);
            }
            catch (Exception error)
            {
                this.HayError = true;
                this.DescripcionError = "Error en ejecutarConsultaSQL \n";
                this.DescripcionError += error.Message;
            }
            return oDataSet;
        }

        public DataSet EjecutarConsultaSQL(String sql, IEnumerable parametros)
        {
            this.LimpiarEstado();
            var oDataSet = new DataSet();
            try
            {
                var oDataAdapter = new NpgsqlDataAdapter(sql, Conexion);
                var cmd = new NpgsqlCommand(sql, Conexion);
                foreach (NpgsqlParameter parametro in parametros)
                {
                    cmd.Parameters.Add(parametro);
                }
                oDataAdapter.SelectCommand = cmd;

                if (this.HayTransaccion)
                {
                    oDataAdapter.SelectCommand.Transaction = this.Transaccion;
                }
                oDataAdapter.Fill(oDataSet);
            }
            catch (Exception error)
            {
                this.HayError = true;
                this.DescripcionError = "Error en ejecutarConsultaSQL \n";
                this.DescripcionError += error.Message;
            }
            return oDataSet;
        }

        public void EjecutarSQL(string sql, IEnumerable parametros)
        {
            try
            {
                this.LimpiarEstado();
                var cmd = new NpgsqlCommand(sql, Conexion);
                foreach (NpgsqlParameter parametro in parametros)
                {
                    cmd.Parameters.Add(parametro);
                }
                if (this.HayTransaccion)
                {
                    cmd.Transaction = this.Transaccion;
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                this.HayError = true;
                this.DescripcionError = "Error en ejecutarSQL \n";
                this.DescripcionError += error.Message;
            }
        }

        // Método para manipular DQL (Select) Para busquedas escalares SUM(), Count(), Etc.
        public Int32 EjecutarScalarSQL(String pSql)
        {
            int resultado = 0;
            var cmd = new NpgsqlCommand(pSql, Conexion);
            this.HayError = false;

            // capturar la excepción
            try
            {
                resultado = (Int32)cmd.ExecuteScalar();
            }
            catch (Exception error)
            {
                this.HayError = true;
                this.DescripcionError = "Error en ejecutarConsultaSQL \n";
                this.DescripcionError += error.Message;
            }
            return resultado;
        }

        // Método para manipular DQL (Select) Exclusivo para carga de listas y combos
        public DataSet EjecutarSQLListas(String sql, String tabla)
        {
            var vDatos = new NpgsqlDataAdapter(sql, Conexion);
            var dsTabla = new DataSet();
            this.HayError = false;

            // capturar la excepción
            try
            {
                vDatos.Fill(dsTabla, tabla);

            }
            catch (Exception error)
            {
                this.HayError = true;
                this.DescripcionError = "Error en ejecutarConsultaSQL \n";
                this.DescripcionError += error.Message;
            }
            return dsTabla;
        }

        #endregion


        #region Set & Gets

        public Boolean HayError { set; get; }

        public String DescripcionError { set; get; }

        public static int Instancias { set; get; }

        public bool HayTransaccion { set; get; }

        public NpgsqlTransaction Transaccion { set; get; }

        public NpgsqlConnection Conexion { set; get; }

        #endregion

        #region Métodos de la clase

        public ContextDataBase ContextDataBase
        {
            get { return ContextDataBase.SqlServer; }
        }

        public void LimpiarEstado()
        {
            this.DescripcionError = "";
            this.HayError = false;
        }

        public void IniciarTransaccion()
        {
            if (this.HayTransaccion == false)
            {
                this.Transaccion = this.Conexion.BeginTransaction();
                this.HayTransaccion = true;
            }
        }

        public void CommitTransaccion()
        {
            if (this.HayTransaccion)
            {
                this.Transaccion.Commit();
                this.HayTransaccion = false;
            }
        }

        public void RollbackTransaccion()
        {
            if (this.HayTransaccion)
            {
                this.Transaccion.Rollback();
                this.HayTransaccion = false;
            }
        }

        #endregion


    }
}
