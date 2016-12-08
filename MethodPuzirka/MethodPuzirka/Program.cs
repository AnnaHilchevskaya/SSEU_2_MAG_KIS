using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 
 namespace MethodPuzirka
 {
     class Program
     {
         static void Main(string[] args)
         {
             //ввод длины массива
             int n;
             do
             {
                 Console.Write("Введите длину массива: ");
             } while (!int.TryParse(Console.ReadLine(), out n) || (n <= 0));
             //инициализация массива
             int[] a = new int[n];
             //ввод значений массива
             int i = 0;
             while (i < n)
             {
                 Console.Write("Введите a[" + i + "]: ");
                 if (int.TryParse(Console.ReadLine(), out a[i]))
                 {
                     i++;
                 }
                else
                 {
                     Console.WriteLine("Введите целое число!");
                 }; ;
             };
             //сортировка массива
             for (i = 0; i < a.Length - 1; i++)
             {
                 for (int j = 1; j < a.Length - i; j++)
                 {
                     //если предыдущий элемент больше текущего, поменять их местами
                     if (a[j - 1] > a[j])
                     {
                         int buf = a[j];
                         a[j] = a[j - 1];
                         a[j - 1] = buf;
                     };
                 };
             };
             //вывод отсортированного массива
             Console.WriteLine("Отсортированный массив:");
             for (i = 0; i < a.Length; i++)
            {
                 Console.WriteLine(a[i]);
             };
             //выход из программы
             Console.ReadKey();
         }
     }
 }