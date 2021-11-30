System.Console.WriteLine("Enter a number");
int n = int.Parse(System.Console.ReadLine());

int i = n;
while (i >= 1)
{
    System.Console.WriteLine("Number " + i);
    i = i - 1;
}
System.Console.WriteLine("GO");

i = n;
for (; i >= 1; i--)
    System.Console.WriteLine("Number " + i);
System.Console.WriteLine("GO");
