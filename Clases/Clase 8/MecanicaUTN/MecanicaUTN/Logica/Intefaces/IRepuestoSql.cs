using MecanicaUTN.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicaUTN.Logica.Intefaces
{
    public interface IRepuestoSql
    {
        void AgregarRepuesto(Repuesto repuesto);

        void EditarRepuesto(int id, Repuesto repuesto);

        void EliminarRepuesto(int id);

        List<Repuesto> TraerRepuestos();

        Boolean HayError { set; get; }
        String DescripcionError { set; get; }
    }
}
