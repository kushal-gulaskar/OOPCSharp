using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;

namespace Collections
{
    class NonGenericCollection
    {
        static void main()
        {
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);
            al.Add(200);
            Console.WriteLine(al.Capacity);
        }
    }
}
