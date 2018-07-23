using System;


namespace CursoCSharp_Practicas
{
    class Program
    {
        static void Main(string[] args)

        {
            /*Pida al usuario un número entero, diga si es par o impar,
            * y repita todo lo anterior hasta que el número que se introduzca sea 0.
            * (Nota: para saber si un número es par, se mira si el resto de su división entre 2 es 0). */
            int a, bucle = 0;

            while (bucle == 0)
            {
                Console.Write("Ingrese un numero para saber si es par o impar: ");
                a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.Write("Imposible inspeccionar el valor 0");
                    break;
                }
                else if ((a % 2) == 0)
                {
                    Console.WriteLine("El numero " + a + " es par");
                }
                else
                {
                    Console.WriteLine("El numero " + a + " es impar");
                }
            }
        }
    }
}
