/*

 A tuple is a data structure that contains a sequence of elements of different data types. It can be used where you want to have 
a data structure to hold an object with properties, but you don't want to create a separate type for it.omplex data structure. 

*/


using System;

namespace RS2.NestedTuple
{
    class Program
    {
        static void Main()
        {
            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
            Console.WriteLine(numbers.Item1); // 1
            Console.WriteLine(numbers.Item7); // 7
            Console.WriteLine(numbers.Rest.Item1); //(8, 9, 10, 11, 12, 13)
            Console.WriteLine(numbers.Rest.Item1.Item1); //8
            Console.WriteLine(numbers.Rest.Item1.Item2); //9
            Console.WriteLine("---");

            var numbers2 = Tuple.Create(1, 2, Tuple.Create(3, 4, 5, 6, 7, 8), 9, 10, 11, 12, 13);
            Console.WriteLine(numbers2.Item1); // 1
            Console.WriteLine(numbers2.Item2); // 2
            Console.WriteLine(numbers2.Item3); // (3, 4, 5, 6, 7,  8)
            Console.WriteLine(numbers2.Item3.Item1); // 3
            Console.WriteLine(numbers2.Item4); // 9
            Console.WriteLine(numbers2.Rest.Item1); //13
        }

    }
}

