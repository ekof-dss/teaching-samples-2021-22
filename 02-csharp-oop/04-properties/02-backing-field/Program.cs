
using System;

namespace DSS.PropertyBackingField
{
    class Program
    {
        static void Main()
        {
            FictionCharacter character = new FictionCharacter(firstname:"Donald", "Duck");
            Console.WriteLine("character - first name: {0}", character.FirstName);
            Console.WriteLine("character - last name: {0}", character.LastName);
            Console.WriteLine("character - full name: {0}", character.FullName);
            Console.WriteLine();

            character.FirstName = "Ronald";
            Console.WriteLine("character - first name: {0}", character.FirstName);
            Console.WriteLine("character - last name: {0}", character.LastName);
            Console.WriteLine("character - full name: {0}", character.FullName);
            Console.WriteLine();

            character.FullName = "Felipe Caetano Lopes Martines Gonsales";
            Console.WriteLine("character - first name: {0}", character.FirstName);
            Console.WriteLine("character - last name: {0}", character.LastName);
            Console.WriteLine("character - full name: {0}", character.FullName);
            Console.WriteLine();

            character.FullName = "Supermen";
            Console.WriteLine("character - first name: {0}", character.FirstName);
            Console.WriteLine("character - last name: {0}", character.LastName);
            Console.WriteLine("character - full name: {0}", character.FullName);
            Console.WriteLine();
        }
    }

}


