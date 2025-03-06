using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Q8
    {
       /* internal class Program
        {
            private static void Main(string[] args)
            {
                Student student = new Student("name", 900);
                Console.WriteLine($"student name :{student.Name}");
                Console.WriteLine($"student grade:{student.Grade}");
                Person person = student;
                Console.WriteLine($"person name :{person.Name}");
                Student oldstudent = (Student)person;
                Console.WriteLine($"oldstudnet name and grade :{oldstudent.Name},{oldstudent.Grade}");
            }
        }*/
        class Person
        {
            public string Name { get; set; }
            public Person(string name)
            {
                Name = name;
            }
        }
        class Student : Person
        {
            public decimal Grade { get; set; }
            public Student(string name, decimal grade) : base(name)
            {
                Grade = grade;
            }
        }
    }
}
