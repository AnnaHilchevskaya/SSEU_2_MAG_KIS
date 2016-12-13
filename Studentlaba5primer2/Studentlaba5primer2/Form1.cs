using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class FormStudent : Form
    {
        Student student1 = new Student(); // объект класса студент
        public FormStudent()
        {
            InitializeComponent();
        }

        private void textBoxFIO_TextChanged(object sender, EventArgs e)
        {
            student1.FIO = textBoxFIO.Text; //Сохранить фио 
            textBoxStudentInfo.Text = student1.ToString(); 
        }

        private void textBoxNstud_TextChanged(object sender, EventArgs e)
        {
            student1.Nstud = textBoxNstud.Text; //сохранить номер студбилета 
            textBoxStudentInfo.Text = student1.ToString();       
        }

        private void textGruppa_TextChanged(object sender, EventArgs e)
        {
            student1.gruppa = textGruppa.Text; //Сохранить группу 
            textBoxStudentInfo.Text = student1.ToString();
        }

        private void numericUpDownKurs_ValueChanged(object sender, EventArgs e)
        {
            student1.kurs = (int)numericUpDownKurs.Value; //Сохранить курс 
            textBoxStudentInfo.Text = student1.ToString();
        }

        private void radioButtonBudget_CheckedChanged(object sender, EventArgs e)
        {
            student1.budget = radioButtonBudget.Checked; //Сохранить бюджет.коммерцию
            textBoxStudentInfo.Text = student1.ToString();

        }

       
        

       

       
    }
}
