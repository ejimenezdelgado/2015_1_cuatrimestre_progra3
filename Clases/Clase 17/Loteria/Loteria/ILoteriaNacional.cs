using Loteria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Loteria
{
    [ServiceContract]
    public interface ILoteriaNacional
    {
        [OperationContract]
        int NumeroGanador();

        [OperationContract]
        Premio PremioMayor();

        [OperationContract]
        void AgregarPremio(Premio premio);

        [OperationContract]
        double TipoCambio();

    }
}
