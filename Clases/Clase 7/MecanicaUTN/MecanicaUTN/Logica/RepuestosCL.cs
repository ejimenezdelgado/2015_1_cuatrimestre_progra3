using MecanicaUTN.AccesoDatos;
using MecanicaUTN.Entidades;
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

            accesoDatos.Escribir(Guid.NewGuid().ToString().Substring(0, 10) + "@" +
                                 nombre + "@" +
                                 modelo + "@" +
                                 marca + "@" +
                                 cantidad + "@" +
                                 precio.ToString("n2") + "@" +
                                 impuesto + "@" +
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

            accesoDatos.Editar(id, id + "@" +
                                 nombre + "@" +
                                 modelo + "@" +
                                 marca + "@" +
                                 cantidad + "@" +
                                 precio.ToString("n2") + "@" +
                                 impuesto + "@" +
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

        public List<Repuesto> ObtenerRepuestos()
        {
            List<Repuesto> repuestos = new List<Repuesto>();
            IAccesoDatos accesoDatos = new RepuestosAD();
            StringBuilder informacion = new StringBuilder(accesoDatos.Leer());
            string[] lineas = informacion.ToString().Split(new string[] { Environment.NewLine },
                StringSplitOptions.None);

            if(lineas.Any())
            {
                foreach (var linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        string[] atributos = linea.Split(new string[] { "@" }, StringSplitOptions.None);

                        repuestos.Add(new Repuesto()
                        {
                            Id = atributos[0],
                            Nombre = atributos[1],
                            Modelo = atributos[2],
                            Marca = atributos[3],
                            Cantidad = Convert.ToInt32(atributos[4]),
                            Precio = Convert.ToDouble(atributos[5]),
                            Impuesto = Convert.ToInt32(atributos[6]),
                            Gravado = Convert.ToBoolean(atributos[7])
                        });
                    }
                }
            }

            if (accesoDatos.HayError)
            {
                this.HayError = true;
                this.DescripcionError = accesoDatos.DescripcionError;
            }
            return repuestos;
        }

    }
}
