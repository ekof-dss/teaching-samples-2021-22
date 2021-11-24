using System;

namespace DSS.OutParams
{
    class Program
    {
        static void SetAndDoubleValues(out int x, out int y)
        {
            x = 5;
            y = 10;
            x += x;
            y += y;
        }


        static void Main(string[] args)
        {
            // variables are declared, but not initialized
            int a, b;

            SetAndDoubleValues(out a, out b);
            // Display initial values 
            Console.WriteLine("Value of the variable {0} is {1}", nameof(a), a);
            Console.WriteLine("Value of the variable {0} is {1}", nameof(b), b);
            Console.WriteLine();

            SetAndDoubleValues(out int c, out int d);
            Console.WriteLine("Value of the variable {0} is {1}", nameof(c), c);
            Console.WriteLine("Value of the variable {0} is {1}", nameof(d), d);
            Console.WriteLine();
        }

    }
}