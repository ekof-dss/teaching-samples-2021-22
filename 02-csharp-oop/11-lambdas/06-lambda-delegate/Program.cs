
using System;

namespace DSS.LambdaDelegate
{
    //declaring a delegate
    public delegate void MyDelegate(string msg);

    class Program
    {
        public static void InvokeDelegate(MyDelegate del, string s) 
        {
            del(s);
        }

        static void Main(string[] args)
        {
            // lambdas as delegates
            MyDelegate del1 = msg => Console.WriteLine("Called lambda expression: " + msg);
            del1("Hello World");
            del1("Mickey Mouse");
            Console.WriteLine();

            MyDelegate del2 = (x) =>
            {
                Console.WriteLine("Called lambda expression:");
                var n = x.Length;
                for (var i = 0; i < n; i++)
                {
                    for (var j = 0; j < i; j++)
                        Console.Write(" ");
                    Console.WriteLine(x[i]);
                }
            };
            del2("Hello World");
            del2("Mickey Mouse");
            Console.WriteLine();

            // delgates as parameters
            InvokeDelegate(del1, "Donald Duck");
            InvokeDelegate(del2, "Donald Duck");
            Console.WriteLine();

            // multicast delegates
            MyDelegate del = del1 + del2; // combines del1 + del2
            del("Mickey Mouse");
           
        }
    }
}

