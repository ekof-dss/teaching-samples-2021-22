int n = 6;
long fakt = 1;

int i = 1;
while (i <= n)
{
    fakt *= i;
    i++;
}
System.Console.WriteLine(n + "! = " + fakt);