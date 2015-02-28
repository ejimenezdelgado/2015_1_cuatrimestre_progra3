using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicaUTN.Entidades
{
    public class Usuario
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string clave { set; get; }
        public Boolean EsAdmin { set; get; }
    }
}
