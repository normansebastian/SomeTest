using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeTest
{
    class Class1
    {
        public Class1() { Console.WriteLine("Dont ever add output to console in a constructor" );}
        public string MyName { get; set; }
        public Single Salary { get; set; } 
        public decimal Tax { get; set; }
    }
}
