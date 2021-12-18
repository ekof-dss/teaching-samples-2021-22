using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using project.Models;
using project.ViewModels;

namespace project.Data
{
    public interface IActorRepository
    {
        public Task<List<ActorDTO>> GetAll();

        public Task<ActorDTO> GetById(int id);

        public Task<int> Create(ActorDTO actor);

        public Task<int> Update(ActorDTO actor);

        public Task<int> Delete(int id);

    }
}