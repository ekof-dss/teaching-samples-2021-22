using System;
using System.Collections.Generic;

namespace Movies.Models
{
    public class Program
    {
        public static void Main()
        {
            List<Country> countries = Country.InitializeList();
            Console.WriteLine("\nCountries:");
            foreach( Country c in countries)
            {
                Console.WriteLine(c);
            }

            List<Actor> actors = Actor.InitializeList(countries);
            Console.WriteLine("\nActors:");
            foreach( Actor a in actors)
            {
                Console.WriteLine(a);
            }
    
        }
    }
}