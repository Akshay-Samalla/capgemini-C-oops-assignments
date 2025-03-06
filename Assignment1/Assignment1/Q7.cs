using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Q7
    {
        /*internal class Program
        {
            private static void Main(string[] args)
            {
                Duck duck = new Duck();
                duck.Swim();
                duck.Fly();
            }
        }*/
        public interface IFlyable
        {
            void Fly();
        }
        public interface ISwimmable
        {
            void Swim();
        }
        class Duck : ISwimmable, IFlyable
        {
            public void Fly()
            {
                Console.WriteLine("duck is flying");
            }
            public void Swim()
            {
                Console.WriteLine("duck swiming");
            }
        }
    }
}
