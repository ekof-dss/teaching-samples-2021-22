using System;
using System.Collections.Generic;

using project.Models;

namespace project.Data
{
    public class ActorRepository
    {

        public static List<Actor> List(List<Country> countries)
        {
            List<Actor> actors = new List<Actor>();
            actors.Add(new Actor()
            {
                Id = 1,
                FirstName = "Bata",
                LastName = "Zivojinovic",
                DateOfBirth = new DateTime(1933, 6, 5),
                Country = countries[0]
            });
            actors.Add(new Actor()
            {
                Id = 2,
                FirstName = "Julia",
                LastName = "Roberts",
                DateOfBirth = new DateTime(1967, 3, 26),
                Country = countries[1]
            });
            actors.Add(new Actor()
            {
                Id = 3,
                FirstName = "Robert",
                LastName = "De Niro",
                DateOfBirth = new DateTime(1943, 12, 17),
                Country = countries[1]
            });
            actors.Add(new Actor()
            {
                Id = 4,
                FirstName = "Al",
                LastName = "Pacino",
                DateOfBirth = new DateTime(1940, 5, 25),
                Country = countries[1]
            });
            actors.Add(new Actor()
            {
                Id = 5,
                FirstName = "Tom",
                LastName = "Cruise",
                DateOfBirth = new DateTime(1962, 7, 3),
                Country = countries[1]
            });
            actors.Add(new Actor()
            {
                Id = 6,
                FirstName = "Brad",
                LastName = "Pitt",
                DateOfBirth = new DateTime(1963, 12, 18),
                Country = countries[1]
            });
            actors.Add(new Actor()
            {
                Id = 7,
                FirstName = "Leonardo",
                LastName = "DiCaprio",
                DateOfBirth = new DateTime(1974, 11, 11),
                Country = countries[1]
            });
            actors.Add(new Actor()
            {
                Id = 8,
                FirstName = "Tom",
                LastName = "Hanks",
                DateOfBirth = new DateTime(1956, 7, 9),
                Country = countries[1]
            });
            actors.Add(new Actor()
            {
                Id = 9,
                FirstName = "Morgan",
                LastName = "Freeman",
                DateOfBirth = new DateTime(1937, 11, 2),
                Country = countries[1]
            });
            actors.Add(new Actor()
            {
                Id = 10,
                FirstName = "Denzel",
                LastName = "Washington",
                DateOfBirth = new DateTime(1954, 12, 6),
                Country = countries[1]
            });
            actors.Add(new Actor()
            {
                Id = 11,
                FirstName = "Robert",
                LastName = "Downey Jr.",
                DateOfBirth = new DateTime(1965, 4, 4),
                Country = countries[1]
            });
            actors.Add(new Actor()
            {
                Id = 12,
                FirstName = "Chris",
                LastName = "Evans",
                DateOfBirth = new DateTime(1981, 3, 27),
                Country = countries[1]
            });
            actors.Add(new Actor()
            {
                Id = 13,
                FirstName = "Chris",
                LastName = "Hemsworth",
                DateOfBirth = new DateTime(1983, 12, 13),
                Country = countries[1]
            });
            actors.Add(new Actor()
            {
                Id = 14,
                FirstName = "Mark",
                LastName = "Wahlberg",
                DateOfBirth = new DateTime(1971, 6, 6),
                Country = countries[1]
            });
            actors.Add(new Actor()
            {
                Id = 15,
                FirstName = "Samuel",
                LastName = "Jackson",
                DateOfBirth = new DateTime(1948, 12, 16),
                Country = countries[1]
            });
            return actors;
        }

    }
}