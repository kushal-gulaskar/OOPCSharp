using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.ArrayOperation
{
    class ArrayOp
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 9 };

        public void ArrayMissingEle()
        {
            //array length
            int n = arr.Length;
            
            //sort array
            Array.Sort(arr);
            Console.WriteLine("sorted array--- ");
            //Sort and print array
            foreach (int i in arr)
            {
               
                Console.Write(i + "");
            }

            //Sum of the array
            int sum = (n + 1) * (n + 2) / 2;

            for (int i = 0; i < n; i++)
            {
                sum = sum - arr[i];
            }
            Console.WriteLine("");
            Console.WriteLine("Missing element is---");
            Console.WriteLine(sum);
        }

        public void ArrayReverse()
        {
            Console.WriteLine("");
            Console.WriteLine("Array "+ arr);
            Console.WriteLine("Reversed array is---");
            Array.Reverse(arr);
            foreach (int i in arr)
            {
                Console.Write(i + "");
            }
        }
    }
}
