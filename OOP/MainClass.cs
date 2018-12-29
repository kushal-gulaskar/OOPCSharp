using OOP.AbstractClass;
using OOP.Interface;
using OOP.OOPproperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Properties
    {
        public static void Main(string[] args)
        {
            // Create a new Student object:
            StudentProperties s = new StudentProperties();

            // Setting code, name and the age of the student
            s.Code = "001";
            s.Name = "Zara";
            s.Age = 9;//
            Console.WriteLine("*************C# Properties***************");
            Console.WriteLine("Student Info: {0}", s);
            //
            //let us increase age
            s.Age += 1;
            Console.WriteLine("Student Info: {0}", s);

            KushalProperty k = new KushalProperty();
            k.Name = "SetKushal";
            string GetKushal = k.Name;
            Console.WriteLine("Set Kushal Prop: {0}", k.Name);
            Console.WriteLine("Get Kushal Prop: {0}", GetKushal);


            Console.WriteLine("*************C# Abstract Class***************");

            AbstractBaseClass sh;
            sh = new Rectangle();
            sh.draw();
            sh = new Circle();
            sh.draw();
            sh.Pprintline();

            Console.WriteLine("*************C# Interface***************");

            SubClass inter = new SubClass();

            inter.SetTutorial(1, "Interface example");
            Console.WriteLine(inter.GetTutorial());

            Console.WriteLine("*************C# Missing Element Array***************");

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 9 };
            //array length
            int n = arr.Length;

            //sort reverse array
            Array.Reverse(arr);

            //sort array
            Array.Sort(arr);

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

            Console.WriteLine("*************C# string word reverse Element Array***************");

            string str = "", reverse = "";
            int length = 0;
            Console.WriteLine("Enter a Word");
            str = Console.ReadLine();
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
