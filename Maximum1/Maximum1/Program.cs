using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum1
{
    class Program
    {
        static void Main(string[] args)
        {//���� �������� ��������
            int A, B, C;
            if (int.TryParse(Console.ReadLine(), out A) && int.TryParse(Console.ReadLine(), out B) && int.TryParse(Console.ReadLine(), out C))
            {   int Max; 
                // ����  � >= �
                if (A >= B)
                {
                    //� ���� � >=�
                    if (A >= C)
                    {
                        // �� ������������ - �
                        Max = A;
                    }
                        // ����� � > A
                    else
                    {
                        // ������������ - �
                        Max = C;
                    }
                }
                    //����� ������ �
                else
                {
                    //  � ���� B >= C
                    if (B >= C)
                    {
                        // �� ������������ -  B
                        Max = B;
                    }
                        // ����� � > B
                    else
                    {
                        // ������������ - C
                        Max = C;
                    }
                };
                // ����� ���������� 
                Console.WriteLine(" ������������ = " + Max);
            }
            // ���������� ���������
            Console.ReadKey();
        }
    }
}
