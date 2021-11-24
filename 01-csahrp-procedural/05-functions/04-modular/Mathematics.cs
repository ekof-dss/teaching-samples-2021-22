
public class Mathematics
{
    public static double Power(double @base, int exponent)
    {
        double result = 1;
        for (int i = 1; i <= exponent; i++)
            result *= @base;
        return result;
    }

    public static long Factorial(int number)
    {
        long result = 1;
        for (int i = 2; i <= number; i++)
            result *= i;
        return result;
    }

}




