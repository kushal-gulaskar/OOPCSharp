using OOP.AbstractClass;
using OOP.ArrayOperation;
using OOP.Constructor;
using OOP.Enum;
using OOP.Interface;
using OOP.OOPproperties;
using OOP.StringRev;
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
            ArrayOp ar = new ArrayOp();
            ar.ArrayMissingEle();
            ar.ArrayReverse();
           
            Console.WriteLine("*************C# string word reverse Element Array***************");
            StringOp str = new StringOp();
            str.StringRev();

            Console.WriteLine("******************C# Default Constructor**********************************");
            ConstructorDefault cn = new ConstructorDefault();
            cn.Display();

            Console.WriteLine("******************C# Copy Constructor**********************************");
            ConstructorCopy pc = new ConstructorCopy(10); pc.Display();
            ConstructorCopy pc1 = new ConstructorCopy(pc); pc1.Display();

            Console.WriteLine("******************C# Static Constructor**********************************");
            ConstructorStatic sc = new ConstructorStatic(); sc.Display();

            Console.WriteLine("******************C# Enum Under Namespace**********************************");
            WeekDays d = WeekDays.Tuesday;
            Console.WriteLine(d);
        }
    }
}
