using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

using project.Models;

namespace project.Services
{
    public class ActorService : IActorService
    {
        private readonly HttpClient _httpClient;
        private readonly IMessagingService _messagingService;
        private Actor[] _actors = null;
        public ActorService(HttpClient httpClient, IMessagingService messagingService)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(
                nameof(httpClient));
            _messagingService = messagingService ?? throw new
                ArgumentNullException(nameof(messagingService));
        }

        public async Task<Actor[]> GetActors()
        {
            await _messagingService.Add("ActorsService::Actors fetched");
            _actors = await _httpClient.GetFromJsonAsync<Actor[]>(
                "sample-data/actors.json");
            return _actors;
        }


        public Task<Actor[]> Add(string firstName, string lastName,
            string country)
        {
            List<Actor> actorList = new List<Actor>(_actors);
            long maxId = actorList.Max(actor => actor.Id) + 1;
            Actor newActor = new Actor()
            {
                Id = maxId,
                FirstName = firstName,
                LastName = lastName,
                CountryCode = country
            };
            actorList.Add(newActor);
            _actors = actorList.ToArray();
            return Task.FromResult(_actors);
        }

        public Task<Actor[]> Delete(Actor actor)
        {
            List<Actor> actorList = new List<Actor>(_actors);
            actorList.Remove(actor);
            _actors = actorList.ToArray();
            return Task.FromResult(_actors);
        }

        public Actor[] Search(string fn, string ln, string c)
        {
            return _actors.Where(actor =>
                actor.FirstName.ToLower().Contains(fn.ToLower()) ||
                actor.LastName.ToLower().Contains(ln.ToLower()) ||
                actor.CountryCode.ToLower().Contains(c.ToLower())).ToArray();
        }
    }
}