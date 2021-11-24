/*
Action is a delegate type defined in the System namespace. 
An Action type delegate is the same as Func delegate except 
that the Action delegate doesn't return a value. 
In other words, an Action delegate can be used with a method that has a void return type.

Action signature: 
public delegate void Action<in T>(T obj);

*/

using System;

namespace RS2.ActionDelegate
{
    class Program
    {
        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }

        static void Main(string[] args)
        {
            Action<int> printActionDel = ConsolePrint;
            printActionDel(10);
            Console.WriteLine("---");

            printActionDel = delegate (int i) { Console.WriteLine("++" + i); };
            printActionDel(10);
            Console.WriteLine("---");

        }
    }
}



