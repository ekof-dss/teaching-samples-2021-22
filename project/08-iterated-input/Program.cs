System.Console.WriteLine("Enter the number of numbers");
int n = int.Parse(System.Console.ReadLine());
int numberOfFives = 0;

for(int i=1; i<=n; i++){
    System.Console.WriteLine("Enter number "+i);
    int x = int.Parse(System.Console.ReadLine());
    //System.Console.WriteLine("You wrote number "+x);
    if(x==5)
        numberOfFives=numberOfFives+1;
}
System.Console.WriteLine("The number of fives is "+numberOfFives);
