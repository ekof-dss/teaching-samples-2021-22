using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using project.Models;

namespace project.Data
{
    public interface ICountryRepository
    {
        public Task<List<Country>> GetAll();

        public Task<Country> GetById(int id);

        public Task<int> Create(Country country);

        public Task<int> Update(Country country);

        public Task<int> Delete(int id);
    }
}