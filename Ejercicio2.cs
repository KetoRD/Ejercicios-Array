using System;

namespace programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese 5 números reales: ");
            int[] num = new int[5];
            for (int a = 0; a < 5; a++)
            {
                num[a] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Estos son los numeros ingresados, en el orden contrario: ");
            Array.Reverse(num);
            for (int a = 0; a < 5; a++)
            {
                Console.WriteLine(num[a]);
            }
            
        }
    }
}
