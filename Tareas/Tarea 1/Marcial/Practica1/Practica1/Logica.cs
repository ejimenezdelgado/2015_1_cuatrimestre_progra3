using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Logica
    {

        /*
         * 1.	Calcula la suma de los números enteros entre 1 y 10 (1+2+3+4....).
         */
        public int SumaTen()
        {
            int tot = 0;
            for (int i = 1; i <= 10; i++)
            {
                tot = tot + i;
            }
            return tot;
        }

        /*
         * 2.	Sume el producto de los números enteros del 10 al 20 10*12*14.
         */
        public Double TotSumaProd()
        {
            double mult = 0;
            double sum = 0;
            for (int i = 10; i < 20; i++)
            {
                mult = i * (i + 1);
                sum = sum + mult;
            }
            return sum;
        }

        /*
         * 3.	El usuario introduce números 10 números y el ordenador cuenta cuantos son positivos.
         */
        public int Positivos(int[] nums)
        {
            int tot = 0;

            foreach (var item in nums)
            {
                if (item > 0)

                    tot++;
            }

            return tot;
        }

        /*
         * 4.	Cree un programa que le pida el ingreso de 3 números y determine cuál de ellos es el mayor, e indique si hay dos o tres que sean iguales.
         */
        public String Mayor(int n1, int n2, int n3)
        {
            int mayor = n1;
            string respuesta = "El numero mayor es: " + mayor;

            if ((n2 > mayor) && (n2 > n3) && (n2 != n3) && (n2 != mayor))
            {
                mayor = n2;
                respuesta = "El numero mayor es: " + mayor;
                return respuesta;

            }
            else if (n2 == n1)
            {
                respuesta = "El primer y segundo numero son iguales y su valor es: " + mayor;
                return respuesta;
            }
            else if (n2 == n3)
            {
                mayor = n2;
                respuesta = "El seguno y el tecer numero son iguales, y su valor es: " + mayor;
            }
            else if ((n3 > mayor) && (n3 != mayor))
            {
                mayor = n3;
                respuesta = "El numero mayor es: " + mayor;
                return respuesta;

            }
            else if ((n3 == n2) && (n3 == mayor))
            {
                respuesta = "Todos los numeros son iguales a: " + mayor;
            }

            return respuesta;
        }

        /*
         * 5.	Cree un programa que pida el ingreso de una cantidad y retorne su valor en letras
         * (evaluar números de 1 a 10) y al estar un numero fuera de rango muestre el mensaje FUERA DE RANGO.
         * 
         * 12.	Cree un programa que pida el ingreso de un numero de hasta tres cifras y le muestre este número en letras, ojo,
         * que el anterior solo utilizaba de una cifra, no traten de hacer 999 comparaciones, busquen una forma de hacerlo más corto,
         * observen que los números tienden a repetirse, partan el número y evalúen cada cifra y de ahí hagan las instrucciones.
         */

        public String ValorenLetras(double numero)
        {
            string numeroTexto = "";
            numero = Math.Truncate(numero);
            if (numero == 0) numeroTexto = "CERO";
            else if (numero == 1) numeroTexto = "UNO";
            else if (numero == 2) numeroTexto = "DOS";
            else if (numero == 3) numeroTexto = "TRES";
            else if (numero == 4) numeroTexto = "CUATRO";
            else if (numero == 5) numeroTexto = "CINCO";
            else if (numero == 6) numeroTexto = "SEIS";
            else if (numero == 7) numeroTexto = "SIETE";
            else if (numero == 8) numeroTexto = "OCHO";
            else if (numero == 9) numeroTexto = "NUEVE";
            else if (numero == 10) numeroTexto = "DIEZ";
            else if (numero == 11) numeroTexto = "ONCE";
            else if (numero == 12) numeroTexto = "DOCE";
            else if (numero == 13) numeroTexto = "TRECE";
            else if (numero == 14) numeroTexto = "CATORCE";
            else if (numero == 15) numeroTexto = "QUINCE";
            else if (numero < 20) numeroTexto = "DIECI" + ValorenLetras(numero - 10);
            else if (numero == 20) numeroTexto = "VEINTE";
            else if (numero < 30) numeroTexto = "VEINTI" + ValorenLetras(numero - 20);
            else if (numero == 30) numeroTexto = "TREINTA";
            else if (numero == 40) numeroTexto = "CUARENTA";
            else if (numero == 50) numeroTexto = "CINCUENTA";
            else if (numero == 60) numeroTexto = "SESENTA";
            else if (numero == 70) numeroTexto = "SETENTA";
            else if (numero == 80) numeroTexto = "OCHENTA";
            else if (numero == 90) numeroTexto = "NOVENTA";
            else if (numero < 100) numeroTexto = ValorenLetras(Math.Truncate(numero / 10) * 10) + " Y " + ValorenLetras(numero % 10);
            else if (numero == 100) numeroTexto = "CIEN";
            else if (numero < 200) numeroTexto = "CIENTO " + ValorenLetras(numero - 100);
            else if ((numero == 200) || (numero == 300) || (numero == 400) || (numero == 600) || (numero == 800)) numeroTexto = ValorenLetras(Math.Truncate(numero / 100)) + "CIENTOS";
            else if (numero == 500) numeroTexto = "QUINIENTOS";
            else if (numero == 700) numeroTexto = "SETECIENTOS";
            else if (numero == 900) numeroTexto = "NOVECIENTOS";
            else if (numero < 1000) numeroTexto = ValorenLetras(Math.Truncate(numero / 100) * 100) + " " + ValorenLetras(numero % 100);
            else if (numero == 1000) numeroTexto = "MIL";
            else if (numero < 2000) numeroTexto = "MIL " + ValorenLetras(numero % 1000);
            else if (numero < 1000000)
            {
                numeroTexto = ValorenLetras(Math.Truncate(numero / 1000)) + " MIL";
                if ((numero % 1000) > 0) numeroTexto = numeroTexto + " " + ValorenLetras(numero % 1000);
            }

            else if (numero == 1000000) numeroTexto = "UN MILLON";
            else if (numero < 2000000) numeroTexto = "UN MILLON " + ValorenLetras(numero % 1000000);
            else if (numero < 1000000000000)
            {
                numeroTexto = ValorenLetras(Math.Truncate(numero / 1000000)) + " MILLONES ";
                if ((numero - Math.Truncate(numero / 1000000) * 1000000) > 0) numeroTexto = numeroTexto + " " + ValorenLetras(numero - Math.Truncate(numero / 1000000) * 1000000);
            }

            else if (numero == 1000000000000) numeroTexto = "UN BILLON";
            else if (numero < 2000000000000) numeroTexto = "UN BILLON " + ValorenLetras(numero - Math.Truncate(numero / 1000000000000) * 1000000000000);

            else
            {
                numeroTexto = ValorenLetras(Math.Truncate(numero / 1000000000000)) + " BILLONES";
                if ((numero - Math.Truncate(numero / 1000000000000) * 1000000000000) > 0) numeroTexto = numeroTexto + " " + ValorenLetras(numero - Math.Truncate(numero / 1000000000000) * 1000000000000);
            }
            return numeroTexto;

        }

        /*
         * 6.	Cree un programa que pida el ingreso de una letra, y luego se la muestre en minúscula o mayúscula sea el caso,
         * si ingresó la letra a muestre un mensaje que diga A, si ingresa R, me muestre r.
         * y luego un mensaje que diga "Conversión Terminada".
         */

        public String ConversionLetra(string letra)
        {
            string convertida = letra;
            string mensaje = "";
            if (convertida == convertida.ToUpper())
            {
                convertida = convertida.ToLower();
            }
            else
            {
                convertida = convertida.ToUpper();
            }
            mensaje = "Conversión terminada";

            return convertida + " " + Environment.NewLine + mensaje;

        }
        /*
         * 7.	Cree un programa que pida el ingreso de una letra, si esta es una A mayúscula imprima el mensaje
         * "Calificación Excelente", sino imprima un mensaje que diga, "Alumno Promedio".
         */

        public String Calificacion(string letra)
        {
            string mensaje = "";
            char ideal = 'A';
            if (letra == letra.ToUpper())
            {
                if (letra.Equals(ideal.ToString()))
                {
                    mensaje = "Calificación Excelente";
                }

            }
            else
            {
                mensaje = "Alumno Promedio";
            }

            return mensaje;

        }

        /*
         * 8.	Cree un programa que pida el ingreso de un número y muestre las tablas de multiplicar de este
         * desde el 1 al 15. Ejemplo, si ingreso el 3 tiene que mostrar, 3 x1 = 3, 3 x 2 = 6 , 3 x 3 = 9,
         * si ingresa el 4 mostraría, 4 x 1=4, 4 x 2=8, 4 x 3 = 12, hasta el 4 x 15.
         */
        public String Tabla(int num)
        {
            string tabla = "";
            double result = 0;

            for (int i = 1; i <= 15; i++)
            {
                result = num * i;
                tabla = tabla + num + " x " + i + " = " + result + Environment.NewLine;
            }

            return tabla;
        }

        /*
         * 9.	Cree un programa que pida el ingreso de un Sting luego lo recorra por completo
         * y lo convierta de minúscula a mayúscula y viceversa.(Sin usar los Métodos ToUpper
         * y ToLower)
         */
        public String InvertirTexto(string texto)
        {
            string convertido = "";
            string[] abecedarioMin = new string[28] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "ll", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] abecedarioMay = new string[28] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "LL", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            for (int i = 0; i < texto.Length; i++)
            {
                for (int e = 0; e < abecedarioMin.Length; e++)
                {
                    if (texto[i].ToString().Equals(abecedarioMin[e]))
                    {
                        convertido = convertido + abecedarioMay[e];
                    }

                }
                for (int a = 0; a < abecedarioMay.Length; a++)
                {
                    if (texto[i].ToString().Equals(abecedarioMay[a]))
                    {
                        convertido = convertido + abecedarioMin[a];
                    }
                }
            }

            return convertido;
        }

        /*
         *10.	Cree un programa de Encriptación, que ingrese una palabra y la retorne en un conjunto de números,
         *ejemplo GABRIELA =946374041, o caracteres cualquiera $%^#@$, pero que al ingresar los mismo caracteres
         *retorne la palabra original.
         */
        public String Encriptar(string textoAencriptar)
        {
            string result = "";
            byte[] encryptar = System.Text.Encoding.Unicode.GetBytes(textoAencriptar);
            result = Convert.ToBase64String(encryptar);
            return result;
        }

        /// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
        public String DesEncriptar(string textoAdesencriptar)
        {
            string result = "";
            byte[] desencryptar = Convert.FromBase64String(textoAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(desencryptar);
            return result;
        }

        /*
         *11.	Cree un programa que pida el ingreso de una frase, verifique si es palíndromo y la escriba al revés.
         *      ejemplo Anita lava la tina.
         */
        public String Palindromo(string frase)
        {
            string respuesta = "";
            string reversada = "";
            string sinEspacios = frase;
            string letra = "";
            int e = 0;
            // int el = 0;

            sinEspacios = sinEspacios.Replace(" ", "");
            for (int i = sinEspacios.Length - 1; i >= 0; i--)
            {
                letra = sinEspacios.Substring(i, 1);
                reversada = reversada + letra;
            }
            if (sinEspacios.Equals(reversada))
            {
                respuesta = "LA FRASE O PALABRA DIGITADA ES UN PALINDROMO";
            }
            else
            {
                respuesta = "LA FRASE O PALABRA DIGITADA NO ES UN PALINDROMO";
            }

            return "La palabra o frase revertida es: \n" + "     " + reversada + "\n\n" + "Por lo tanto: " + respuesta;
        }

        /*
         * 13.	Cree un programa que le pida el ingreso de un numero de cedula cualquiera 206740150
         * y luego se lo de muéstrelo con el formato de guiones 2-0674-0151
         */
        public String CedulaGuiones(string ced)
        {
            string conGuiones = "";
            for (int i = 0; i < ced.Length; i++)
            {
                if ((i == 1) || (i == 5))
                {
                    conGuiones = conGuiones + "-";
                }
                conGuiones = conGuiones + ced[i];
            }

            return conGuiones;
        }

        /*
         * 14.	Cree un programa que pida el ingreso de una frase, como la siguiente "Universidad Técnica Nacional",
         * y por cada letra tenga asignado un número y cree una subcadena que genere una palabra hecha por números
         * A=01, B=02, C=03, D=04, E=05, F=06, G=07, H=08, I=09, J=10, K=11, L=12, M=13, N=14, Ñ=15, O=16, P=17, Q=18
         * R=19, S=20, T=21, U=22, V=23, W=24, X=25, Y=26, Z=27
         */
        public String FraseEnNumeros(string fraseLetras)
        {
            string codigoNumeros = "";
            string frase = fraseLetras.ToUpper();
            string A = "01", B = "02", C = "03", D = "04", E = "05", F = "06", G = "07", H = "08", I = "09", J = "10", K = "11", L = "12",
            M = "13", N = "14", Ñ = "15", O = "16", P = "17", Q = "18", R = "19", S = "20", T = "21", U = "22", V = "23", W = "24", X = "25", Y = "26", Z = "27";
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i].Equals('A'))
                {
                    codigoNumeros= codigoNumeros + A;
                }
                else if (frase[i].Equals('B'))
                {
                    codigoNumeros = codigoNumeros + B;
                }
                else if (frase[i].Equals('C'))
                {
                    codigoNumeros = codigoNumeros + C;
                }
                else if (frase[i].Equals('D'))
                {
                    codigoNumeros = codigoNumeros + D;
                }
                else if (frase[i].Equals('E'))
                {
                    codigoNumeros = codigoNumeros + E;
                }
                else if (frase[i].Equals('F'))
                {
                    codigoNumeros = codigoNumeros + F;
                }
                else if (frase[i].Equals('G'))
                {
                    codigoNumeros = codigoNumeros + G;
                }
                if (frase[i].Equals('H'))
                {
                    codigoNumeros = codigoNumeros + H;
                }
                else if (frase[i].Equals('I'))
                {
                    codigoNumeros = codigoNumeros + I;
                }
                else if (frase[i].Equals('J'))
                {
                    codigoNumeros = codigoNumeros + J;
                }
                else if (frase[i].Equals('K'))
                {
                    codigoNumeros = codigoNumeros + K;
                }
                else if (frase[i].Equals('L'))
                {
                    codigoNumeros = codigoNumeros + L;
                }
                else if (frase[i].Equals('M'))
                {
                    codigoNumeros = codigoNumeros + M;
                }
                else if (frase[i].Equals('N'))
                {
                    codigoNumeros = codigoNumeros + N;
                }
                else if (frase[i].Equals('Ñ'))
                {
                    codigoNumeros = codigoNumeros + Ñ;
                }
                else if (frase[i].Equals('O'))
                {
                    codigoNumeros = codigoNumeros + O;
                }
                else if (frase[i].Equals('P'))
                {
                    codigoNumeros = codigoNumeros + P;
                }
                else if (frase[i].Equals('Q'))
                {
                    codigoNumeros = codigoNumeros + Q;
                }
                else if (frase[i].Equals('R'))
                {
                    codigoNumeros = codigoNumeros + R;
                }
                else if (frase[i].Equals('S'))
                {
                    codigoNumeros = codigoNumeros + S;
                }
                else if (frase[i].Equals('T'))
                {
                    codigoNumeros = codigoNumeros + T;
                }
                else if (frase[i].Equals('U'))
                {
                    codigoNumeros = codigoNumeros + U;
                }
                else if (frase[i].Equals('V'))
                {
                    codigoNumeros = codigoNumeros + V;
                }
                else if (frase[i].Equals('W'))
                {
                    codigoNumeros = codigoNumeros + W;
                }
                else if (frase[i].Equals('X'))
                {
                    codigoNumeros = codigoNumeros + X;
                }
                else if (frase[i].Equals('Y'))
                {
                    codigoNumeros = codigoNumeros + Y;
                }
                else if (frase[i].Equals('Z'))
                {
                    codigoNumeros = codigoNumeros + Z;
                }
                else if (frase[i].Equals(' '))
                {
                    codigoNumeros = codigoNumeros + ' ';
                }
            }

            return codigoNumeros;
        }

    }
}