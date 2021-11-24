int exponent = 10;
double @base = 2;

double result = 1;
for (int i = 1; i <= exponent; i++)
    result *= @base;
System.Console.WriteLine(@base + "^" + exponent + "=" + result);

exponent = 5;
@base = 3;
result = 1;
for (int i = 1; i <= exponent; i++)
    result *= @base;
System.Console.WriteLine(@base + "^" + exponent + "=" + result);

System.Console.WriteLine("---");

static double Power(double @base, int exponent)
{
    double result = 1;
    for (int i = 1; i <= exponent; i++)
        result *= @base;
    return result;
}

System.Console.WriteLine("2^10 = " + Power(2, 10));
System.Console.WriteLine("3^5 = " + Power(3, 5));
