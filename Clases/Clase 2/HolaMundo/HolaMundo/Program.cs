using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros=null;
            int opcion = 1;
            Operaciones oOperaciones; 
            do
            {
                Console.WriteLine("1.Escribir la cantidad de elementos");
                Console.WriteLine("2.Imprimir los elementos");
                Console.WriteLine("3.Suma");
                Console.WriteLine("4.Resta");
                Console.WriteLine("5.Multiplicacion");
                Console.WriteLine("6.Division");
                Console.WriteLine("7.Salir");
                opcion=Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Digite la cantidad");
                        int cantidad = Convert.ToInt32(Console.ReadLine());
                       numeros = new int[cantidad];
                       for (int i = 0; i < cantidad; i++)
                       {
                           Console.WriteLine("Digite el numero");
                           numeros[i] = Convert.ToInt32(Console.ReadLine());
                       }

                       break;

                    case 2:

                       foreach (int item in numeros)
                       {
                           Console.WriteLine(item);
                       }

                       break;

                    case 3:

                       oOperaciones= new Operaciones();
                       Console.WriteLine(oOperaciones.Suma(numeros[0], numeros[1]));

                       break;


                    case 4:

                       oOperaciones = new Operaciones();
                       Console.WriteLine(oOperaciones.Resta(numeros[0], numeros[1]));

                       break;

                    case 5:

                       oOperaciones = new Operaciones();
                       Console.WriteLine(oOperaciones.Multiplicacion(numeros[0], numeros[1]));

                       break;

                    case 6:

                       oOperaciones = new Operaciones();
                       Console.WriteLine(oOperaciones.Division(numeros[0], numeros[1]));

                       break;
                }

            } while (opcion < 7);
        }
    }
}
