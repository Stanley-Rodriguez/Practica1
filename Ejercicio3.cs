using System;


namespace CursoCSharp_Practicas
{
    class Program
    {
        static void Main(string[] args)

        {
            /*Que solicite la edad del usuario y diga si es un niño, un adolescente,
            * un juven o un adulto*/
            int edad;
            Console.Write("Por favor ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad <= 10)
            {
                Console.WriteLine("Usted es un niño");
            }
            else if (edad > 10 && edad <= 14)
            {
                Console.WriteLine("Usted es un adolescente");
            }
            else if (edad > 14 && edad <= 17)
            {
                Console.WriteLine("Usted es un joven");
            }

            else if (edad >= 18)
            {
                Console.WriteLine("Usted es adulto");
            }
        }
    }
}
