using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1.Logica
{
    public class Tablas
    {
        public string Mutiplicar(int numero)
        {
            string impresion = string.Empty;
            for (int i = 0; i < 16; i++)
            {
                impresion += numero.ToString() +" * "+ i.ToString() + "=" + numero * i+ Environment.NewLine;
            }

            return impresion;
        }
    }
}
