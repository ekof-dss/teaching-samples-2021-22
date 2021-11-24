
using System;

namespace DSS.LambdaExpressionInInterface
{

public class Program
{
    public static void Main()
    {
        var person = new Osoba("Donald", "Duck");
        Console.WriteLine(person.Name);

        var item = new Artikal("Cipele", 19.95m);
        Console.WriteLine($"{item.Name} se prodaju po ceni: {item.Price}");
    }
}

}
