using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Q5
    {
        /*internal class Program
        {
            private static void Main(string[] args)
            {
                Robot machine = new Robot();
                machine.Start();
                machine.move();
            }
        }*/


        interface IMoveable
        {
            public void move();
        }
        class Machine
        {
            public void Start()
            {
                Console.WriteLine("machine started ");
            }
        }
        class Robot : Machine, IMoveable
        {
            public void move()
            {
                Console.WriteLine("robot moving ");
            }
        }

    }
}
