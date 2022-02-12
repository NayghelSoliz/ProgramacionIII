using System;

namespace Practica1
{
    class Program
    {     
        static void Main(string[] args)
        {
            int nombre;
            int edad;
            Console.Write("Ingrese el nombre:");
            nombre = int.Parse(Console.ReadLine());
            string linea;
            Console.Write("Ingrese la edad:");
            linea = Console.ReadLine();
            edad = int.Parse(linea);
            int[] v = new int[edad];
            for (int i = 0; i < edad; i++)
            {
                Console.Write("Edad {0}:", (i + 1));
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < edad; i++)
            {
                for (int j = i + 1; j < edad; j++)
                {
                    int au;
                    if (v[i] > v[j])
                    {
                        au = v[i];
                        v[i] = v[j];
                        v[j] = au;
                    }
                }
            }
            Console.WriteLine("Los nombres y edades son:");
            for (int i = 0; i < edad; i++)
            {
                Console.WriteLine(v[i]);
            }
            Console.ReadKey();
        }
    }
}
