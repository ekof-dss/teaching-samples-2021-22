using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using project.Models;

namespace project.Services
{
    public interface IActorService
    {
        Task<List<Actor>> GetActors();

        Task<int> Add(string firstName, string lastName, long countryId);

        Task<int> Delete(Actor actor);

        Task<int> Update(Actor actor);

        Task<List<Actor>> Search(string fn, string ln, string c);
    }
}
