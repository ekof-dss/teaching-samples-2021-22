double circumference, area;
double pi = 3.14159265359;
string shape = "square";
double x = 10;

if (shape == "circle")
{
    circumference = 2 * pi * x;
    area = pi * x * x;
}
else if (shape == "square")
{
    circumference = 4 * x;
    area = x * x;
}
else
{
    // we can not calculate area or circumference for this shape
    circumference = -1;
    area = -1;
}
System.Console.WriteLine("Shape: " + shape + ". x: " + x + ".");
System.Console.WriteLine("Area: " + area + ". Circumference: " + circumference + ".");
System.Console.WriteLine();
