/*

 A tuple is a data structure that contains a sequence of elements of different data types. It can be used where you want to have 
a data structure to hold an object with properties, but you don't want to create a separate type for it.omplex data structure. 

*/


using System;

namespace RS2.TupleDeconstruction
{
    class Program
    {
        static (int, string, string) GetPerson()
        {
            return (Id: 10, Ime: "Paja", Prezime: "Patak");
        }

        static void DisplayTuple((int, string, string) person)
        {
            Console.WriteLine($"Id = { person.Item1}");
            Console.WriteLine($"Ime = { person.Item2}");
            Console.WriteLine($"Prezime = { person.Item3}");
        }

        static void Main()
        {
            (int pId, string fName, string lName) = GetPerson();
            Console.WriteLine(pId);
            Console.WriteLine(fName);
            Console.WriteLine(lName);
            Console.WriteLine("---");

            (var personId, var firstName, var lastName) = GetPerson();
            Console.WriteLine(personId);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine("---");

            (_, _, var prezime) = GetPerson();
            Console.WriteLine(prezime);
            Console.WriteLine("---");
        }

    }
}

