System.Console.WriteLine("Enter the number of numbers");
int n = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter the number to search");
int s = int.Parse(System.Console.ReadLine());
int numberOfS = 0;

for(int i=1; i<=n; i++){
    System.Console.WriteLine("Enter number "+i);
    int x = int.Parse(System.Console.ReadLine());
    //System.Console.WriteLine("You wrote number "+x);
    if(x==s)
        numberOfS=numberOfS+1;
}
System.Console.WriteLine("The number of "+s+" is "+numberOfS);
