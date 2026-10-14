////1. Reverse Each word from given string
//using System.Collections.Generic;
//using System.Diagnostics.Metrics;
//internal class ReverseEachWordFromStringNew
//{
//    public static void Main(string[] args)
//    {
//        string originalString = "This Is Kushal";
//        string[] Splitstring = originalString.Split(' ');
//        string reverseWordString = string.Join(" ", Splitstring
//        .Select(x => new String(x.Reverse().ToArray())));
//        Console.WriteLine(reverseWordString);
//    }
//}
////OP - sihT sI lahsuK

////2. Capitalize first char of Each word from given string
//internal class CapitalizeFirstCharOfWord
//{
//    static void Main(string[] args)
//    {
//        string testString = "this is kushal";
//        // Split the string into words.
//        string[] words = testString.Split(' ');
//        foreach (string word in words)
//        {
//            char firstChar = char.ToUpper(word[0]);//e.g. "T"
//            string wordNew = firstChar + word.Substring(1);// e.g."T" + "his"
//            Console.Write(wordNew);
//            Console.Write(" ");
//        }
//    }
//}
////OP - This Is Kushal

//3. Capitalize last char of Each word from given string
//public class CapitalizeLastCharOfWord
//{
//    public static void Main(string[] args)
//    {
//        string str = "This is a string";
//        string[] words = str.Split(' ');
//        foreach (string word in words)
//        {
//            char lastChar = char.ToUpper(word[word.Length - 1]); //S
//            string wordNew = word.Substring(0, word.Length - 1)+lastChar; // Thi + S
//            Console.Write(wordNew);
//            Console.Write(" ");
//        }
//    }
//}
//OP - ThiS iS A strinG

//4. Capitalize first char of Each word from given string
//internal class CapitalizeFirstCharOfWord
//{
//    static void Main(string[] args)
//    {
//        string testString = "this is kushal";
//        // Split the string into words.
//        string[] words = testString.Split(' ');
//        foreach (string word in words)
//        {
//            char firstChar = char.ToUpper(word[0]);//e.g. "T"
//            string wordNew = firstChar + word.Substring(1);// e.g."T" + "his"
//            Console.Write(wordNew);
//            Console.Write(" ");
//        }
//    }
//}
//OP - This Is Kushal

////LINQ Version
//internal class CapitalizeFirstCharOfWord
//{
//    static void Main(string[] args)
//    {
//        string testString = "this is kushal";
//        string[] words = testString.Split(' ');
//        string result = string.Join(" ", words.Select(word => char.ToUpper(word[0]) + word.Substring(1)));

//        Console.WriteLine(result);
//    }
//}
////OP - This Is Kushal

////5. Store Odd and Even numbers in seprate array
//internal class StoreOddEvenNumbes
//{ 
//    static void Main(string[] args)
//    {
//        int[] even = new int[100];
//        int[] odd = new int[100];

//        for(int i=1;i<100;i++)
//        {
//            if (i % 2 == 0)
//            {
//                even[i] = i;
//            }
//            else
//            {
//                odd[i] = i;
//            }
//        }
//        Console.WriteLine("Even Nos are:....");
//            foreach(var evenn in even)
//        {
//            Console.WriteLine(evenn);
//        }
//        Console.WriteLine("Odd Nos are:....");
//            foreach (var odds in odd)
//        {
//            Console.WriteLine(odds);
//        }

//    }
//}
////OP - Even Nos are:.... Odd Nos are:....

////LINQ Version
//internal class StoreOddEvenNumbes
//{
//    public static void Main(string[] args)
//    {
//        List<int> nums = new List<int> {1,2,3,4,5,6,7,8,9};

//        var evennos = nums.Where(evenn => evenn % 2 == 0);
//        var oddnos = nums.Where(oddn => oddn % 2 != 0);

//        Console.WriteLine("Even Nos are:....");
//        foreach(var e in evennos)
//        { Console.WriteLine(e);
//        }
//        Console.WriteLine("Odd Nos are:....");
//        foreach (var o in oddnos)
//        {
//            Console.WriteLine(o);
//        }
//    }
//}
//////OP - Even Nos are:.... Odd Nos are:....

////6. Remove Duplicates values from Array
//class RemoveDuplicatesFromArray
//{
//    static void Main()
//    {
//        int[] Nos = {1,1,2,3,4,5,5,6,7};
//        int[] uniq = new int[Nos.Length];

//        int count=0;

//        foreach(int n in Nos)
//        {
//            bool isDup = false;
//            for (int i=0;i<count;i++)
//            {
//                if (n == uniq[i])
//                {

//                    isDup = true;
//                    break;
//                }
//            }
//            if(isDup==false)
//            {
//                uniq[count] = n;
//                count++;
//            }
//        }
//        foreach(var unik in uniq)
//        {
//            Console.WriteLine(unik);
//        }
//    }
//}
////OP - 1234567

////6. Remove Duplicates values from Array - LINQ Version
//using System.Linq;
//class RemoveDuplicatesFromArray
//{
//    static void Main()
//    {
//        int[] Nos = { 1, 1, 2, 3, 4, 5, 5, 6, 7 };

//        int[] uniq = Nos.Distinct().ToArray();

//        foreach (int n in uniq)
//        {
//            Console.WriteLine(n);
//        }
//    }
//}
////OP - 1234567

////7.Factorial
//class Factorial
//{
//    static void Main()
//    {
//        int num = 5;
//        int fact = 1;
//        for(int i=1;i<=num;i++)
//        {
//            fact = fact * i;
//            Console.WriteLine(fact);
//        }
//    }
//}
////OP - 1,2,6,24,120

////8.Reverse Given String
//class ReverseGivenString
//{
//    static void Main()
//    {
//        string input = "kushal";
//        string Reversed = "";

//        for (int i = input.Length-1; i >= 0; i--)
//        {
//            Reversed = Reversed+ input[i];
//        }
//        Console.WriteLine(Reversed);
//    }
//}
////OP - lahsuk

////9.Reverse Given Numbers
//class ReverseNumbers
//{
//    static void Main()
//    {
//        int num = 12345;
//        int reversed = 0;

//        while (num > 0)
//        {
//            int digit = num % 10;
//            reversed = reversed * 10 + digit;
//            num = num / 10;
//        }

//        Console.WriteLine(reversed);
//    }
//}
////OP - 54321

////9.Reverse Given Numbers LINQ
//class ReverseNumberLinq
//{
//    static void Main()
//    {
//        int num = 12345;
//        int reversed = int.Parse(
//            new string(num.ToString().Reverse().ToArray()));
//        Console.WriteLine(reversed);
//    }
//}
////OP - 54321

////9.Print Pyramid
//class Pyramid
//{
//    static void Main()
//    {
//        int row = 5;
//        for(int i=1;i<=row;i++)
//        {
//            for(int j=1;j<=i;j++)
//            {
//                Console.WriteLine("*");
//            }
//            Console.WriteLine();
//        }
//    }
//}
////OP -
////*
////**
////***
////****
////*****

////10.Print Pyramid triangle
//class PyramidTriangle
//{
//    static void Main()
//    {
//        int row = 5;
//        for (int i = 1; i <= row; i++)
//        {
//            for(int j=1;j<=row-1; j++)
//            {
//                Console.WriteLine(" ");
//            }
//            for (int k = 1; k <= 2*i-1; k++)
//            {
//                Console.WriteLine("*");
//            }
//            Console.WriteLine();
//        }
//    }
//}
////OP -
////    *
////   ***
////  *****
//// *******
////*********

////11.Pyramid pattern Name
//class PyramidOfName
//{
//    static void Main()
//    {
//        string input="abc";
//        string PyramidName = "";

//        for (int i = 0; i <= input.Length-1; i++)
//        {
//            PyramidName = PyramidName + input[i];
//            Console.WriteLine(PyramidName);
//        }
//    }
//}
////OP -
////a
////ab
////abc

//12.Find no of occurrences of Caracter in this string
//class Program
//{
//    static void Main()
//    {
//        string Name = "new name".ToLower();

//        for (int i = 0; i < Name.Length; i++)
//        {
//            char ch = Name[i];

//            if (ch == ' ')
//                continue;

//            int count = 0;

//            foreach (char c in Name)
//            {
//                if (ch == c)
//                {
//                    count++;
//                }
//            }
//            Console.WriteLine(ch + " = " + count);
//        }
//    }
//}
//OP -
//n = 2
//e = 2
//w = 1
//n = 2
//a = 1
//m = 1
//e = 2


//13. Find first unique number from given array else return "All integers are duplicate"
//Scenario 1:
//{ 1, 1, 1, 1 }
//→ All numbers are duplicate
//→ "All integers are duplicate"

//Scenario 2:
//{ 7, 8, 9, 10 }
//→ Every number is unique
//→ Return first number = 7

//Scenario 3:
//{ 5, 6, 5, 7, 6 }
//→ Only one unique number
//→ Return 7

//Scenario 4:
//{ 5, 6, 5, 9, 6, 8 }
//→ More than one unique number: 9 and 8
//→ Return first unique number = 9
//using System;
//class Program
//{
//    static void Main()
//    {
//        int[] array1 = { 1, 1, 1, 1 }; //op - All integers are duplicate
//        int[] array2 = { 7, 8, 9, 10 }; //op - 7
//        int[] array3 = { 5, 6, 5, 7, 6 ,8}; //op - 7
//        int[] array4 = { 5, 6, 5, 9, 6, 8 }; //op - 9

//        string result1 = FindUnique(array1);
//        string result2 = FindUnique(array2);
//        string result3 = FindUnique(array3);
//        string result4 = FindUnique(array4);

//        Console.WriteLine(result1);
//        Console.WriteLine(result2);
//        Console.WriteLine(result3);
//        Console.WriteLine(result4);
//    }

//    static string FindUnique(int[] numbers)
//    {
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            int count = 0;

//            for (int j = 0; j < numbers.Length; j++)
//            {
//                if (numbers[i] == numbers[j])
//                {
//                    count++;
//                }
//            }

//            if (count == 1)
//            {
//                //Console.WriteLine(numbers[i]);
//                //toPrint ALL Uniq Nums use "Console.WriteLine(numbers[i]);"
//                return numbers[i].ToString();
//            }
//        }
//        return "All integers are duplicate";
//    }
//}


//14. Find the longest substring without repeating characters
using System;
class Program
{
    static void Main()
    {
        string text = "abcabcbbxyzu";
        string longest = "";
        for (int i = 0; i < text.Length; i++) // Start from each character in the string
        {
            string current = "";
            for (int j = i; j < text.Length; j++) // Start from the current character and go to the end of the string
            {
                if (current.Contains(text[j])) //Duplicate found?
                {
                    break;                   // Break the inner loop if duplicate found
                }
                current = current + text[j]; // Append the current character to the current substring
                if (current.Length > longest.Length) 
                {
                    longest = current;
                }
            }
        }
        Console.WriteLine(longest);
    }
}
//OP - bxyzu