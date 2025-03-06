using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Q2
    {
        //internal class Program
        //{
        //    private static void Main(string[] args)
        //    {
        //        Console.WriteLine("Hello, World!");

        //        Car car = new Car("i32", 234);
        //        car.DisplayInfo();
        //        Bike bike = new Bike("harley", 9000);
        //        bike.DisplayInfo();
        //    }
        //}

        class Vehicle
        {
            public string Brand { get; set; }
            public decimal Speed { get; set; }

            public Vehicle(string brand, decimal speed)
            {
                Brand = brand;
                Speed = speed;
            }

            public virtual void DisplayInfo()
            {
                Console.WriteLine($"{Brand},{Speed}");
            }
        }

        class Car : Vehicle
        {
            public Car(string brand, decimal speed) : base(brand, speed)
            {

            }
            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine("THIS IS CAR DETAILS FUNCTION");
            }
        }


        class Bike : Vehicle
        {
            public Bike(string brand, decimal speed) : base(brand, speed)
            {
            }
            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine("this is bike details function");
            }
        }
    }
}
