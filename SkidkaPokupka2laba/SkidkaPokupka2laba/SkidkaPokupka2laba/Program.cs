using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkidkaPokupka2laba
{
    class Program
    {
        static void Main(string[] args)
        { //объявляем переменные 
            Console.WriteLine("Введите сумму вашей покупки");
           int sum;
            int.TryParse(Console.ReadLine(), out sum);
             double itog;
            if (sum > 1000) // условие, больше данного числа давать скидку.
            {
               itog = sum - (sum * 15 / 1000);// расчет скидки
                Console.WriteLine("Сумма вашей поупки с учетом скидки составит " + itog);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Cкидка на на сумму вашей покупки не предоставляется! ");
            };
            Console.ReadKey();
        }
    }
 }