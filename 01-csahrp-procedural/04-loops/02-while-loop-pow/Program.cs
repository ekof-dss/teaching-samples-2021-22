int exponent = 10;
double @base = 2.3;

double result = 1;
int i = 1;
while (i <= exponent)
{
    result *= @base;
    i++; //count up
}
System.Console.WriteLine(@base + "^" + exponent + "=" + result);

result = 1;
int j = exponent;
while (j >= 1)
{
    result *= @base;
    j--; //count down
}
System.Console.WriteLine(@base + "^" + exponent + "=" + result);