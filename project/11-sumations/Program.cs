System.Console.WriteLine("Enter the number of numbers");
int n = int.Parse(System.Console.ReadLine());
int sumEven = 0;
int sumOdd = 0;

for(int i=1; i<=n; i++){
    System.Console.WriteLine("Enter number "+i);
    int x = int.Parse(System.Console.ReadLine());
    if(x % 2 == 0) // number is even
        sumEven=sumEven+x;
    else // if not even it must be odd
        sumOdd=sumOdd+x;
}
System.Console.WriteLine("The sum of even is "+sumEven);
System.Console.WriteLine("The sum of odd is "+sumOdd);
