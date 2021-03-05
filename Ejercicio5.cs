using System;

namespace programa5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Nombres = new string[100];

            int a = 0;
            do
            {
                Console.WriteLine("Ingrese un nombre: ");
                a++;
                Nombres[a] = (Console.ReadLine());

            }
            while (Nombres[a] != "");

            Console.WriteLine("Estos son todos los nombres ingresados: ");
            foreach (string b in Nombres) 
            {
                Console.WriteLine(b);
            }
            Console.ReadKey();
        }
    }
}
