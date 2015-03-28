using AccesoDatos;
using Loteria.tipoCambio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Loteria
{
    public class LoteriaNacional : ILoteriaNacional
    {
     /*   public int NumeroGanador()
        {
            Random oRandom=new Random();
            return oRandom.Next();
        }

        public Entidades.Premio PremioMayor()
        {
            Random oRandom=new Random();
            return new Entidades.Premio()
            {
                id = 5455,
                monto = 5000000000,
                premio = oRandom.Next()
            };
        }


        public void AgregarPremio(Entidades.Premio premio)
        {
            
        }


        public double TipoCambio()
        {
            wsIndicadoresEconomicosSoapClient oTipoCambio = new wsIndicadoresEconomicosSoapClient();

            var tipoCambio = oTipoCambio.ObtenerIndicadoresEconomicos("318", "14/03/2015", "14/03/2015", "UTN", "N");

            return Convert.ToDouble(tipoCambio.Tables[0].Rows[0]["NUM_VALOR"].ToString());
        }*/

        public void AgregarSorteo(sorteo sorteo,usuario usuario)
        {
            ModeloLoteriaContainer modeloLoteria = new ModeloLoteriaContainer();
            modeloLoteria.sorteo.Add(sorteo);
            modeloLoteria.SaveChanges();            
        }

        public void EditarSorteo(sorteo sorteo)
        {
            throw new NotImplementedException();
        }

        public void EliminarSorteo(sorteo sorteo)
        {
            throw new NotImplementedException();
        }

        public void AgregarPremio(premio premio)
        {
            throw new NotImplementedException();
        }

        public void EditarPremio(premio premio)
        {
            throw new NotImplementedException();
        }

        public void EliminarPremio(premio premio)
        {
            throw new NotImplementedException();
        }


        public bool AgregarUsuario(usuario usuario)
        {
            try
            {
                ModeloLoteriaContainer modeloLoteria = new ModeloLoteriaContainer();
                var md5 = modeloLoteria.Database.SqlQuery<string>("select convert(varchar(32),HashBytes('MD5','@password'),2)",
                     new object[] { usuario.password }).First();

                usuario.password = md5;

                modeloLoteria.usuario.Add(usuario);
                modeloLoteria.SaveChanges();

            }catch(Exception error)
            {
                return false;
            }
            return true;           
        }
    }
}
