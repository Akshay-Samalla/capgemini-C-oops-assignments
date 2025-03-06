using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Q10
    {
       

   /*internal class Program
    {
        private static void Main(string[] args)
        {
            SecuritySystem securitysystem = new SecuritySystem();
            securitysystem.AuthenticateUser();
        }
    }
   */
    sealed class SecuritySystem
    {
        public void AuthenticateUser()
        {
            Console.WriteLine("user authenticated");
        }
    }

    //class AdvancedSecurity : SecuritySystem { } //error
}
}
