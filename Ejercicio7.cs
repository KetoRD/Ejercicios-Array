using System;

namespace programa7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un nombre: ");
            string nombre = Console.ReadLine();
            int a = nombre.Length;
            int b;
            a--;
            for (b = 0; b <= a; b++)
                Console.Write(nombre[b] + " ");
        }
    }
}
