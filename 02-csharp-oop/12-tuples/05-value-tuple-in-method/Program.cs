/*

 A tuple is a data structure that contains a sequence of elements of different data types. It can be used where you want to have 
a data structure to hold an object with properties, but you don't want to create a separate type for it.omplex data structure. 

*/


using System;

namespace RS2.ValueTupleInMethod
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
            var person1 = GetPerson();
            DisplayTuple(person1);
            Console.WriteLine("---");

            DisplayTuple((21, "Dusko", "Dugousko"));
        }

    }
}

