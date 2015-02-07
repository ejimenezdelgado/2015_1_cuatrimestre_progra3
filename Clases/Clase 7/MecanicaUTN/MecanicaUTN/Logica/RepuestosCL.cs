using MecanicaUTN.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicaUTN.Logica
{
    public class RepuestosCL
    {
        public bool HayError { set; get; }
        public string DescripcionError { set; get; }

        public void AgregarRepuesto(string nombre, string modelo, string marca, int cantidad,
            int precio, int impuesto, bool gravado)
        {
            IAccesoDatos accesoDatos = new RepuestosAD();

            accesoDatos.Escribir(Guid.NewGuid().ToString().Substring(0, 10) + " " +
                                 nombre + " " +
                                 modelo + " " +
                                 marca + " " +
                                 cantidad + " " +
                                 precio.ToString("n2") + " " +
                                 impuesto + " " +
                                 gravado);

            if (accesoDatos.HayError)
            {
                this.HayError = true;
                this.DescripcionError = accesoDatos.DescripcionError;
            }
        }

        public void EditarRepuesto(string id, string nombre, string modelo, string marca, int cantidad,
            int precio, int impuesto, bool gravado)
        {
            IAccesoDatos accesoDatos = new RepuestosAD();

            accesoDatos.Editar(id, id + " " +
                                 nombre + " " +
                                 modelo + " " +
                                 marca + " " +
                                 cantidad + " " +
                                 precio.ToString("n2") + " " +
                                 impuesto + " " +
                                 gravado);

            if (accesoDatos.HayError)
            {
                this.HayError = true;
                this.DescripcionError = accesoDatos.DescripcionError;
            }
        }

        public void EliminarRepuesto(string id)
        {
            IAccesoDatos accesoDatos = new RepuestosAD();

            accesoDatos.Eliminar(id);

            if (accesoDatos.HayError)
            {
                this.HayError = true;
                this.DescripcionError = accesoDatos.DescripcionError;
            }
        }

    }
}
