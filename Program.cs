using System;

namespace Practicas
{
    class Program
    {
        static void Main(string[] args)
        {
            
//Ejercicio 1
            #region Detalles

            //Crear un programa que pida números positivos al usuario, y vaya calculando la suma de todos ellos (terminará cuando se teclea un número negativo o cero).

            #endregion

            /*int valor, sum = 0;

            Console.WriteLine("\nIngrese un 0 o un número negativo para finalizar la operación y salir del programa.\n");
            
            do
            {
                Console.Write("Digite un número positivo: ");
                valor = int.Parse(Console.ReadLine());


                if (valor! > 0 && valor != 0)
                    sum = sum + valor;
                else
                {
                }
            } while (valor! > 0 && valor != 0);

            Console.WriteLine("La suma total es: {0}", sum);*/

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Ejercicio 2
            #region Detalles
            
            //  Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while".

            #endregion

            /*Console.WriteLine("\nLos números del 1 al 10\n");
            
            int i = 1;

            do
            {

                Console.WriteLine(i);
                i++;

            } while (i <= 10);*/

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Ejercicio 3
            #region Detalles

            //Crear un programa que muestre los primeros 10 números pares a partir del producto de (10 x 10).

            #endregion

            /*Console.WriteLine("\nLos números pares a partir del producto 10x10 son: \n");
            int valor = 10 * 10;

            while (valor <= 120)
            {
                valor++;

                if (valor % 2 == 0)
                {
                    Console.WriteLine(valor);
                }
                
            }*/

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Ejercicio 4
            #region Detalles

            //Crear un programa que muestre las letras de la Z (mayúscula) a la A (mayúscula, descendiendo).

            #endregion
            /*Console.WriteLine("\nEl alfabeto inverso y descendiendo\n");
            char letra;

            for (letra = 'Z'; letra >= 'A'; letra--)
                Console.WriteLine(letra);*/

        }
    }
}
