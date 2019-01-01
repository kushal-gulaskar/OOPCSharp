using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    class NonGenericCollections
    {
            static void Main()
            {
            Console.WriteLine("***************************ArrayList**************************");
            //Auto resizing of Array
            ArrayList al = new ArrayList();
            //Capacity will show 0
            Console.WriteLine(al.Capacity);
            al.Add(200);
            al.Add(300.22);
            al.Add('k');
            al.Add("StringSample");
            al.Add(true);
            //Capacity will show 4 as it will Reserve 4 bytes
            Console.WriteLine(al.Capacity);

            foreach(Object ob in al)
                Console.WriteLine(ob + "");

            al.Insert(5,10);

            foreach (Object ob in al)
                Console.WriteLine(ob + "");


            Console.WriteLine("***************************HashTable**************************");
            //HashTable
            Hashtable hc = new Hashtable();

            hc.Add("Kushal", 200);
            hc.Add("Shashiant", 300);
            hc.Add("Gulaskar", 400);
            Console.WriteLine(hc["Shashiant"]);

            foreach (object key in hc.Keys)
            Console.WriteLine(key);

            Console.WriteLine("***************************GenericList**************************");

            List<int> li = new List<int>();

            li.Add(200);
            li.Add(300);
            li.Add(400);

            li.Insert(2,250);
            li.RemoveAt(2);
            foreach (object ele in li)
                Console.WriteLine(ele);


            List<string> lis = new List<string>();

            lis.Add("kush1");
            lis.Add("kush2");
            lis.Add("kush3");

            lis.Insert(2, "Pippu");
            lis.RemoveAt(2);
            foreach (object ele in lis)
                Console.WriteLine(ele);
            Console.ReadLine();
        }
    }
}
