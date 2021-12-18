using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using project.Data;
using project.Models;
using project.ViewModels;


namespace project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _countryRepo;
        private readonly ILogger<ActorController> _logger;

        public CountryController(ICountryRepository countryRepo, ILogger<ActorController> logger)
        {
            _countryRepo = countryRepo?? throw new ArgumentNullException(nameof(countryRepo));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public async Task<List<CountryDTO>> GetAll()
        {
            List<CountryDTO> countries = await _countryRepo.GetAll();
            return countries;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            CountryDTO country = await _countryRepo.GetById(id);
            return Ok(country);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CountryDTO model)
        {
            await _countryRepo.Create(model);
            return Ok(new { message = "Country created" });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(CountryDTO model)
        {
            await _countryRepo.Update(model);
            return Ok(new { message = "Country updated" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _countryRepo.Delete(id);
            return Ok(new { message = "Country deleted" });
        }
    }
}
