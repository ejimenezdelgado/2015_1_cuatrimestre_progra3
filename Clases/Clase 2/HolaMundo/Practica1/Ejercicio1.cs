using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Ejercicio1
    {
        public int SumaNumeros()
        {
            int suma = 0;
            for (int i = 1; i < 11; i++)
            {
                suma += i;
            }

            return suma;
        }
    }
}
