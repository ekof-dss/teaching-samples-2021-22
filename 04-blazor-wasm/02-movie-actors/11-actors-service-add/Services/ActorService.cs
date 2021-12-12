using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Linq;

using project.Models;

namespace project.Services
{
    public class ActorService : IActorService
    {
        private readonly HttpClient _httpClient;
        private readonly IMessagingService _messagingService;

        private List<Actor> _actors = null;
        public ActorService(HttpClient httpClient, IMessagingService messagingService)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(
                nameof(httpClient));
            _messagingService = messagingService ?? throw new
                ArgumentNullException(nameof(messagingService));
        }

        public async Task<List<Actor>> GetActors(bool reload = false)
        {
            if (_actors == null || reload)
            {
                Actor[] result = await _httpClient.GetFromJsonAsync<Actor[]>(
                    "sample-data/actors.json");
                _actors = result.ToList();
                await _messagingService.Add("ActorsService::Actors reloaded");
            }
            else
            {
                await _messagingService.Add("ActorsService::Actors already loaded");
            }
            return _actors;
        }

        public Task<List<Actor>> Add(string firstName, string lastName,
            string country)
        {
            long maxId = _actors.Max(actor => actor.Id) + 1;
            Actor newActor = new Actor()
            {
                Id = maxId,
                FirstName = firstName,
                LastName = lastName,
                CountryCode = country
            };
            _actors.Add(newActor);
            return Task.FromResult(_actors);
        }

    }
}