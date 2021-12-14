using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using project.Models;
using project.ViewModels;

namespace project.Data
{
    public interface IActorRepository
    {
        public Task<List<Actor>> GetAll();

        public Task<Actor> GetById(int id);

        public Task<Actor> Create(ActorCreateDTO actor);

        public Task<Actor> Update(ActorUpdateDTO actor);

        public Task Delete(int id);

    }
}