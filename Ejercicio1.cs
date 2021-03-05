using System;

namespace programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola! ");
            Console.WriteLine("Ingresa 4 números: ");

            int[] num = new int[4];
            for (int a = 0; a < 4; a++)
            {
                Console.WriteLine("Ingrese el numero {0}", a);
                num[a] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Los numeros tecleados anteriormente son: ");
            for (int a = 0; a < 4; a++)
            {
                Console.WriteLine(num[a]);
            }

            for (int a = 3; a < 4; a++)
            {
                int mediaAri = (num[0] + num[1] + num[2] + num[3]) / 4;
                Console.WriteLine("La media aritmetica de los valores ingresados anteriormente es: ");
                Console.WriteLine(mediaAri);
            }
        }   
            
        
                
            
}
}
