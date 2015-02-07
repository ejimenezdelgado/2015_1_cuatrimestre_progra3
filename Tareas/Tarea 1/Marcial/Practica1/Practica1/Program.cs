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
            int op = 0;
            // int[] numeros;
            Logica Ol;

            do
            {
                Console.WriteLine("**** Menu****");
                Console.WriteLine("1. suma de números enteros entre 1 y 10 ");
                Console.WriteLine("2. producto números enteros del 10 al 20");
                Console.WriteLine("3. 10 números; ¿cuantos son positivos?");
                Console.WriteLine("4. Calcular el mayor de tres numeros");
                Console.WriteLine("5. Pasar numero a letras");
                Console.WriteLine("6. Convertir letra");
                Console.WriteLine("7. Evaluar calificacion");
                Console.WriteLine("8. Imprimir tabla de multiplicar de un numero");
                Console.WriteLine("9. Imprimir abecedario");
                Console.WriteLine("10. Encryptar una palabra");
                Console.WriteLine("11. Desencryptar una palabra");
                Console.WriteLine("12. Evaluacion de Palindromo");
                Console.WriteLine("13. Modificacion cedula");
                Console.WriteLine("14. Convertir frase a numeros");

                Console.WriteLine("15. Salir");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Ol = new Logica();
                        Console.WriteLine("La sumatoria de los numeros del 1 al 10 es = "+Ol.SumaTen());
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 2:
                        Ol = new Logica();
                        Console.WriteLine(Ol.TotSumaProd());
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 3:
                        int n;
                        int[] todos = new int[10];
                        Ol = new Logica();
                        Console.WriteLine("Digite diez numeros");
                        for (int i = 1; i < todos.Length; i++)
                        {
                            n = Convert.ToInt32(Console.ReadLine());
                            todos[i] = n;
                        }
                        Console.WriteLine("El total de numeros positivos es de: " + Ol.Positivos(todos));
                        // Console.ReadLine();
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 4:
                        Ol = new Logica();
                        int n1, n2, n3 = 0;
              
                        Console.WriteLine("Digite 3 numeros para evaluar cual es el mayor!!");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        n2 = Convert.ToInt32(Console.ReadLine());
                        n3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El resultado del calculo es: " + Ol.Mayor(n1, n2, n3) + Environment.NewLine);
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 5:
                        Ol = new Logica();
                        double numeroT = 0;

                        Console.WriteLine("Digite un numero" + Environment.NewLine);
                        numeroT = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El numero digitado es: " + Ol.ValorenLetras(numeroT) + Environment.NewLine);
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 6:
                        Ol = new Logica();
                        string letra = "";

                        Console.WriteLine("Digite una letra mayuscula o minuscula " + Environment.NewLine);
                        letra = Console.ReadLine();
                        Console.WriteLine("La letra convertida es: " + Ol.ConversionLetra(letra) + Environment.NewLine);
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 7:
                        Ol = new Logica();
                        string calif = "";

                        Console.WriteLine("Digite la calificacion " + Environment.NewLine);
                        calif = Console.ReadLine();
                        Console.WriteLine(Ol.Calificacion(calif) + Environment.NewLine);
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 8:
                        Ol = new Logica();
                        int numeroTabla = 0;
                        //string respuesta = "";

                        //do
                        //{
                        Console.WriteLine("Digite un numero para imprimir la tabla del 1 al 15" + Environment.NewLine);
                        numeroTabla = Convert.ToInt32(Console.ReadLine());
                        //if (Convert.ToInt32(Console.ReadLine()).Equals(false))
                        // Console.WriteLine("Debe digitar un numero para proceder...!!" + Environment.NewLine);


                        //}
                        //while (Convert.ToInt32(Console.ReadLine()).Equals(false));


                        //numeroTabla = Convert.ToInt32(respuesta);
                        Console.WriteLine(Ol.Tabla(numeroTabla) + Environment.NewLine);
                        // */
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;


                    case 9:
                        Ol = new Logica();
                        string texto = "";

                        Console.WriteLine("Digite una palabra para invertir mayusculass por minusculas y viceversa " + Environment.NewLine);
                        texto = (string)Console.ReadLine();

                        Console.WriteLine(Ol.InvertirTexto(texto) + Environment.NewLine);
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 10:
                        Ol = new Logica();
                        string palabra = "";

                        Console.WriteLine("Digite una palabra para Encryptarla " + Environment.NewLine);
                        palabra = (string)Console.ReadLine();

                        Console.WriteLine("La palabra encriptada es: " + Ol.Encriptar(palabra) + Environment.NewLine);
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 11:
                        Ol = new Logica();
                        string palabraEncriptada = "";

                        Console.WriteLine("Digite una palabra para Desencryptarla " + Environment.NewLine);
                        palabraEncriptada = (string)Console.ReadLine();

                        Console.WriteLine("El resultado de resolver la encriptacion es: " + Ol.DesEncriptar(palabraEncriptada) + Environment.NewLine);
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 12:
                        Ol = new Logica();
                        string frase = "";

                        Console.WriteLine("Digite una frase o palabra para verificar si es un palindromo " + Environment.NewLine);
                        frase = Console.ReadLine();

                        Console.WriteLine("El resultado de la verificacion dice que: " + Ol.Palindromo(frase) + Environment.NewLine);
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 13:
                        Ol = new Logica();
                        string cedula = "";

                        Console.WriteLine("Digite su numero de cedula " + Environment.NewLine);
                        cedula = Console.ReadLine();

                        Console.WriteLine("La cedula modificada es: " + Ol.CedulaGuiones(cedula)+ Environment.NewLine);
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;

                    case 14:
                        Ol = new Logica();
                        string fraseAnumeros = "";

                        Console.WriteLine("Digite una frase " + Environment.NewLine);
                        fraseAnumeros = Console.ReadLine();

                        Console.WriteLine("La frase convertida a numeros es: " + Ol.FraseEnNumeros(fraseAnumeros) + Environment.NewLine);
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;

                    default:
                        break;
                }


            } while (op < 15);


        }
    }
}
