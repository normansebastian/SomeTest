using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string line = Console.ReadLine();
            Console.WriteLine("Your name is {0}", line);
            Console.ReadKey();
        }
    }
}
