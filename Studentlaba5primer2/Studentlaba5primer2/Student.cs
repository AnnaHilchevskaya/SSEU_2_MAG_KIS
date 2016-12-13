using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student
{
    class Student
    {
        public string FIO = "";   // ФИО
        public string Nstud = "000000";   // № студ билета
        public int kurs = 1;   // курс
        public string gruppa = "";//группа
        public bool budget = true; //бюджет
        public byte[,] ozenki = new byte[8, 5]; //оценки

        public string ToString()
        {
            return "ФИО: " + FIO + "\r\n" +
                      "№ СТУДБИЛЕТА: " + Nstud + "\r\n" +
                      "КУРС: " + kurs + "\r\n" +
                      "ГРУППА: " + gruppa + "\r\n" +
                      (budget ? "На бюджетной основе" : "На коммерческой основе");
        }
    }
}
