using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1.Logica
{
    public class Letras
    {
        public string LetrasNumeros(int numero)
        {
            if(numero==0)
            {
                return "cero";
            }

            if (numero == 1)
            {
                return "uno";
            }

            if (numero == 2)
            {
                return "dos";
            }

            if (numero == 3)
            {
                return "tres";
            }

            if (numero == 4)
            {
                return "cuatro";
            }

            if (numero == 5)
            {
                return "cinco";
            }

            if (numero == 6)
            {
                return "seis";
            }

            if (numero == 7)
            {
                return "siete";
            }

            if (numero == 8)
            {
                return "ocho";
            }
            if (numero == 9)
            {
                return "nueve";
            }

            if (numero == 10)
            {
                return "diez";
            }

            return "Fuera de rango";
        }
    }
}
