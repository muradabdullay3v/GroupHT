using System;

namespace HomeTaskStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Me = new Student("Murad" , "Abdullazade" , 19 , 5 , 100);
            Student NotMe = new Student("Tosu" , "Zengilanli" , 30 , 1 , 99);
            Student NoName = new Student("Qaqa" , "Qaqayev" , 58 , 13 , 2);
            Student MoName = new Student("Baba" , "Babayev" , 72 , 126 , 56);
            Student QoName = new Student("Lala" , "Lalayev" , 16 , 154 , 45);
            Me.ShowInfo();
            NotMe.ShowInfo();
            NoName.ShowInfo();
            Group BP201 = new Group(Me , NotMe , NoName);
            BP201.AddStudent(MoName);
            BP201.Sort();
            BP201.GetAllStudents();
            Group BP202 = new Group(QoName);
        }
    }
}