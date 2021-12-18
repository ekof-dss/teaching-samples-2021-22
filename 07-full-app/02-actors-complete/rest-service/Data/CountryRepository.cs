using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using project.Models;
using project.ViewModels;

namespace project.Data
{
    public class CountryRepository : ICountryRepository
    {

        private readonly MoviesDataContext _context;

        public CountryRepository(MoviesDataContext context)
        {
            _context = context?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<List<CountryDTO>> GetAll()
        {
            return await _context.Countries
                    .Select(x => new CountryDTO()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Code = x.Code
                    }).ToListAsync();
        }

        public async Task<CountryDTO> GetById(int id)
        {
            return await _context.Countries
                .Where(x => x.Id == id)
                .Select(x => new CountryDTO()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Code = x.Code
                })
                .FirstOrDefaultAsync();
        }

        public async Task<int> Create(CountryDTO countryDTO)
        {
            Country newCountry = new Country()
            {
                Name = countryDTO.Name,
                Code = countryDTO.Code
            };
            _context.Countries.Add(newCountry);  
            int ret = await _context.SaveChangesAsync();
            return ret;  
        }

        public async Task<int> Update(CountryDTO country)
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