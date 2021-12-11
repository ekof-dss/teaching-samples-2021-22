using System;
using System.Threading.Tasks;

using project.Models;

namespace project.Services
{
    public interface IActorService
    {
        Task<Actor[]> GetActors();

        Task<Actor[]> Add(string firstName, string lastName, string country);

        Task<Actor[]> Delete(Actor actor);

        Actor[] Search(string fn, string ln, string c);
    }
}
