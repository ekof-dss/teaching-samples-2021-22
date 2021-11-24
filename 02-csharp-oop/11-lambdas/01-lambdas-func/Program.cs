
using System;

public class Program
{
    static double SquareF(double x)
    {
        return x * x;
    }

    static double ProductF(double x, double y)
    {
        return x * x + x;
    }

    public static void Main()
    {
        double x = 2.5;
        System.Console.WriteLine("squareF(" + x + ") =" + SquareF(x));
        Func<double, double> squareL = x => x * x;
        System.Console.WriteLine("squareL(" + x + ") =" + squareL(x));

        double y = 3.5;
        System.Console.WriteLine("productF(" + x + "," + y + ") =" + ProductF(x, y));
        Func<double, double, double> productL = (x, y) => x * y;
        System.Console.WriteLine("productF(" + x + "," + y + ") =" + productL(x, y));

    }
}




