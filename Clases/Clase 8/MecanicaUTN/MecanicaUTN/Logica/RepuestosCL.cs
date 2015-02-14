using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MecanicaUTN.AccesoDatos;

namespace MecanicaUTN.Logica
{
    public class RepuestosCL
    {
        AccesoDatos.AccesoDatos accesoDatos = AccesoDatos.AccesoDatos.Instance;
        public void TestBaseDatos()
        {
            var data= accesoDatos.accesoDatos.EjecutarConsultaSQL("select getdate()");
        }
    }
}
