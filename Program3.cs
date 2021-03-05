using System;

namespace programa3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meses_del_año = { "no valido", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };


            Console.WriteLine("Ingrese el número del año que desea conocer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (a > 0 && a < 13)
                {
                    switch (a)
                    {
                        case 1:
                            Console.WriteLine(meses_del_año[0] + "tiene 31 dias");
                            break;
                        case 2:
                            Console.WriteLine(meses_del_año[1] + "tiene 28 dias");
                            break;
                        case 3:
                            Console.WriteLine(meses_del_año[2] + "tiene 31 dias");
                            break;
                        case 4:
                            Console.WriteLine(meses_del_año[3] + " tiene 30 dias");
                            break;
                        case 5:
                            Console.WriteLine(meses_del_año[4] + " tiene 31 dias");
                            break;
                        case 6:
                            Console.WriteLine(meses_del_año[5] + " tiene 30 dias");
                            break;
                        case 7:
                            Console.WriteLine(meses_del_año[6] + " tiene 31 dias");
                            break;
                        case 8:
                            Console.WriteLine(meses_del_año[7] + " tiene 31 dias");
                            break;
                        case 9:
                            Console.WriteLine(meses_del_año[8] + " tiene 30 dias");
                            break;
                        case 10:
                            Console.WriteLine(meses_del_año[9] + " tiene 31 dias");
                            break;
                        case 11:
                            Console.WriteLine(meses_del_año[10] + " tiene 30 dias");
                            break;
                        case 12:
                            Console.WriteLine(meses_del_año[11] + " tiene 31 dias");
                            break;
                    }
                }else
                {
                    Console.WriteLine("El número que acabas de ingresar no coincide con ningún mes del año");
                    Console.WriteLine("Vuelve a intentarlo");
                }
            
            } while (a < 1 && a > 13);


        }
    }
}
