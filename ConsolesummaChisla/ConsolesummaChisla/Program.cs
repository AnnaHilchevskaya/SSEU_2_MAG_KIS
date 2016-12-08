using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace summaChisla
{
    class summachisla
    {
        public static int Summa(int a)
        {// объявляем переменные 
            int s = 0;
            while (a > 0)
            {
                s = s + (a % 10);
                a = a / 10;
            }
            return s;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Summa={0}", Summa(a)); //выводим сумму
            Console.ReadKey();
        }
    }
} 
