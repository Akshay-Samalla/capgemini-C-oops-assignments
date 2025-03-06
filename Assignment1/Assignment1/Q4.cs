using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Q4
    {
        /*internal class Program
        {
            private static void Main(string[] args)
            {
                Dog dog = new Dog();
                dog.MakeSound();
                Cat cat = new Cat();
                cat.MakeSound();
            }
        }
        */
        abstract class Animal
        {
            public abstract void MakeSound();
        }

        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("woof woof");
            }
        }
        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("mew mew");
            }
        }
    }
}
