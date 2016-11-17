using System;
using System.Collections.Generic;
using System.Text;

namespace maximalnoeizpervihdvuh
{
    class Program
    {
        static void Main(string[] args)
        {//ввод исходных значений
            int A, B, C;
            if (int.TryParse(Console.ReadLine(), out A) && int.TryParse(Console.ReadLine(), out B) && int.TryParse(Console.ReadLine(), out C))
            {
                int Max;
                // если  А больше 
                if (A >= B)
                {
                    Max = A;
                }
                // иначе B больше
                else
                {
                    Max = B;
                };
                // если С больше максимального из А, В, то С- максимальное
               if (C >= Max)
                {
                    Max = C;

                };

                // Вывод результата 
                Console.WriteLine(" Максимальное = " + Max);
            }
            // Завершение программы
            Console.ReadKey();
        }
    }
}