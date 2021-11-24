int n = 6;
long fakt = 1;

int i = 1;
while (i <= n)
{
    fakt *= i;
    i++;
}
System.Console.WriteLine(n + "! = " + fakt);

n = 8;
fakt = 1;

i = 1;
while (i <= n)
{
    fakt *= i;
    i++;
}
System.Console.WriteLine(n + "! = " + fakt);

n = 11;
fakt = 1;

i = 1;
while (i <= n)
{
    fakt *= i;
    i++;
}
System.Console.WriteLine(n + "! = " + fakt);

System.Console.WriteLine("---");

static long Factorial(int n)
{
    long result = 1;
    int i = 1;
    while (i <= n)
    {
        result *= i;
        i++;
    }
    return result;
}

n = 6;
fakt = Factorial(n);
System.Console.WriteLine(n + "! = " + fakt);
n = 8;
System.Console.WriteLine(n + "! = " + Factorial(n));
System.Console.WriteLine("11! = " + Factorial(11));

