using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.AbstractClass
{
    class Rectangle : AbstractBaseClass
    {
        public override void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
}
