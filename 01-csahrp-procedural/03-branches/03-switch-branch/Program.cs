int i = 3;
double x = 2;
double f;

switch (i)
{
    case 0:
        f = System.Math.Sin(x);
        break;
    case 1:
        f = System.Math.Sin(x) + System.Math.Cos(x);
        break;
    case 2:
        f = System.Math.Exp(x);
        break;
    case 3:
        f = System.Math.Sqrt(x);
        break;
    default: //if i is not in the set {0,1,2,3}
        f = x;
        break;
}

System.Console.WriteLine("Selector: " + i);
System.Console.WriteLine("Argument: " + x);
System.Console.WriteLine("Result: " + f);
System.Console.WriteLine();
