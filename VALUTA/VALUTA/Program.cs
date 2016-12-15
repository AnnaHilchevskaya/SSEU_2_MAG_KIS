using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VALUTA
{
    class VALUTA
    {
        static void Main(string[] args)
          {
             int m;
             int n;
             double x;
             double result = 0;
             double rub;
             Console.WriteLine("Введите номер валюты для перевода:");
             Console.WriteLine("1 - евро");
             Console.WriteLine("2 - доллар");
             Console.WriteLine("3 - фунты");
             Console.WriteLine("4 - иены");
             if (int.TryParse(Console.ReadLine(), out m))
             {
                 Console.WriteLine("Введите число:");
                 if (double.TryParse(Console.ReadLine(), out x))
                 {
                     switch (m)
                     {
                         case 1: result = x / 70.43; break;
                         case 2: result = x / 64.45; break;
                         case 3: result = x / 79.32; break;
                         case 4: result = x / 1.62; break;
                         default: Console.WriteLine("Не верно! Валюта с данным номером не найдена"); break;
                     }
                 }
                 else
                 {
                     Console.WriteLine("Неверное значение! Введите число.");
                 };
                 rub = result;
                  Console.WriteLine("Выберете в какую валюту перевести:");
                 Console.WriteLine("1 - евро");
                 Console.WriteLine("2 - доллар");
                 Console.WriteLine("3 - фунты");
                 Console.WriteLine("4 - иены");
                 if (int.TryParse(Console.ReadLine(), out n))
                 {
                     
                     switch (n)
                     {
                         case 1: result = x * 70.43; break;
                         case 2: result = x * 64.45; break;
                         case 3: result = x * 79.32; break;
                         case 4: result = x * 1.62; break;
                         default: Console.WriteLine("Введите число"); break;                         
                        
                      }
                  }
                  else
                 {
                     Console.WriteLine("Не верно! Введите целое число.");
                 };
             }
             else
             {
                 Console.WriteLine("Не верно! Введите целое число.");
             };
             Console.WriteLine("Результат: " + result);
             Console.ReadKey();
         }
    }
}