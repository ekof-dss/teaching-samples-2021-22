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

        public Task<int> Create(ActorCreateDTO actor);

        public Task<int> Update(ActorUpdateDTO actor);

        public Task<int> Delete(int id);

    }
}