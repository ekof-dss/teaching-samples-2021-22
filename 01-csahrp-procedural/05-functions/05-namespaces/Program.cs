using System;
using DSS.Helper;

namespace DSS.Central
{
    public class Program
    {
        public static void Main()
        {
            int n = 10;
            Console.WriteLine("factorial(" + n + ") = " + Mathematics.Factorial(n));

            double x = 2.5;
            Console.WriteLine(x + "^" + n + " = " + Mathematics.Power(x, n));
        }
    }
}





