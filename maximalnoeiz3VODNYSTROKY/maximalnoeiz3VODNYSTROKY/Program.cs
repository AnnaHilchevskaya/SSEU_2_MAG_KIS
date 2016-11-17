using System;
using System.Collections.Generic;
using System.Text;

namespace maximalnoeiz3VODNYSTROKY
{
    class Program
    {
        static void Main(string[] args)
        {//ввод исходных значений
            int A, B, C;

            if (int.TryParse(Console.ReadLine(), out A))
            {
                if (int.TryParse(Console.ReadLine(), out B))
                {
                    if (int.TryParse(Console.ReadLine(), out C))
                    {// максимальное значение
                        int Max = ((Max = (A >= B) ? A : B) >= C) ? Max : C;


                        // Вывод результата 
                        Console.WriteLine(" Максимальное = " + Max);
                    }
                    // Завершение программы
                    Console.ReadKey();
                }
            }
        }
    }
}