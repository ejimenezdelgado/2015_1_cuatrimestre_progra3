using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Ejercicio3
    {
        int[] numeros=new int[10];
        public string Positivos()
        {
            string impresion=string.Empty;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite el numero " + (i + 1));
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var item in numeros)
            {
                if(item>0)
                {
                    impresion += item + ",";
                }
            }

            return impresion;
        }
    }
}
