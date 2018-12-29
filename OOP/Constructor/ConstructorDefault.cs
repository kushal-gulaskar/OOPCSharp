using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Constructor
{
    class ConstructorDefault
    {
        int c;
        int a = 1;
        int b = 3;
        public ConstructorDefault()
        {
            Console.WriteLine("Contructor initialized");
        }

        public void Display()
        {
            c = a + b;
            Console.WriteLine(c);
        }


    }
}
