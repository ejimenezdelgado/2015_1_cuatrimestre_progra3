using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicaUTN.Entidades
{
    public struct Repuesto
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Modelo { set; get; }
        public string Marca { set; get; }
        public decimal Cantidad { set; get; }
        public decimal Precio { set; get; }
        public decimal Impuesto { set; get; }
        public bool Gravado { set; get; }
    }
}
