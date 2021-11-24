
public class Program
{
    static double Power(double @base, int exponent)
    {
        double result = 1;
        for (int i = 1; i <= exponent; i++)
            result *= @base;
        return result;
    }

    static long Factorial(int number)
    {
        long result = 1;
        for (int i = 2; i <= number; i++)
            result *= i;
        return result;
    }
    public static void Main()
    {
        int n = 10;
        System.Console.WriteLine("factorial(" + n + ") = " + Factorial(n));

        double x = 2.5;
        System.Console.WriteLine(x + "^" + n + " = " + Power(x, n));
    }
}




