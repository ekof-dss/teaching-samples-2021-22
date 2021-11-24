int n = 7;

// count down, step 2, while
long dfakt = 1;
int i = n;
while (i >= 1)
{
    dfakt = dfakt * i;
    i -= 2;
}
System.Console.WriteLine(n + "!! = " + dfakt);

// count up, step 2, while
dfakt = 1;
int j;
if (n % 2 == 0)
    j = 2;
else
    j = 1;
while (j <= n)
{
    dfakt = dfakt * j;
    j += 2;
}
System.Console.WriteLine(n + "!! = " + dfakt);

// count down, step 2, for
dfakt = 1;
for (int k = n; k >= 1; k -= 2)
    dfakt = dfakt * k;
System.Console.WriteLine(n + "!! = " + dfakt);

// count down, step 1, while - continue
dfakt = 1;
i = n;
while (i >= 1)
{
    if ((n - i) % 2 != 0)
    {
        i--;
        continue; // different parity should be skipped
    }
    dfakt = dfakt * i;
    i--;
}
System.Console.WriteLine(n + "!! = " + dfakt);

// count up, step 1, while - continue
dfakt = 1;
i = 1;
while (i <= n)
{
    if ((n - i) % 2 != 0){
        i++;
        continue; // different parity should be skipped
    }
    dfakt = dfakt * i;
    i++;
}
System.Console.WriteLine(n + "!! = " + dfakt);

// count down, step 1, for - continue
dfakt = 1;
for ( int k = n; k >= 1; k--)
{
    if ((n - k) % 2 != 0)
        continue; // different parity should be skipped
    dfakt = dfakt * k;
}
System.Console.WriteLine(n + "!! = " + dfakt);
