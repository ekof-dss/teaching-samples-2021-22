
using System;

namespace RS2.LambdaExpressionInInterface
{

public class Program
{
    public static void Main()
    {
        var person = new Osoba("Paja", "Patak");
        Console.WriteLine(person.Name);

        var item = new Artikal("Cipele", 19.95m);
        Console.WriteLine($"{item.Name} se prodaju po ceni: {item.Price}");
    }
}

}
