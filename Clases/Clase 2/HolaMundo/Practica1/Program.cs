using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {

            Ejercicio1 oEjercicio1=new Ejercicio1 ();
            Console.WriteLine("La solucion del primer ejercicio es " + oEjercicio1.SumaNumeros());

            Ejercicio2 oEjercicio2 = new Ejercicio2();
            Console.WriteLine("La solucion del segundo ejercicio es " + oEjercicio2.SumaProductos());

            Ejercicio3 oEjercicio3 = new Ejercicio3();
            Console.WriteLine("La solucion del tercer ejercicio es " + oEjercicio3.Positivos());
            Console.ReadLine();
        }
    }
}
