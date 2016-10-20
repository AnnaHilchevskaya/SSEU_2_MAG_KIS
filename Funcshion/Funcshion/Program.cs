using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Funcshion
{
    class Program
    {
        static void Main(string[] args)
        { //объявляем переменные 
            double x, function, a, b, c;
            a=16; 
            b=8;
			c=1993;
 			//обеспечиваем ввод переменных с консоли
 			Console.WriteLine("Введите значение х");
             x = double.Parse(Console.ReadLine());
             function = (((-x) * (Math.Sqrt(x*x+b*x)))/ a) + c;
             Console.WriteLine("Function f(x):" + function);
             Console.ReadKey();
        }
    }
}
