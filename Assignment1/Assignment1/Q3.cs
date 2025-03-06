using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Q3
    {
        /*internal class Program
        {
            private static void Main(string[] args)
            {
                Employee employee = new Employee("hi", 234);
                employee.DisplayInfo();
                Manager manager = new Manager("manager", 234, 34);
                manager.DisplayInfo();
            }
        }*/ 

        class Employee
        {
            public string Name { get; set; }
            public decimal Salary { get; set; }

            public Employee(string brand, decimal speed)
            {
                Name = brand;
                Salary = speed;
            }

            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Name:{Name},salary: {Salary}");
            }
        }

        class Manager : Employee
        {
            public decimal Bonus;
            public Manager(string name, decimal salary, decimal bonus) : base(name, salary)
            {
                Bonus = bonus;
            }
            override public void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"bonous : {Bonus}");
            }
        }

    }
}
