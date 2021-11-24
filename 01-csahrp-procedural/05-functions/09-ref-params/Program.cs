using System;

namespace DSS.RefParams
{
    class Program
    {

        // Parameters passed by value 
        static void AddValue(int x)
        {
            x += 10;
        }

        // Parameters passed by ref 
        static void Subtractvalue(ref int y)
        {
            y -= 5;
        }

        static void Main(string[] args)
        {

            // Initialize a and b 
            int a = 10, b = 12;

            // Display initial values 
            Console.WriteLine("Value of the variable {0} is {1}", nameof(a), a);
            Console.WriteLine("Value of the variable {0} is {1}", nameof(b), b);
            Console.WriteLine();

            AddValue(a);
            Console.WriteLine("Value of the variable {0} " +
                "after addition is {1}", nameof(a), a);
            Console.WriteLine();

            Subtractvalue(ref b);
            Console.WriteLine("Value of the variable {0} " +
                "after subtraction is {1}", nameof(b), b);
            Console.WriteLine();
        }

    }
}