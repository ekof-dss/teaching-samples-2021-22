/*

 A tuple is a data structure that contains a sequence of elements of different data types. 

It can be used where you want to have a data structure to hold an object with properties, 
but you don't want to create a separate type for it.omplex data structure. 

*/


using System;

namespace RS2.SimpleTuple
{
    class Program
    {
        static void Main()
        {
            var person = Tuple.Create(1, "Miki", "Maus");
            Console.WriteLine(person.Item1); // 1
            Console.WriteLine(person.Item2); // "Miki"
            Console.WriteLine(person.Item3); // "Maus"


            var numbers = Tuple.Create("One", 2, 3, "Four", 5, "Six", 7, 8);
            Console.WriteLine(numbers.Item1); // "One"
            Console.WriteLine(numbers.Item2); // 2
            Console.WriteLine(numbers.Item3); // 3
            Console.WriteLine(numbers.Item4); // "Four"
            Console.WriteLine(numbers.Item5); // 5
            Console.WriteLine(numbers.Item6); // "Six"
            Console.WriteLine(numbers.Item7); // 7
            Console.WriteLine(numbers.Rest); // (8)
            Console.WriteLine(numbers.Rest.Item1); // 8  
        }

    }
}

