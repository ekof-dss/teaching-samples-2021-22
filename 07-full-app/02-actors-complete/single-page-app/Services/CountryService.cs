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
    public class CountryService : ICountryService
    {
        private const string _requestUri = "https://localhost:6001/api/country";
        private readonly HttpClient _httpClient;
        private readonly IMessagingService _messagingService;

        public CountryService(HttpClient httpClient, IMessagingService messagingService)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(
                nameof(httpClient));
            _messagingService = messagingService ?? throw new
                ArgumentNullException(nameof(messagingService));
        }
        public async Task<List<Country>> GetCountries()
        {
            // sending request for reading to the server
            List<Country> countries = await _httpClient.GetFromJsonAsync<List<Country>>(
                    _requestUri);
                await _messagingService.Add("CountryService::Sent request for read");
            return countries;
        }

        public async Task<int> Add(string countyCode, string counntryName)
        {
            // sending request for adding to the server
            Country countryAdd = new Country()
            {
                Id = -1,
                Code = countyCode,
                Name = counntryName
            };
            var response = await _httpClient.PostAsJsonAsync(_requestUri, countryAdd);
            await _messagingService.Add(response.IsSuccessStatusCode ?
                "CountryService::Sent request for add" :
                "CountryService::Error while adding");
             // return result
            return 0;      
        }

        public async Task<int> Delete(Country actor)
        {
            // sending request for deleting to the server
            var response = await _httpClient.DeleteAsync(_requestUri + "/"
                + actor.Id);
            await _messagingService.Add(response.IsSuccessStatusCode ?
                "CountryService::Sent request for delete" :
                "CountryService::Error while deleting");
            // return result
            return 0;
        }

        public async Task<int> Update(Country country)
        {
       // sending request for updating to the server
            Country countryUpd = new Country()
            {
                Id = country.Id,
                Code = country.Code,
                Name = country.Name
            };
            var response = await _httpClient.PutAsJsonAsync<Country>(
                _requestUri + "/" + country.Id, countryUpd);
            await _messagingService.Add(response.IsSuccessStatusCode ?
                "CountryService::Sent request for update" :
                "CountryService::Error while updating");
            // return result          
            return 0;        }
    }
}