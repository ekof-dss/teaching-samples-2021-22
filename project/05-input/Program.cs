System.Console.WriteLine("Enter an integer");
string obtainedInput = System.Console.ReadLine();
int n = int.Parse(obtainedInput); 
int f = 1;  
int i = n;
while (i>=1)
{
     f = f*i;
     i = i-2;
}   
System.Console.WriteLine("Double factorial is");
System.Console.WriteLine(f);

