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

        private List<Country> _countries = null;
        public CountryService(HttpClient httpClient, IMessagingService messagingService)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(
                nameof(httpClient));
            _messagingService = messagingService ?? throw new
                ArgumentNullException(nameof(messagingService));
        }
        public async Task<List<Country>> GetCountries(bool reload = false)
        {
            if (_countries == null || reload)
            {
                // sending request for reading to the server
                _countries = await _httpClient.GetFromJsonAsync<List<Country>>(
                    _requestUri);
                await _messagingService.Add("CountryService::Sent request for read");
            }
            else
            {
                await _messagingService.Add("CountryService::Countries are already loaded");
            }
            return _countries;
        }

    }
}