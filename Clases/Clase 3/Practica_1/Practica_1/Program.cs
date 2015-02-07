using Practica_1.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mayor oMayor;
            Letras oLetras;
            Intercambio oIntercambio;
            Estudiante oEstudiante;
            Tablas otablas;
            do
            {
                Console.WriteLine("Digite el opcion correspondiente");
                Console.WriteLine("4. Numero mayor");
                Console.WriteLine("5. Numero mayor");
                Console.WriteLine("6. Intercambio de letras");
                Console.WriteLine("7. Notas alumno");
                Console.WriteLine("8. Tablas de mutiplicar");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 4:
                        Console.WriteLine("Digite el primer nuemro");
                        int x1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite el segundo nuemro");
                        int x2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite el tercer nuemro");
                        int x3 = Convert.ToInt32(Console.ReadLine());
                        oMayor = new Mayor();
                        Console.WriteLine(oMayor.MayorNumero(x1, x2, x3));
                        Console.ReadLine();
                        break;

                    case 5:

                        Console.WriteLine("Digite un numero");
                        int letra = Convert.ToInt32(Console.ReadLine());
                        oLetras = new Letras();
                        Console.WriteLine(oLetras.LetrasNumeros(letra));
                        Console.ReadLine();
                        break;

                    case 6:

                        Console.WriteLine("Digite una letra");
                        string letraConversion = Console.ReadLine();
                        oIntercambio = new Intercambio();
                        Console.WriteLine(oIntercambio.IntercambioLetas(letraConversion));
                        Console.ReadLine();
                        break;

                    case 7:

                        Console.WriteLine("Digite una letra");
                        string estudiante = Console.ReadLine();
                        oEstudiante = new Estudiante();
                        Console.WriteLine(oEstudiante.Calificacion(estudiante));
                        Console.ReadLine();
                        break;

                    case 8:

                        Console.WriteLine("Digite un numero");
                        int tablas = Convert.ToInt32(Console.ReadLine());
                        otablas = new Tablas();
                        Console.WriteLine(otablas.Mutiplicar(tablas));
                        Console.ReadLine();
                        break;

                }
            } while (true);          
            
        }
    }
}
