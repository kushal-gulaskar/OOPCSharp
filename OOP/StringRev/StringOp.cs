using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.StringRev
{
    class StringOp
    {
        string str = "", reverse = "";
        int length = 0;

        public void StringRev()
        {
            Console.WriteLine("Enter a Word");
            str = Console.ReadLine();
            length = str.Length - 1;

            while (length >= 0)
            {
                reverse = reverse + str[length];
                length--;
            }
            Console.WriteLine("Reverse word is {0}", reverse);
        }
      
    }
}
