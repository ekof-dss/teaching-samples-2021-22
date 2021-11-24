/*

 A tuple is a data structure that contains a sequence of elements of different data types. It can be used where you want to have 
a data structure to hold an object with properties, but you don't want to create a separate type for it.omplex data structure. 

*/


using System;

namespace RS2.TupleInMethod
{
    class Program
    {
        static Tuple<int, string, string> GetPerson()
        {
            return Tuple.Create(10, "Paja", "Patak");
        }

        static void DisplayTuple(Tuple<int, string, string> person)
        {
            Console.WriteLine($"Id = { person.Item1}");
            Console.WriteLine($"First Name = { person.Item2}");
            Console.WriteLine($"Last Name = { person.Item3}");
        }

        static void Main()
        {
            var person1 = GetPerson();
            DisplayTuple(person1);
            Console.WriteLine("---");

            var person2 = Tuple.Create(21, "Dusko", "Dugousko");
            DisplayTuple(person2);
            Console.WriteLine("---");
        }

    }
}

