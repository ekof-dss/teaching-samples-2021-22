using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Linq;

using project.Models;
using project.ViewModels;

namespace project.Services
{
    public class ActorService : IActorService
    {
        private const string _requestUri = "https://localhost:6001/api/actor";
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
                // sending request for reading to the server
                _actors = await _httpClient.GetFromJsonAsync<List<Actor>>(
                    _requestUri);
                await _messagingService.Add("ActorsService::Sent request for read");
            }
            else
            {
                await _messagingService.Add("ActorsService::Actors are already loaded");
            }
            return _actors;
        }

        public async Task<List<Actor>> Add(string firstName, string lastName,
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
            // sending request for adding to the server
            ActorAddDTO actorAdd = new ActorAddDTO()
            {
                Id = newActor.Id,
                FirstName = newActor.FirstName,
                LastName = newActor.LastName,
                CountryCode = newActor.CountryCode,
                CountryName = newActor.CountryCode,
                CountryId = 1
            };
            var response = await _httpClient.PostAsJsonAsync(_requestUri, newActor);
            await _messagingService.Add(response.IsSuccessStatusCode ?
                "ActorsService::Sent request for delete" :
                "ActorsService::Error while deleting");
            // return result
            return _actors;
        }

        public async Task<List<Actor>> Delete(Actor actor)
        {
            _actors.Remove(actor);
            // sending request for deleting to the server
            var response = await _httpClient.DeleteAsync(_requestUri + "/"
                + actor.Id);
            await _messagingService.Add(response.IsSuccessStatusCode ?
                "ActorsService::Sent request for delete" :
                "ActorsService::Error while deleting");
            // return result
            return _actors;
        }

        public async Task<List<Actor>> Update(Actor actor)
        {
            Actor act = _actors.Where(a => a.Id == actor.Id).FirstOrDefault();
            _actors.Remove(act);
            _actors.Add(actor);
            // sending request for updating to the server
            ActorUpdateDTO actorUpd = new ActorUpdateDTO()
            {
                Id = actor.Id,
                FirstName = actor.FirstName,
                LastName = actor.LastName,
                CountryCode = actor.CountryCode,
                CountryName = actor.CountryCode,
                CountryId = 1
            };
            var response = await _httpClient.PutAsJsonAsync<ActorUpdateDTO>(
                _requestUri + "/" + actor.Id, actorUpd);
            await _messagingService.Add(response.IsSuccessStatusCode ?
                "ActorsService::Sent request for update" :
                "ActorsService::Error while updating");
             // return result          
            return _actors;
        }

        public List<Actor> Search(string fn, string ln, string c)
        {
            List<Actor> result = _actors.Where(actor =>
                actor.FirstName.ToLower().Contains(fn.ToLower()) ||
                actor.LastName.ToLower().Contains(ln.ToLower()) ||
                actor.CountryCode.ToLower().Contains(c.ToLower()))
                .ToList<Actor>();
            return result;
        }

    }
}