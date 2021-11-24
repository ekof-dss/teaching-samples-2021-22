/*
Func is a generic delegate included in the System namespace. 
It has zero or more input parameters and one out parameter. 
The last parameter is considered as an out parameter.

The Func delegate that takes one input parameter and one out parameter is defined 
in the System namespace, as shown below:
namespace System
{
    public delegate TResult Func<in T, out TResult>(T arg);
} 
*/

using System;

namespace RS2.FuncDelegate
{
    class Program
    {
        static long Sum2(int x, int y)
        {
            return x + y;
        }

        static int Sum3(double x, double y, double z)
        {
            return (int)(x + y + z);
        }

        static void Main(string[] args)
        {
            Func<int, int, long> add2 = Sum2;
            long result = add2(10, 10);
            Console.WriteLine(result);
            Console.WriteLine("---");

            Func<double, double, double, int> add3 = Sum3;
            result = add3(10.5, 10, 10.48);
            Console.WriteLine(result);
            Console.WriteLine("---");
        }
    }

}

