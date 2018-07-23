using System.Collections.Generic;
using System;


namespace CursoCSharp_Practicas
{
    class Program
    {
        static void Main(string[] args)

        {
            /*Genere el promedio de los valores almacenados en 5 variables enteras.*/
            int inputlist, v1, v2, v3, v4, v5, n = 1;
            List<int> l = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese el valor de la variable " + n + " : ");
                inputlist = int.Parse(Console.ReadLine());
                l.Insert(i, inputlist);
                inputlist = 0;
                n++;
                Console.Clear();
            }

            v1 = l[0];
            v2 = l[1];
            v3 = l[2];
            v4 = l[3];
            v5 = l[4];
            var cont = l.Count;
            var promedio = (v1 + v2 + v3 + v4 + v5) / cont;
            Console.WriteLine("El promedio de los numeros capturados es: " + promedio + "");

        }
    }
}
