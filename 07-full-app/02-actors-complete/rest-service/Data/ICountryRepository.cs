using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using project.Models;

namespace project.Data
{
    public interface ICountryRepository
    {
        public Task<List<Country>> GetAll();

    }
}