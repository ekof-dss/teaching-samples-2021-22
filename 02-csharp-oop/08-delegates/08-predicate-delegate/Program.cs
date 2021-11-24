/*
Predicate is the delegate like Func and Action delegates. 
It represents a method containing a set of criteria and checks whether the passed parameter 
meets those criteria. 

A predicate delegate methods must take one input parameter and return a boolean - true or false.

The Predicate delegate is defined in the System namespace, as shown below:

Predicate signature: 
public delegate bool Predicate<in T>(T obj);

*/

using System;

namespace RS2.PredicateDelegate
{
    class Program
    {
        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

        static void Main(string[] args)
        {
            Predicate<string> isUpper = IsUpperCase;
            string text = "hello world!!";
            bool result = isUpper(text);
            if (result)
                Console.WriteLine("Text '{0}' is all in upper cases!", text);
            else
                Console.WriteLine("Text '{0}' is not all in upper cases!", text);
            Console.WriteLine();

            Predicate<string> isLower = delegate (string s)
            {
               return s.Equals(s.ToLower());
            };
            result = isLower(text);
            if (result)
                Console.WriteLine("Text '{0}' is all in lowercases!", text);
            else
                Console.WriteLine("Text '{0}' is not all in lower cases!", text);
            Console.WriteLine();

        }
    }
}



