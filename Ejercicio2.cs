using System;


namespace CursoCSharp_Practicas
{
    class Program
    {
        static void Main(string[] args)

        {
            /*Que reciba un numero por teclado y diga si el numero es par o impar. */
            int a;
            Console.Write("Ingrese un numero para saber si es par o impar: ");
            a = int.Parse(Console.ReadLine());
            if ((a % 2) == 0)
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
