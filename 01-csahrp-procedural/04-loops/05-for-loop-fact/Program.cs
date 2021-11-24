int n = 6;

long fakt = 1;
// count up
for (int i = 1; i <= n; i++)
    fakt *= i;
System.Console.WriteLine(n + "! = " + fakt);

fakt = 1;
// count down
for (int j = n; j >= 1; j--)
    fakt *= j;
System.Console.WriteLine(n + "! = " + fakt);
