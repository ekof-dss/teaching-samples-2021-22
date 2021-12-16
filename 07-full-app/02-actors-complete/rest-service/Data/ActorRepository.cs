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

        public async Task<List<Actor>> GetAll()
        {
            return await _context.Actors.Include(x => x.Country).ToListAsync();
        }

        public async Task<Actor> GetById(int id)
        {
            return await _context.Actors.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<int> Create(ActorCreateDTO actor)
        {
            Actor newActor = new Actor()
            {
                FirstName = actor.FirstName,
                LastName = actor.LastName,
                DateOfBirth = actor.DateOfBirth,
                Country = new Country()
                {
                    Id = actor.CountryId,
                    Name = actor.CountryName,
                    Code = actor.CountryCode
                }
            };
            _context.Actors.Add(newActor);  
            int ret = await _context.SaveChangesAsync();
            return ret;  
        }

        public async Task<int> Update(ActorUpdateDTO actorDTO)
        {
            Actor actorToUpdate = await _context.Actors
                .Where(x => x.Id == actorDTO.Id).FirstOrDefaultAsync();
            actorToUpdate.FirstName = actorDTO.FirstName;
            actorToUpdate.LastName = actorDTO.LastName;
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