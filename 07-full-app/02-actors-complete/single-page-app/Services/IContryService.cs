using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using project.Models;

namespace project.Services
{
    public interface ICountryService
    {
        Task<List<Country>> GetCountries(bool reload = false);
    }
}
