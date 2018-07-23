using System;


namespace CursoCSharp_Practicas
{
    class Program
    {
        static void Main(string[] args)

        {
            /* Pida al usuario dos números reales (que se guardarán en las variables
            * dato1 y dato2).Si dato2 es cero, deberá mostrar un mensaje de error,
            * y en caso contrario mostrará en pantalla el resultado de dividir dato1 entre dato2. */
            int dato1, dato2, resultado;
            Console.Write("Ingrese el dato1: ");
            dato1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Ingrese el dato2: ");
            dato2 = int.Parse(Console.ReadLine());
            Console.Clear();
            if (dato2 != 0)
            {
                resultado = dato1 / dato2;
                Console.Write(resultado);
            }
            else
            {
                Console.Write("Imposible difivir entre 0");
            }
        }
    }
}
