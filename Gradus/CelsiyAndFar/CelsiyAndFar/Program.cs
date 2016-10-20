using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CelsiyAndFar
{
    class Program
    {
        static void Main(string[] args)
        {
            double c;//объявляем переменные
            // ввод переменных с консоли
            Console.Write("Введите температуру в градусах Цельсия: ");
            double.TryParse(Console.ReadLine(), out c);  ;
            double f = c * 9 / 5 + 32;// описание функции перевода в градусы Фаренгейта
            Console.WriteLine("Температура по Фаренгейту равна: {0}", f);
            Console.ReadKey(); // выход из программы только после нажатия клавиши
        }
    }
}
