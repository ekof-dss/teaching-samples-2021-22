using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using project.Models;
using project.ViewModels;

namespace project.Data
{
    public class ActorRepository : IActorRepository
    {

        private readonly MoviesDataContext _context;

        public ActorRepository(MoviesDataContext context)
        {
            _context = context?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<List<ActorDTO>> GetAll()
        {
            return await _context.Actors
                    .Include(x => x.Country)
                    .Select(x => new ActorDTO()
                    {
                        Id = x.Id,
                        LastName = x.LastName,
                        FirstName = x.FirstName,
                        CountryId = x.Country.Id, 
                        CountryName = x.Country.Name,
                        CountryCode = x.Country.Code,
                        DateOfBirth = x.DateOfBirth
                    }).ToListAsync();      
        }

        public async Task<ActorDTO> GetById(int id)
        {
            return await _context.Actors
                    .Where(x => x.Id == id)
                    .Include(x => x.Country)
                    .Select(x => new ActorDTO()
                    {
                        Id = x.Id,
                        LastName = x.LastName,
                        FirstName = x.FirstName,
                        CountryId = x.Country.Id, 
                        CountryName = x.Country.Name,
                        CountryCode = x.Country.Code,
                        DateOfBirth = x.DateOfBirth
                    })
                    .FirstOrDefaultAsync();
        }

        public async Task<int> Create(ActorDTO actorDTO)
        { 
            Actor newActor = new Actor()
            {
                FirstName = actorDTO.FirstName,
                LastName = actorDTO.LastName,
                CountryId = actorDTO.CountryId,
                DateOfBirth = actorDTO.DateOfBirth
            };
            _context.Actors.Add(newActor);  
            int ret = await _context.SaveChangesAsync();
            return ret;  
        }

        public async Task<int> Update(ActorDTO actorDTO)
        {
            Actor actorToUpdate = await _context.Actors
                .Where(x => x.Id == actorDTO.Id)
                .Include(x => x.Country)
                .FirstOrDefaultAsync();
            actorToUpdate.FirstName = actorDTO.FirstName;
            actorToUpdate.LastName = actorDTO.LastName;
            actorToUpdate.CountryId = actorDTO.CountryId;
            actorToUpdate.DateOfBirth = actorDTO.DateOfBirth;
            _context.Entry(actorToUpdate).State = EntityState.Modified;  
            int ret = await _context.SaveChangesAsync();
            return ret;  
        }

        public async Task<int> Delete(int id)
        {
            Actor actorToDelete = await _context.Actors
                .Where(x => x.Id == id).FirstOrDefaultAsync();
            _context.Actors.Remove(actorToDelete);  
            int ret = await _context.SaveChangesAsync();
            return ret;  
        }

    }
}