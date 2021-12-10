using System;
using System.Collections.Generic;

namespace Movies.Models
{
    public partial class Actor
    {
        public Actor()
        {
            this.MovieActors = new HashSet<MovieActor>();
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " - " + this.Country?.Code
                + " " + this.DateOfBith + " (" + this.Id + ")";
        }

        public static List<Actor> InitializeList(List<Country> countries)
        {
            List<Actor> actors = new List<Actor>();
            actors.Add(new Actor()
            {
                Id = 1,
                FirstName = "Bata",
                LastName = "Zivojinovic",
                DateOfBith = new DateTime(1933, 6, 5),
                Country = countries[0]
            });
            actors.Add(new Actor()
            {
                Id = 2,
                FirstName = "Julia",
                LastName = "Roberts",
                DateOfBith = new DateTime(1967, 3, 26),
                Country = countries[1]
            });
            actors.Add(new Actor()
            {
                Id = 3,
                FirstName = "Robert",
                LastName = "De Niro",
                DateOfBith = new DateTime(1943, 12, 17),
                Country = countries[1]
            });
            actors.Add(new Actor()
            {
                Id = 4,
                FirstName = "Al",
                LastName = "Pacino",
                DateOfBith = new DateTime(1940, 5, 25),
                Country = countries[1]
            });
            actors.Add(new Actor()
            {
                Id = 5,
                FirstName = "Tom",
                LastName = "Cruise",
                DateOfBith = new DateTime(1962, 7, 3),
                Country = countries[1]
            });
            return actors;
        }

    }
}