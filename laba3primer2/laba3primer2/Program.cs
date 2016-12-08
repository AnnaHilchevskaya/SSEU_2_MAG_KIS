using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {//ввод длины массива
            int n;
            do
            {
                Console.Write("Введите длину массива:");
            } while (!int.TryParse(Console.ReadLine(), out n) || (n <= 0));
            //инициализация массива
            int i = 0;
            while (i < n)
            {
                Console.Write("Введите а [" + i + "]: ");
                if (int.TryParse(Console.ReadLine(), out a[i]))
                {
                    i++;
                }
                else
                {
                    Console.WriteLine(" Введите целое число! ");
                }; ;
            };
            // выход из программы
            Console.ReadKey();
        }
    }
}
