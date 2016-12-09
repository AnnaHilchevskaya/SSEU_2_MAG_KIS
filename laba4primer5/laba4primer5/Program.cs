using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;
 
 namespace Lab_4_primer_5_1
 {
     class Program
     {
         static void Main(string[] args)
         {
             char key;
             string txt = "";//обрабатываемая строка
             do
             {
                 //очистка окна
                 Console.Clear();
                 //вывод меню
                 Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
                 Console.WriteLine("\t\t\t╔══════════════════════════╗");
                 Console.WriteLine("\t\t\t║           МЕНЮ           ║");
                 Console.WriteLine("\t\t\t║ 1 - ввести новую строку  ║");
                 Console.WriteLine("\t\t\t║ 2 - поиск                ║");
                 Console.WriteLine("\t\t\t║ 3 - замена               ║");
                 Console.WriteLine("\t\t\t║ 4 - удаление             ║");
                 Console.WriteLine("\t\t\t║ 5 - вставка              ║");
                 Console.WriteLine("\t\t\t║ 6 - обрезка              ║");
                Console.WriteLine("\t\t\t║ ESC - выход              ║");
                 Console.WriteLine("\t\t\t╚══════════════════════════╝");
                 key = Console.ReadKey().KeyChar;
                 //проверить клавишу
                 switch (key)
                 {
                     case '1'://ввод новой строки
                         Console.Clear();
                         Console.WriteLine("Введите новую строку: ");
                         txt = Console.ReadLine();
                         break;
                     case '2': //поиск подстроки
                         Console.Clear();
                         Console.WriteLine("Строка: " + txt);
                         Console.WriteLine();
                         Console.WriteLine("Введите подстроку для поиска:");
                         string substr = Console.ReadLine();
                         //индекс подстроки
                         int pos = txt.IndexOf(substr);
                         //если индекс отрицательный - подстрока не найдена
                         if (pos >= 0)
                         {
                             Console.WriteLine("Подстрока найдена на символе: " + pos);
                             //вывод подстроки с подстветкой
                             Console.Write(txt.Substring(0, pos));   
                             Console.ForegroundColor = ConsoleColor.Red;
                             Console.Write(txt.Substring(pos, substr.Length));   //то что выделили
                             Console.ResetColor();
                             Console.WriteLine(txt.Substring(pos + substr.Length)); 
                        }
                         else
                         {
                             Console.WriteLine("Подстрока не найдена!");
                         };
                         // в главное меню
                         Console.Write("Нажмите любую клавишу для возврата в главное меню...");
                         Console.ReadKey();
                         break;
                     case '3': //замена подстроки
                         Console.Clear();
                         Console.WriteLine("Строка: " + txt);
                         Console.WriteLine();
                         Console.WriteLine("Введите подстроку для поиска:");
                         string substrOld = Console.ReadLine();
                         Console.WriteLine("Введите подстроку для замены:");
                         string substrNew = Console.ReadLine();
                         //выполняем замену замену
                         txt = txt.Replace(substrOld, substrNew);
                         //возврат в главное меню
                         Console.Write("Нажмите любую клавишу для возврата в главное меню...");
                         Console.ReadKey();
                         break;
                     case '4': //удаление подстроки
                         Console.Clear();
                         Console.WriteLine("Строка: " + txt);
                         Console.WriteLine();
                         Console.WriteLine("Введите подстроку для удаления:");
                         string substrDel = Console.ReadLine();
                         //замена на пустую
                         txt = txt.Replace(substrDel, "");
                         //возврат в главное меню
                        Console.Write("Нажмите любую клавишу для возврата в главное меню...");
                         Console.ReadKey();
                         break;
                     case '5': //вставка подстроки
                         Console.Clear();
                         Console.WriteLine("Строка: " + txt);
                        Console.WriteLine();
                         Console.WriteLine("Введите подстроку для вставки:");
                         string substrIns = Console.ReadLine();
                         Console.WriteLine("После какого символа вставить:");
                         //если введена корректная позиция
                         if (int.TryParse(Console.ReadLine(), out pos) && pos < txt.Length)
                         {
                             //вставить подстроку
                             txt = txt.Insert(pos, substrIns);
                        }
                         else
                         {
                             Console.WriteLine("Ошибка! Номер символа должен быть числом не более длины строки. ");
                        };
                         //возврат в главное меню
                         Console.Write("Нажмите любую клавишу для возврата в главное меню...");
                         Console.ReadKey();
                         break;
                     case '6': //обрезка строки
                         Console.Clear();
 
    
     
   Console.WriteLine("Строка: " + txt);
                         Console.WriteLine();
                         Console.WriteLine("После какого символа удалить: ");
                         //если введена корректная позиция
                         if (int.TryParse(Console.ReadLine(), out pos) && pos < txt.Length)
                         {
                             //вводим количество символов
                             int len;
                            Console.WriteLine("Сколько символов удалить: ");
                             if (int.TryParse(Console.ReadLine(), out len))
                             {
                                 //удаляем
                                txt = txt.Remove(pos, len);
                             }
                             else
                             {
                                Console.WriteLine("Ошибка.Длина должна быть целым числом.");
                             };
                         }
                         else
                         {
                             Console.WriteLine("Ошибка!Номер символа должен быть числом не более длины строки.");
                         };
                         //возврат в главное меню
                         Console.Write("Нажмите любую клавишу для возврата в главное меню...");
                        Console.ReadKey();
                         break;
                 };
             }
             while (key != (char)27);//пока не нажали ескейп
         }
     }
 }