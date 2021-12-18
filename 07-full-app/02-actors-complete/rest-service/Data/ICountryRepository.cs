using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using project.Models;
using project.ViewModels;

namespace project.Data
{
    public interface ICountryRepository
    {
        public Task<List<CountryDTO>> GetAll();

        public Task<CountryDTO> GetById(int id);

        public Task<int> Create(CountryDTO country);

        public Task<int> Update(CountryDTO country);

        public Task<int> Delete(int id);
    }
}