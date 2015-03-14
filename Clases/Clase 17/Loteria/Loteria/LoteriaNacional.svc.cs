using Loteria.tipoCambio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Loteria
{
    public class LoteriaNacional : ILoteriaNacional
    {
        public int NumeroGanador()
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
        }
    }
}
