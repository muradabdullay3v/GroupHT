using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskStudent
{
    public class Group
    {
        public readonly string No;
        public Student[] Students;
        public static int num = 200;

        public Group(params Student[] Students)
        {
            num++.ToString();
            No = "BP" + num;
            Console.WriteLine($"New group created : {No}");
            this.Students = Students;
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref Students,Students.Length + 1);
            Students[^1] = student;
        }

        public void Sort()
        {
            Student temp;
            for (int i = 0; i < Students.Length - 1; i++)
            {
                for (int j = 0; j < Students.Length - 1; j++)
                {
                    if (Students[j].point > Students[j + 1].point)
                    {
                        temp = Students[j];
                        Students[j] = Students[j+1];
                        Students[j+1] = temp;
                    }
                }
            }
        }

        public void GetAllStudents()
        {

            foreach (var item in Students)
            {
                if(item.age == 0)
                {
                    continue;
                }
                Console.WriteLine($"Name : {item.name}\nSurname : {item.surname}\nAge : {item.age}\nId : {item.Id}\nPoint : {item.point}\n");
            }
        }

    }
}
