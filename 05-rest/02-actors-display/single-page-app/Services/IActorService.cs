using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using project.Models;

namespace project.Services
{
    public interface IActorService
    {
        Task<List<Actor>> GetActors(bool reload = false);

        Task<List<Actor>> Add(string firstName, string lastName, string country);

        Task<List<Actor>> Delete(Actor actor);

        List<Actor> Search(string fn, string ln, string c);
    }
}
