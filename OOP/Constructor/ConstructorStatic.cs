using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Constructor
{
    class ConstructorStatic
    {
        static int c;
        static int a = 1;
        static int b = 3;
        static ConstructorStatic()
        {
            Console.WriteLine("Static Contructor initialized");
        }

        public void Display()
        {
            c = a + b;
            Console.WriteLine(c);
        }
    }
}
