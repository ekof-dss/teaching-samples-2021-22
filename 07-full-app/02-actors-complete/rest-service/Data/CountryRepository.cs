using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using project.Models;

namespace project.Data
{
    public class CountryRepository : ICountryRepository
    {

        private readonly MoviesDataContext _context;

        public CountryRepository(MoviesDataContext context)
        {
            _context = context?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<List<Country>> GetAll()
        {
            return await  _context.Countries.ToListAsync();
        }
    }
}