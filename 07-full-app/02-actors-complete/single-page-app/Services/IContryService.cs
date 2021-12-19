using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using project.Models;

namespace project.Services
{
    public interface ICountryService
    {
        Task<List<Country>> GetCountries();

        Task<int> Add(string countyCode, string counntryName);

        Task<int> Delete(Country actor);

        Task<int> Update(Country actor);
    }
}
