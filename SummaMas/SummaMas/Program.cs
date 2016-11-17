using System;
using System.Collections.Generic;
using System.Text;

namespace SummaMas
{
    class SummaMas
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите значение: ");  
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];             
            }
            Console.WriteLine("Сумма: " + sum);
            Console.ReadKey();
        }
    }
}

