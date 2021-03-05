using System;

namespace programa10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor introduzca su nombre: ");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Porfavor introduzca su edad:");
            int Edad = Convert.ToInt32(Console.ReadLine());
            if (Edad >= 18)
            {
                Console.WriteLine("Nombre: " + Nombre);
                Console.WriteLine("Edad: " + Edad);
                Console.WriteLine("Usted es mayor de edad");
            }
            else
            {
                Console.WriteLine("Nombre: " + Nombre);
                Console.WriteLine("Edad: " + Edad);
                Console.WriteLine("Usted no es mayor de edad");
            }
        }
    }
}
