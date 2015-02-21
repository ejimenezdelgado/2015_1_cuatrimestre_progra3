using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MecanicaUTN.AccesoDatos;
using MecanicaUTN.Logica.Intefaces;
using MecanicaUTN.Logica.SqlServer;
using MecanicaUTN.Entidades;

namespace MecanicaUTN.Logica
{
    public class RepuestosSql
    {
        public Boolean HayError { set; get; }
        public String DescripcionError { set; get; }

        public IRepuestoSql ObtenerInstancia()
        {
            IRepuestoSql repuestoSql=null;
            switch (AccesoDatos.AccesoDatos.Instance.accesoDatos.ContextDataBase)
            {
                case ContextDataBase.SqlServer:
                    repuestoSql = new RepuestoSqlServer();
                    break;
                case ContextDataBase.PostgreSql:
                    break;
                default:
                    break;
            }
            return repuestoSql;
        }

        public void AgregarRepuesto(Repuesto repuesto)
        {
            IRepuestoSql repuestoSql = this.ObtenerInstancia();
            repuestoSql.Agregar(repuesto);
            if(repuestoSql.HayError)
            {
                this.HayError = true;
                this.DescripcionError = repuestoSql.DescripcionError;
            }
        }
    }
}
