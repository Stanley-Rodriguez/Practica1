using System;


namespace CursoCSharp_Practicas
{
    class Program
    {
        static void Main(string[] args)

        {
            /*Que reciba un numero y muestre su tabla de multiplicar. */
            int input, range, i = 0;
            Console.Write("Cual tabla desea obtener: ");
            input = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Hasta que rango la desea? ");
            range = int.Parse(Console.ReadLine());
            Console.Clear();
            for (i = 0; i <= range; i++)
            {
                Console.WriteLine("{0} x {1} = {2} ", input, i, input * i);
            }
        }
    }
}
