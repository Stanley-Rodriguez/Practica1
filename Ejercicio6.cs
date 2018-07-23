using System;


namespace CursoCSharp_Practicas
{
    class Program
    {
        static void Main(string[] args)

        {
            /*Pida al usuario dos números enteros (que se guardarán en
             * las variables n1 y n2) y muestre su producto en pantalla.*/
            int n1, n2;
            Console.Write("Ingrese el valor 1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Ingrese el valor 2: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("El producto de ambos valores es: {0}", n1 * n2);

        }
    }
}
