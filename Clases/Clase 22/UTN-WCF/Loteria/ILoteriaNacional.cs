using Loteria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AccesoDatos;

namespace Loteria
{
    [ServiceContract]
    public interface ILoteriaNacional
    {
/*        [OperationContract]
        int NumeroGanador();

        [OperationContract]
        Premio PremioMayor();

        [OperationContract]
        void AgregarPremio(Premio premio);

        [OperationContract]
        double TipoCambio();*/

        [OperationContract]
        void AgregarSorteo(sorteo sorteo);

        [OperationContract]
        void EditarSorteo(sorteo sorteo);

        [OperationContract]
        void EliminarSorteo(sorteo sorteo);

        [OperationContract]
        void AgregarPremio(premio premio);

        [OperationContract]
        void EditarPremio(premio premio);

        [OperationContract]
        void EliminarPremio(premio premio);

        [OperationContract]
        bool AgregarUsuario(usuario usuario);

    }
}
