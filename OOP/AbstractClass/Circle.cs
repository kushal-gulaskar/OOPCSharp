using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.AbstractClass
{
    class Circle : AbstractBaseClass
    {
        public override void draw()
        {
            Console.WriteLine("drawing circle...");
        }
    }
}
