using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1.Logica
{
    public class Mayor
    {
        public String MayorNumero(int x1,int x2, int x3)
        {
            int mayor = 0;

            if(x1>x2)
            {
                if(x1>x3)
                {
                    mayor = x1;
                }
            }

            if (x2 > x1)
            {
                if (x2 > x3)
                {
                    mayor = x2;
                }
            }

            if (x3 > x1)
            {
                if (x3 > x2)
                {
                    mayor = x3;
                }
            }
            if((x1==x2)&&(x1==x3))
            {
                return "Todos son iguales";
            }
            else
            {
                return "El numero mayor es"+Environment.NewLine + mayor;
            }

            return string.Empty;

        }

    }
}
