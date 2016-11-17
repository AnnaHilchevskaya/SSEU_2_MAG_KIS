using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum3logI
{
    class Program
    {
        static void Main(string[] args)
        {//ввод исходных значений
            int A, B, C;
            if (int.TryParse(Console.ReadLine(), out A) && int.TryParse(Console.ReadLine(), out B) && int.TryParse(Console.ReadLine(), out C))
            {
                int Max;
                // если  А больше остальных
                if ((A >= B) && (A >= C))
                {
                    Max = A;
                }
                // иначе, если B больше остальных
                else if ((B >= A) && (B >= C))
                {
                    Max = B;
                }
                // иначе - остается С
                else
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