using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class StringOperation
    {
        [Test]
        public void StringReverse()
        {
            string str = "", reverse = "";
            int length = 0;
            Console.WriteLine("Enter a Word");
            str = "Kushal Gulaskar";
            length = str.Length - 1;

            while (length >= 0)
            {
                reverse = reverse + str[length];
                length--;
            }
            Console.WriteLine("Reverse word is {0}", reverse);
            Console.ReadLine();
        }
    }
    }
