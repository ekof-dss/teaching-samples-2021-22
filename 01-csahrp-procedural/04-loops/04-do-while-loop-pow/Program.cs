int exponent = 10;
double @base = 2;

double result = 1;
int i = 1;
do
{
    result *= @base;
    i++; // count up
}while (i <= exponent);
System.Console.WriteLine(@base + "^" + exponent + "=" + result);

result = 1;
int j = exponent;
do
{
    result *= @base;
    j--; //count down
} while (j >= 1);
System.Console.WriteLine(@base + "^" + exponent + "=" + result);