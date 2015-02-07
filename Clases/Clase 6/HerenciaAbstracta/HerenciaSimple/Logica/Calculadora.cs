using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaSimple.Logica
{
    public class Calculadora
    {
        public int A { set; get; }

        public int B { set; get; }

        public int ResultadoSumatoria()
        {
            return A + B;
        }

        public int ResultadoResta()
        {
            return A - B;
        }
    }
}
