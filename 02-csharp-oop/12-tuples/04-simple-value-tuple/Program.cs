/*

 A tuple is a data structure that contains a sequence of elements of different data types. It can be used where you want to have 
a data structure to hold an object with properties, but you don't want to create a separate type for it.omplex data structure. 

*/


using System;

namespace RS2.SimpleValueTuple
{
    class Program
    {
        static void Main()
        {
            ValueTuple<int, string, string> person1 = (1, "Mickey", "Mouse");
            Console.WriteLine(person1.Item1); // 1
            Console.WriteLine(person1.Item2); // "Mickey"
            Console.WriteLine(person1.Item3); // "Mouse"
            Console.WriteLine("---");

            var person2 = (1, "Mickey", "Mouse");
            Console.WriteLine(person2.Item1); // 1
            Console.WriteLine(person2.Item2); // "Mickey"
            Console.WriteLine(person2.Item3); // "Mouse"
            Console.WriteLine("---");

            (int, string, string) person3 = (1, "Mickey", "Mouse");
            Console.WriteLine(person3.Item1); // 1
            Console.WriteLine(person3.Item2); // "Mickey"
            Console.WriteLine(person3.Item3); // "Mouse"
            Console.WriteLine("---");

            (int Id, string Ime, string Prezime) person4 = (1, "Mickey", "Mouse");
            Console.WriteLine(person4.Id); // 1
            Console.WriteLine(person4.Ime); // "Mickey"
            Console.WriteLine(person4.Prezime); // "Mouse"
            Console.WriteLine("---");

            var person5 = (Id: 1, Ime: "Mickey", Prezime: "Mouse");
            Console.WriteLine(person5.Id); // 1
            Console.WriteLine(person5.Ime); // "Mickey"
            Console.WriteLine(person5.Prezime); // "Mouse"
            Console.WriteLine("---");

            string firstName = "Mickey", lastName = "Mouse";
            var person6 = (Ime: firstName, Prezime: lastName);
            Console.WriteLine(person6.Ime); // "Mickey"
            Console.WriteLine(person6.Prezime); // "Mouse"
            Console.WriteLine("---");

            var numbers = (1, 2, 3, 4, 5, 6, 7, 8, "9", "10", 11, 12, 13, 14);
            Console.WriteLine(numbers.Item1); // 1
            Console.WriteLine(numbers.Item10); // "10"
            Console.WriteLine("---");
        }

    }
}

