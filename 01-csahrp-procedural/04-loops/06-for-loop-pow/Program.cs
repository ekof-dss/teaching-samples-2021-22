int exponent = 10;
double @base = 2;

double result = 1;
// count up
for (int i = 1; i <= exponent; i++)
    result *= @base;
System.Console.WriteLine(@base + "^" + exponent + "=" + result);

result = 1;
//count down
for (int j = exponent; j >= 1; j--)
    result *= @base;
System.Console.WriteLine(@base + "^" + exponent + "=" + result);
