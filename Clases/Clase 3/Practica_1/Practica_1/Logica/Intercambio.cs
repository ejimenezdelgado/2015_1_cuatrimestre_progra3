using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1.Logica
{
    public class Intercambio
    {
        public string IntercambioLetas(string letra)
        {
            if(letra.ToLower()==letra)
            {
                return "La letra es "+letra.ToUpper() +Environment.NewLine+ "Conversion terminada";
            }
            else
            {
                return "La letra es " + letra.ToLower() + Environment.NewLine + "Conversion terminada";
            }
        }
    }
}
