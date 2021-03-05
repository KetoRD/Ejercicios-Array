using System;
using System.Linq;

namespace programa4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            Console.WriteLine("Ingrese 10 numeros: ");

            for (int a = 0; a < 10; a++)
            {
                nums[a] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Este es el numero mayor de todos los ingresados anteriormente: ");
            for (int a = 9; a < 10; a++)
            {
                Console.WriteLine(nums.Max());
            }
           

        }
    }
}
