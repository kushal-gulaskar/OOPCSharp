using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.AbstractClass
{
    abstract class AbstractBaseClass
    {
        public abstract void draw();

        public void Pprintline()
        {
            Console.WriteLine("Text from Abstract Base class");
        }
    }
}
