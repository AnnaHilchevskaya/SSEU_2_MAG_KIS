using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum1
{
    class Program
    {
        static void Main(string[] args)
        {//ввод исходных значений
            int A, B, C;
            if (int.TryParse(Console.ReadLine(), out A) && int.TryParse(Console.ReadLine(), out B) && int.TryParse(Console.ReadLine(), out C))
            {   int Max; 
                // если  А >= В
                if (A >= B)
                {
                    //и если А >=С
                    if (A >= C)
                    {
                        // то максимальное - А
                        Max = A;
                    }
                        // иначе С > A
                    else
                    {
                        // максимальное - С
                        Max = C;
                    }
                }
                    //иначе больше В
                else
                {
                    //  и если B >= C
                    if (B >= C)
                    {
                        // то максимальное -  B
                        Max = B;
                    }
                        // иначе С > B
                    else
                    {
                        // максимальное - C
                        Max = C;
                    }
                };
                // Вывод результата 
                Console.WriteLine(" Максимальное = " + Max);
            }
            // Завершение программы
            Console.ReadKey();
        }
    }
}
