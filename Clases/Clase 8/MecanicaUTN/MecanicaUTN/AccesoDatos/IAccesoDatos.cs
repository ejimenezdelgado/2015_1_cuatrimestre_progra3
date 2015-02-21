using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicaUTN.AccesoDatos
{
    public interface IAccesoDatos
    {
        #region Métodos de conexion

        // Indica el estado de la persistencia
        Boolean Estado();

        DataSet EjecutarConsultaSQL(String sql);

        DataSet EjecutarConsultaSQL(String sql, IEnumerable parametros);

        void EjecutarSQL(string sql, IEnumerable parametros);

        Int32 EjecutarScalarSQL(String pSql);

        DataSet EjecutarSQLListas(String sql, String tabla);

        #endregion

        #region Set & Gets

        Boolean HayError { set; get; }

        String DescripcionError { set; get; }

        bool HayTransaccion { set; get; }

        ContextDataBase ContextDataBase { get; }

        #endregion

        #region Métodos de la clase

        void LimpiarEstado();

        void IniciarTransaccion();

        void CommitTransaccion();

        void RollbackTransaccion();

        #endregion
    }
}
