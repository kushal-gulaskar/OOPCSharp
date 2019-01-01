using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Constructor
{
    class ConstructorCopy
    {
        int x;
        public ConstructorCopy(int i)
        {
            x = i;
        }
        public ConstructorCopy(ConstructorCopy Obj)
        {
            x = Obj.x;
        }
        public void Display()
        {
            Console.WriteLine("value of X is" +x);
        }
     
    }
}
