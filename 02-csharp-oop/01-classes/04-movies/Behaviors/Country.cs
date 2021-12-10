using System;
using System.Collections.Generic;

namespace Movies.Models
{
    public partial class Country
    {
        public Country()
        {
            this.Actors = new HashSet<Actor>();
            this.Directors = new HashSet<Director>();
            this.Movies = new HashSet<Movie>();
        }

        public override string ToString()
        {
            return this.Code + "-" + this.Name + " (" + this.Id + ")";
        }

        public static List<Country> InitializeList()
        {
            List<Country> countries = new List<Country>();
            countries.Add(new Country() { Id = 1, Code = "SR", Name = "Serbia" });
            countries.Add(new Country() { Id = 2, Code = "US", Name = "United States of America" });
            countries.Add(new Country() { Id = 3, Code = "PRC", Name = "People Republic China" });
            countries.Add(new Country() { Id = 4, Code = "UK", Name = "United Kingdom" });
            countries.Add(new Country() { Id = 5, Code = "FR", Name = "France" });
            countries.Add(new Country() { Id = 6, Code = "D", Name = "Germany" });
            countries.Add(new Country() { Id = 7, Code = "IT", Name = "Italy" });
            return countries;
        }

    }
}