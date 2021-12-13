using System;
using System.Collections.Generic;

using project.Models;

namespace project.Data
{
    public partial class CountryRepostory
    {
        public static List<Country> List()
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