using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using project.Models;

namespace project.Data
{
    public interface IActorRepository
    {
        public Task<List<Actor>> GetAll();

    }
}