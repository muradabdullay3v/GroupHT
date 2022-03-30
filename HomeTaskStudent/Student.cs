using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskStudent
{
    public class Student
    {
        public readonly int Id;
        public string name;
        public string surname;
        public int age;
        public int point;
        public bool isWrong = false;

        public Student(string name , string surname , int age , int Id ,int point)
        {
            if (name == "" || name == " " || surname == "" || surname == " " || point <= 0)
            {
                Console.WriteLine("Verilen xarakteristikalarda sehv var!");
                isWrong = true;
                return;
            }
            this.point = point;
            this.Id = Id;
            this.name = name;
            this.age = age;
            this.surname = surname;
        }
        public void ShowInfo()
        {
            if (isWrong)
            {
                return;
            }
            Console.WriteLine($"Name : {name}\nSurname : {surname}\nAge : {age}\nId : {Id}\nPoint : {point}\n");
        }
    }
}
