using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using project.Models;
using project.ViewModels;

namespace project.Data
{
    public class ActorRepository : IActorRepository
    {
        private List<Actor> _data = new List<Actor>();

        public ActorRepository()
        {
            _data.Add(new Actor()
            {
                Id = 1,
                FirstName = "Bata",
                LastName = "Zivojinovic",
                DateOfBirth = new DateTime(1933, 6, 5),
                Country = new Country()
                {
                    Id = 1,
                    Name = "Serbia",
                    Code = "RS"
                }
            });
            _data.Add(new Actor()
            {
                Id = 2,
                FirstName = "Julia",
                LastName = "Roberts",
                DateOfBirth = new DateTime(1967, 3, 26),
                Country = new Country()
                {
                    Id = 2,
                    Name = "United States of America",
                    Code = "US"
                }
            });
            _data.Add(new Actor()
            {
                Id = 3,
                FirstName = "Robert",
                LastName = "De Niro",
                DateOfBirth = new DateTime(1943, 12, 17),
                Country = new Country()
                {
                    Id = 2,
                    Name = "United States of America",
                    Code = "US"
                }
            });
            _data.Add(new Actor()
            {
                Id = 4,
                FirstName = "Al",
                LastName = "Pacino",
                DateOfBirth = new DateTime(1940, 5, 25),
                Country = new Country()
                {
                    Id = 2,
                    Name = "United States of America",
                    Code = "US"
                }
            });
            _data.Add(new Actor()
            {
                Id = 5,
                FirstName = "Tom",
                LastName = "Cruise",
                DateOfBirth = new DateTime(1962, 7, 3),
                Country = new Country()
                {
                    Id = 2,
                    Name = "United States of America",
                    Code = "US"
                }
            });
            _data.Add(new Actor()
            {
                Id = 6,
                FirstName = "Brad",
                LastName = "Pitt",
                DateOfBirth = new DateTime(1963, 12, 18),
                Country = new Country()
                {
                    Id = 2,
                    Name = "United States of America",
                    Code = "US"
                }
            });
            _data.Add(new Actor()
            {
                Id = 7,
                FirstName = "Leonardo",
                LastName = "DiCaprio",
                DateOfBirth = new DateTime(1974, 11, 11),
                Country = new Country()
                {
                    Id = 2,
                    Name = "United States of America",
                    Code = "US"
                }
            });
            _data.Add(new Actor()
            {
                Id = 8,
                FirstName = "Tom",
                LastName = "Hanks",
                DateOfBirth = new DateTime(1956, 7, 9),
                Country = new Country()
                {
                    Id = 2,
                    Name = "United States of America",
                    Code = "US"
                }
            });
            _data.Add(new Actor()
            {
                Id = 9,
                FirstName = "Morgan",
                LastName = "Freeman",
                DateOfBirth = new DateTime(1937, 11, 2),
                Country = new Country()
                {
                    Id = 2,
                    Name = "United States of America",
                    Code = "US"
                }
            });
            _data.Add(new Actor()
            {
                Id = 10,
                FirstName = "Denzel",
                LastName = "Washington",
                DateOfBirth = new DateTime(1954, 12, 6),
                Country = new Country()
                {
                    Id = 2,
                    Name = "United States of America",
                    Code = "US"
                }
            });
            _data.Add(new Actor()
            {
                Id = 11,
                FirstName = "Robert",
                LastName = "Downey Jr.",
                DateOfBirth = new DateTime(1965, 4, 4),
                Country = new Country()
                {
                    Id = 2,
                    Name = "United States of America",
                    Code = "US"
                }
            });
            _data.Add(new Actor()
            {
                Id = 12,
                FirstName = "Chris",
                LastName = "Evans",
                DateOfBirth = new DateTime(1981, 3, 27),
                Country = new Country()
                {
                    Id = 2,
                    Name = "United States of America",
                    Code = "US"
                }
            });
            _data.Add(new Actor()
            {
                Id = 13,
                FirstName = "Chris",
                LastName = "Hemsworth",
                DateOfBirth = new DateTime(1983, 12, 13),
                Country = new Country()
                {
                    Id = 2,
                    Name = "United States of America",
                    Code = "US"
                }
            });
            _data.Add(new Actor()
            {
                Id = 14,
                FirstName = "Mark",
                LastName = "Wahlberg",
                DateOfBirth = new DateTime(1971, 6, 6),
                Country = new Country()
                {
                    Id = 2,
                    Name = "United States of America",
                    Code = "US"
                }
            });
            _data.Add(new Actor()
            {
                Id = 15,
                FirstName = "Samuel",
                LastName = "Jackson",
                DateOfBirth = new DateTime(1948, 12, 16),
                Country = new Country()
                {
                    Id = 2,
                    Name = "United States of America",
                    Code = "US"
                }
            });
            _data.Add(new Actor()
            {
                Id = 16,
                FirstName = "Jet",
                LastName = "Li",
                DateOfBirth = new DateTime(1963, 4, 26),
                Country = new Country()
                {
                    Id = 3,
                    Name = "People's Republic of China",
                    Code = "PRC"
                }
            });
        }

        public async Task<List<Actor>> GetAll()
        {
            return await Task.FromResult(_data);
        }

        public async Task<Actor> GetById(int id)
        {
            return await Task.FromResult(_data.FirstOrDefault(x => x.Id == id));
        }

        public async Task<int> Create(ActorCreateDTO actor)
        {
            Actor newActor = new Actor()
            {
                Id = _data.Max(x => x.Id) + 1,
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
            _data.Add(newActor);
            return await Task.FromResult(0);
        }

        public Task<int> Update(ActorUpdateDTO actor)
        {
            Actor actorToUpdate = _data.FirstOrDefault(x => x.Id == actor.Id);
            actorToUpdate.FirstName = actor.FirstName;
            actorToUpdate.LastName = actor.LastName;
            actorToUpdate.DateOfBirth = actor.DateOfBirth;
            actorToUpdate.Country = new Country()
            {
                Id = actor.CountryId,
                Name = actor.CountryName,
                Code = actor.CountryCode
            };
            return Task.FromResult(0);
        }
        public Task<int> Delete(int id)
        {
            _data.RemoveAll(x => x.Id == id);
            return Task.FromResult(0);
        }

    }
}