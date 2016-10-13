using System;
using System.Collections.Generic;
using System.Text;

namespace ReadAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;//задаем тип переменных целые числа
            int b;// и сразу же вводим значени€ переменных с консоли 
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            int sum = a + b;
            Console.WriteLine(a + " + " + b + " = " + sum);//«апишем сумму a и b в третью переменную с именем sum 
            Console.ReadKey();
        }
    }
}

