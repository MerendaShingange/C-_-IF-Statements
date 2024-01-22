using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C___IF_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // the test can be either true or false
            bool isMale = true;
            if (isMale )
            {
                Console.WriteLine("You are male ");

            }
            else
            {
                Console.WriteLine("You are female");
                
                
            }
            bool isTall = false;
            if (isTall&& isMale  ) {
            Console.WriteLine("You are not tall but you are male");

            }
            else if(isTall&& isMale)
            {
                Console.WriteLine("You are not tall but you are male");

            }
            else { Console.WriteLine("You are either tall, not tall or not a mele");
            }
        }
    }
}
