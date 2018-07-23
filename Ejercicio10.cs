using System;


namespace CursoCSharp_Practicas
{
    class Program
    {
        static void Main(string[] args)

        {
            /* Pida al usuario un número indefinido de números (mientras se tecleen números que no sea cero).
              * Después de la introducción de cada número aparecerá en pantalla información sobre el número de
              * datos introducidos y la suma hasta el momento, así: "Has introducido 5 números y su suma es 38" */
            int bucle = 0, input, count = 0, sum = 0;
            while (bucle == 0)
            {
                Console.Write("Ingrese un numero: ");
                input = int.Parse(Console.ReadLine());

                if (input != 0)
                {
                    sum += input;
                    input = 0;
                    count++;
                    Console.WriteLine("Has ingresado {0} numeros y su suma es {1}", count, sum);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("No se admite el valor 0");
                    Console.Write("Has ingresado {0} numeros y su suma es {1}", count, sum);
                    break;
                }

            }
        }
    }
}
