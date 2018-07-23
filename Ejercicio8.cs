using System;


namespace CursoCSharp_Practicas
{
    class Program
    {
        static void Main(string[] args)

        {
            /*Pida al usuario dos números enteros (que se guardarán en las variables num1 y num2).
             * Si num2 es cero, deberá mostrar un mensaje de error, y en caso contrario mostrará en
             * pantalla el resto de la división de num1 entre num2*/

            int num1, num2, resultado;
            Console.Write("Ingrese el dato1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Ingrese el dato2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Clear();
            if (num2 != 0)
            {
                resultado = num1 % num2;
                Console.Write(resultado);
            }
            else
            {
                Console.Write("Imposible dividir entre 0");
            }
        }
    }
}
