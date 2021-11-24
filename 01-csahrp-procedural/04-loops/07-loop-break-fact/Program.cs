int n = 6;

long fakt = 1;
int i = 1;
while ( true )
{
    if ( i > n )
    {
        break;
    }
    fakt = fakt * i;
    i++;
}
System.Console.WriteLine(n + "! = " + fakt);

fakt = 1;
for (int j = 1; ; j++){
    if (j > n){
        break;
    }
    fakt = fakt * j;
}
System.Console.WriteLine(n + "! = " + fakt);

