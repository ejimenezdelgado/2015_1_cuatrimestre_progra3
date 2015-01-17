using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
     public class Ejercicio2
    {
         public int SumaProductos()
         {
             int suma = 0;
             for (int i = 10; i < 21; i++)
             {
                 if(i==20)
                 {
                     return suma;
                 }
                 else
                 {
                     suma += i * i + 1;
                 }
             }

             return suma;
         }
    }
}
