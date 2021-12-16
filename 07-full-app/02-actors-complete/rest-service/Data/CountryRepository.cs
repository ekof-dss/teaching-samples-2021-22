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

        public async Task<Country> GetById(int id)
        {
            return await _context.Countries.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<int> Create(Country country)
        {
            _context.Countries.Add(country);  
            int ret = await _context.SaveChangesAsync();
            return ret;  
        }

        public async Task<int> Update(Country country)
        {
            Country countryToUpdate = await _context.Countries
                .Where(x => x.Id == country.Id).FirstOrDefaultAsync();
            countryToUpdate.Code = country.Code;
            countryToUpdate.Name = country.Name;
            _context.Entry(countryToUpdate).State = EntityState.Modified;  
            int ret = await _context.SaveChangesAsync();
            return ret;  
        }
        public async Task<int> Delete(int id)
        {
            Country countryToDelete = await _context.Countries
                .Where(x => x.Id == id).FirstOrDefaultAsync();
            _context.Countries.Remove(countryToDelete);  
            int ret = await _context.SaveChangesAsync();
            return ret;  
        }

    }
}