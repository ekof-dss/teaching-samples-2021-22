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

        public ActorService(HttpClient httpClient, IMessagingService messagingService)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(
                nameof(httpClient));
            _messagingService = messagingService ?? throw new
                ArgumentNullException(nameof(messagingService));
        }
        public async Task<List<Actor>> GetActors()
        {
            // sending request for reading to the server
            List<Actor> actors = await _httpClient.GetFromJsonAsync<List<Actor>>(
                _requestUri);
            await _messagingService.Add("ActorService::Sent request for read");
            return actors;
        }

        public async Task<int> Add(string firstName, string lastName,
            long countryId)
        {
            // sending request for adding to the server
            ActorAddDTO actorAdd = new ActorAddDTO()
            {
                Id = -1,
                FirstName = firstName,
                LastName = lastName,
                CountryId = countryId
            };
            var response = await _httpClient.PostAsJsonAsync(_requestUri, actorAdd);
            await _messagingService.Add(response.IsSuccessStatusCode ?
                "ActorService::Sent request for add" :
                "ActorService::Error while adding");
             // return result
            return 0;
        }

        public async Task<int> Delete(Actor actor)
        {
            // sending request for deleting to the server
            var response = await _httpClient.DeleteAsync(_requestUri + "/"
                + actor.Id);
            await _messagingService.Add(response.IsSuccessStatusCode ?
                "ActorService::Sent request for delete" :
                "ActorService::Error while deleting");
            // return result
            return 0;
        }

        public async Task<int> Update(Actor actor)
        {
            // sending request for updating to the server
            ActorUpdateDTO actorUpd = new ActorUpdateDTO()
            {
                Id = actor.Id,
                FirstName = actor.FirstName,
                LastName = actor.LastName,
                CountryId = actor.CountryId,
                DateOfBith = actor.DateOfBith
            };
            var response = await _httpClient.PutAsJsonAsync<ActorUpdateDTO>(
                _requestUri + "/" + actor.Id, actorUpd);
            await _messagingService.Add(response.IsSuccessStatusCode ?
                "ActorService::Sent request for update" :
                "ActorService::Error while updating");
            // return result          
            return 0;
        }

        public async Task<List<Actor>> Search(string fn, string ln, string c)
        {
            List<Actor> actors = await _httpClient.GetFromJsonAsync<List<Actor>>(
                        _requestUri);
            List<Actor> result = actors.Where(actor =>
                            actor.FirstName.ToLower().Contains(fn.ToLower()) ||
                            actor.LastName.ToLower().Contains(ln.ToLower()) ||
                            actor.CountryCode.ToLower().Contains(c.ToLower()))
                        .ToList<Actor>();
            return result;
        }

    }
}