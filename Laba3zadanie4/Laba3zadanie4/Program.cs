using System;
using System.Collections.Generic;
using System.Text;
 
 namespace laba3zad4
 {
     class Program
    {
         static void Main(string[] args)
         {
             //ввод длины массива
             int n;
             do
             {
                Console.Write("ВВедите длину массива: ");
             } while (!int.TryParse(Console.ReadLine(), out n) || (n <= 0));
             //инициализация массива
             
            int[] a = new int[n];
             int i = 0;
             int right=a.Length;
             int left=1;
             while (i < n)
             {
                Console.Write("Введите а[" + i + "]:");
                 if (int.TryParse(Console.ReadLine(), out a[i]))
                 {
                     i++;
                 }
                 else
                 {
                     Console.WriteLine("Введите целое число");
                 }; ;
            };
             Console.WriteLine("Выберите сортировку: 1-по возрастанию, 2- по убыванию");
             int var;
             int.TryParse(Console.ReadLine(), out var);
             switch (var) 
             {
                 case 1://сортировка массива по возрастанию
                     while (left <= right)
                     {
                         //проход вправo
                         for (i = left; i < right; ++i)
                         {
                             if (a[i - 1] > a[i])
                             {
                                 int buf = a[i];
                                 a[i] = a[i - 1];
                                 a[i - 1] = buf;
                             }
                         }
                        right = right - 1;
 
                         //проход влево
                         for (i = right; i >= left; --i)
                        {
                             if (a[i] < a[i - 1])
                             {
                                 int buf = a[i];
                                a[i] = a[i - 1];
                                 a[i - 1] = buf;
                             }
                         }
                         left = left + 1;
                     };
                     break;
                case 2://сортировка массива по убыванию
                     while (left <= right)
                    {
                         //проход вправo
                         for (i = left; i < right; ++i)
                         {
                             if (a[i] > a[i-1])
                             {
                                 int buf = a[i-1];
                                 a[i-1] = a[i];
                                 a[i] = buf;
                            }
                         }
                         right = right - 1;
 
                         //проход влево
                         for (i = right; i >= left; --i)
                         {
                             if (a[i-1] < a[i])
                             {
                                 int buf = a[i-1];
                                 a[i-1] = a[i];
                                 a[i] = buf;
                             }
                         }
                         left = left + 1;
                     };
                     break;
             }
             //вывод отсортированного массива
             Console.WriteLine("Отсортированный массив:");
             for (i = 0; i < a.Length; ++i)
             {
                 Console.WriteLine(a[i]);
             };//Выход из программы
             Console.ReadKey();
         }
     }
 }