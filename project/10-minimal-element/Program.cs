System.Console.WriteLine("Enter the number of numbers");
int n = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Enter number 1");
int min = int.Parse(System.Console.ReadLine());

for(int i=2; i<=n; i++){
    System.Console.WriteLine("Enter number "+i);
    int x = int.Parse(System.Console.ReadLine());
    if(x<min)
        min = x;
}
System.Console.WriteLine("The minimal number is "+min);
