using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaSimple.Logica
{
    public class CalculadoraMejorada:Calculadora
    {
        public int ResultadoDivision()
        {
            return A / B;
        }

        public int ResultadoMultiplicacion()
        {
            return A * B;
        }
    }
}
