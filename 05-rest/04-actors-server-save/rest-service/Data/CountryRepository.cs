using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using project.Models;

namespace project.Data
{
    public class CountryRepository : ICountryRepository
    {
        private List<Country> _data = new List<Country>();

        public CountryRepository()
        {
            _data.Add(new Country()
            {
                Id = 1,
                Name = "Serbia",
                Code = "RS"
            });
            _data.Add(new Country()
            {
                Id = 2,
                Name = "United States of America",
                Code = "US"
            });
            _data.Add(new Country()
            {

                Id = 3,
                Name = "People's Republic of China",
                Code = "PRC"
            });
            _data.Add(new Country()
            {

                Id = 4,
                Name = "Republic of Italy",
                Code = "IT"
            });
        }

        public async Task<List<Country>> GetAll()
        {
            return await Task.FromResult(_data);
        }
    }
}