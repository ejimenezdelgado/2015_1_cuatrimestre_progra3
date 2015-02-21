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
    public class RepuestosSql:IRepuestoSql
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
                    repuestoSql = new RepuestoPostgres();
                    break;
                default:
                    break;
            }
            return repuestoSql;
        }

        public void AgregarRepuesto(Repuesto repuesto)
        {
            IRepuestoSql repuestoSql = this.ObtenerInstancia();
            repuestoSql.AgregarRepuesto(repuesto);
            if(repuestoSql.HayError)
            {
                this.HayError = true;
                this.DescripcionError = repuestoSql.DescripcionError;
            }
        }

        public void EditarRepuesto(int id, Repuesto repuesto)
        {
            IRepuestoSql repuestoSql = this.ObtenerInstancia();
            repuestoSql.EditarRepuesto(id,repuesto);
            if (repuestoSql.HayError)
            {
                this.HayError = true;
                this.DescripcionError = repuestoSql.DescripcionError;
            }
        }

        public List<Repuesto> TraerRepuestos()
        {
            IRepuestoSql repuestoSql = this.ObtenerInstancia();
            List<Repuesto> repuestos= repuestoSql.TraerRepuestos();
            if (repuestoSql.HayError)
            {
                this.HayError = true;
                this.DescripcionError = repuestoSql.DescripcionError;
            }
            return repuestos;
        }


        public void EliminarRepuesto(int id)
        {
            IRepuestoSql repuestoSql = this.ObtenerInstancia();
            repuestoSql.EliminarRepuesto(id);
            if (repuestoSql.HayError)
            {
                this.HayError = true;
                this.DescripcionError = repuestoSql.DescripcionError;
            }
        }
    }
}
