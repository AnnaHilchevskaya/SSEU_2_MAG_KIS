﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Primer4
{
    class Primer4
    {
        static void Main(string[] args)
        {
            double operand1, operand2 = 0; //операнды
            double result = 0; //результат вычисления
            string operation; //действие
            Console.WriteLine("Введите число: ");
            if (double.TryParse(Console.ReadLine(), out operand1))
            {
                //выбираем операцию
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("+ - сложение");
                Console.WriteLine("- - вычитание");
                Console.WriteLine("* - умножение");
                Console.WriteLine("/ - деление");
                Console.WriteLine("sqrt - корень из числа");
                operation = Console.ReadLine();
                switch (operation)
                {
                    //операции с двумя операндами
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                        //считываем второй операнд
                        Console.WriteLine("Введите второе значение: ");
                        if (double.TryParse(Console.ReadLine(), out operand2))
                        {
                            //какая именно операция?
                            switch (operation)
                            {
                                case "+": result = operand1 + operand2; break;
                                case "-": result = operand1 - operand2; break;
                                case "*": result = operand1 * operand2; break;
                                case "/": result = operand1 / operand2; break;
                            };
                        }
                        else
                        {
                            Console.WriteLine("Операнд должен быть числом!");
                        };
                        break;
                    //операция с одним операндом
                    case "sqrt": result = Math.Sqrt(operand1); break;
                    //недопустимые операции
                    default: Console.WriteLine("Неверная операция!"); break;
                };
                //выводим результат
                Console.WriteLine("Результат: ");
                Console.WriteLine(operand1 + " " + operation + " " + operand2 + " = " + result);
            }
            else
            {
                Console.WriteLine("Операнд должен быть числом!");
            };
            Console.ReadKey();
        }
    }
}
