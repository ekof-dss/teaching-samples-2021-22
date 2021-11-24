int n = 6;

long fakt = 1;
int i = 1;
do
{
    fakt *= i;
    i++; // count up
} while (i <= n);
System.Console.WriteLine(n + "! = " + fakt);

fakt = 1;
int j = n;
do
{
    fakt *= j;
    j--; // count down
} while (j > 0);
System.Console.WriteLine(n + "! = " + fakt);