using System;

namespace ISNP966920_Unidad1
{
    class Program
    {
        static void Main(string[] args)
        {

            int num =1;
            while (num != 0)
            {
                Console.WriteLine("Bienvenido, ingrese por favor un valor: ");
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    Console.WriteLine("El numero ingresado es positivo");
                }
                else
                {
                    Console.WriteLine("El numero ingresado es negativo");
                }
            }

        }
    }
}
