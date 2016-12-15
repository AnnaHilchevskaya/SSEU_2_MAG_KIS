using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4Zad3
 {
     class Program
   {
         static void Main(string[] args)
 
         {
             Console.WriteLine("Введите предложение");
             string str = Console.ReadLine();
             str = str.Trim();
             int col_slov = 1;
             //считаем количество слов в строке
             for (int i = 0; i < str.Length; ++i)
             {
                 if (str[i] != ' ' && str[i] != '.' && str[i] != ',' && str[i] != '-' && str[i] != '?' && str[i] != '!' && str[i] != ';' && str[i] != ':')
                 {
 
                     //Console.WriteLine("Текущий символ - " + str[i]);
                 }
                 else
                {
                     col_slov = col_slov + 1;
                 };
             }
             //Console.WriteLine(col_slov);
 
             string[] Array = new string[col_slov];
             char buffer = ' ';
             string buf = str[0].ToString();//первая буква в строке
             int p = 0;//индекс для прохождения по строке
             for (int j = 0; p < str.Length;)//заводим слова в массив, j-индекс эелемента массива из слов
             {
                 if (str[p] != ' ' && str[p] != '.' && str[p] != ',' && str[p] != '-' && str[p] != '?' && str[p] != '!' && str[p] != ';' && str[p] != ':')
                 {
                     switch (p)
                     {
                         case 0:
                             Array[j] = buf;
                             ++p;
                             break;
                         default:
                             buf = buf + str[p].ToString();
                             Array[j] = buf;
                             ++p;
                             break;
                     }
                 }
                 else
                 {
                     buf = buffer.ToString();
                     ++p;
                     ++j;
                 };
             }
             int max = Convert.ToInt32(Array[0].Length);
             string buf_str = Array[0];
 
            
             for (int i = 0; i < col_slov; ++i)
             {
                 if (Array[i].Length > max)
                 {
                     max = Convert.ToInt32(Array[i].Length);
                     buf_str = Array[i];
                 }
             }
             Console.WriteLine("Самое длинное слово состоит из " + (max - 1)+ " букв");
             Console.WriteLine("Это слово: " + buf_str);
 
             Console.ReadKey();
         }
     }
 }