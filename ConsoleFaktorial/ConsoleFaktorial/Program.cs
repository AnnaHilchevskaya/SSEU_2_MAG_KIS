 using System;
 using System.Collections.Generic;
 using System.Text;

namespace Faktorial
 {  
    class Program  
    {  
     static void Main(string[] args)       
        {   
        int n = 10;  // количество циклов в факториале          
        int factorial = 1;   // значение факториала    
        for (int i = 2; i <= n; i++) // цикл начинаем с 2, т.к. нет смысла начинать с 1     
             {   factorial = factorial * i;  
                    }                Console.WriteLine("Факториал 10 " + n + " = " + factorial);             
                      Console.Read();    
                         }   
                    } }
