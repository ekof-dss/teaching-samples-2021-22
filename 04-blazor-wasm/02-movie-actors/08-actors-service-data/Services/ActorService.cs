using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

using project.Models;

namespace project.Services
{
    public class ActorService : IActorService
    {
        private readonly HttpClient _httpClient;

        public ActorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Actor>> GetActors()
        {
            Actor[] result = await _httpClient.GetFromJsonAsync<Actor[]>(
                "sample-data/actors.json");
            return new List<Actor>(result);
        }
    }
}