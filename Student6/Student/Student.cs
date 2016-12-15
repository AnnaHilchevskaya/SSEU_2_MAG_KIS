﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student
{
    class Student
    {
        public string FIO = "";                 //ФИО
        public string Nstud = "000000";         //№ студБилета
        public int kurs = 1;                    //Курс
        public string gruppa = "";              //Группа
        public bool budget = true;              //Бюджет
        public byte[,] ozenki = new byte[8, 5]; //Оценки

        //конструктор по умолчанию
        public Student() { }
        
        //содержимое полей в виде текста
        public override string ToString()
        {
            //строка с оценками
            string strOzenki = "";
            //перебор семестров
            for (int i = 0; i < 2 * kurs; i++)
            {
                //выводим номер семестра в начале строки
                strOzenki += (i + 1) + " семестр: ";
                //перебор экзаменов
                for (int j = 0; j < 5; j++)
                {
                    if (ozenki[i, j] == 1) //неявка
                        strOzenki += "неявка, "; //добавляем оценку к строке
                    else if (ozenki[i, j] > 1) //есть оценка
                        strOzenki += ozenki[i, j] + ", "; //добавляем оценку к строке
                };
            };
            return "ФИО: " + FIO + "\r\n" +
                   "№ студбилета: " + Nstud + "\r\n" +
                   "Курс: " + kurs + "\r\n" +
                   "Группа: " + gruppa + "\r\n" +
                   strOzenki + "\r\n" +
                   "Средний балл: " + SredniyBall();
        }
        public void PerevestiNaSledKurs()
        {
            //если курс не максимальный, то увеличить на 1
            if (kurs < 4)
                kurs += 1;
        }

        //вычислить средний балл
        public double SredniyBall()
        {
            double sum = 0; //сумма балов
            int n = 0; //количество экзаменов с оценками
            //суммируем и пересчитываем оценки в цикле
            for (int i = 0; i < 2 * kurs; i++)
                for (int j = 0; j < 5; j++)
                {
                    if (ozenki[i, j] > 1)
                    {
                        sum += ozenki[i, j];
                        n++;
                    };
                };
            //если были экзамены
            if (n > 0)
                return sum / n; //средний балл = сумма / количество
            else
                return 0; //средний балл = 0
    
        }
        //создание нового студента путем копирования полей из другого
        public Student(Student copyFrom)
        {
            //копируем значения всех полей
            FIO = copyFrom.FIO;
            Nstud = copyFrom.Nstud;
            kurs = copyFrom.kurs;
            gruppa = copyFrom.gruppa;
            ozenki = copyFrom.ozenki;
        }
    }
    class StudentBudg : Student
    {
        //скопировать
        public StudentBudg(Student copyFrom) : base(copyFrom) { }
     
        //определить сумму за указанный семестр
        const decimal stipSum = 1500m;
        const decimal stipPovyshSum = 1800m;
        public decimal Stipendia(int semestr)
        {
            //если семестр не выходит за допустимые границы
            if ((semestr >= 0) && (semestr <= 2 * kurs))
            {
                bool stip = true; //есть стипендия
                bool stipPovysh = true; //есть повышенная стипендия
                int n = 0; //количество экзаменов
                for (int i = 0; i < 5; i++)
                {
                    if (ozenki[semestr, i] > 0) //если экзамен был
                    {
                        n++; //увеличить количество экзаменов
                        stip &= (ozenki[semestr, i] > 3); //обычная стипендия - оценка выше 3
                        stipPovysh &= (ozenki[semestr, i] == 5); //повышенная - оценка 5
                    };
                };
                if (n == 0) //не было экзаменов
                    return 0; //еще нет стипендии
                if (stipPovysh) //есть повышенная стипендия
                    return stipPovyshSum;
                else if (stip) //есть обычная стипендия
                    return stipSum;
                else
                    return 0;
            };
            return 0; //недопустимый семестр - нет стипендии
        }

        //вывод информации о студенте-бюджетнике
        public override string ToString()
        {
            //формируем записи о стипендии за каждый семестр
            string stipendia = "Стипендия:\r\n";
            for (int i = 0; i < 2 * kurs; i++)
                stipendia += i + " семестр: " + Stipendia(i) + " руб.\r\n";
            //собираем результат из
            return base.ToString() + "\r\n" //метода класса-предка (Student),
                + "Обучение на бюджетной основе\r\n" //записи о бюджетном обучении
                + stipendia; //и стипендии
        }

    }

    class StudentPlat : Student
    {
        public StudentPlat(Student copyFrom) : base(copyFrom)
        {
            //если студент copyForm является платником
            if (copyFrom is StudentPlat)
            {
                //то скопировать стоимость обучения и сумму долга
                //рассматривая соpyFrom как платника
                stoimostObucheniya = (copyFrom as StudentPlat).stoimostObucheniya;
                oplacheno = (copyFrom as StudentPlat).oplacheno;
            };
        }
        public decimal stoimostObucheniya; //стоимость обучения за семестр
        public decimal oplacheno; //сколько оплатил студент в сумме

        //оплатить обучение
        public void OplatitObuchenie(decimal sum)
        {
            //долг снижается на указанную сумму
            oplacheno += sum;
        }

        //задолженность за обучение (или переплата, если отрицательное)
        public decimal Dolg()
        {
            //долг = стоимость обучения за семестр * кол-во семестров - оплаченная сумма
            return stoimostObucheniya * kurs * 1 - oplacheno;
        }

        public override string ToString()
        {
            //собираем результат из
            return base.ToString() + "\r\n" //метода класса-предка (Student),
                + "Обучение на платной основе\r\n" //записи о платном обучении
                + "Стоимость обучения: " + stoimostObucheniya + " руб.\r\n"
                + "Задолженность: " + Dolg() + " руб.";//и стипендии
        }
    }
}
