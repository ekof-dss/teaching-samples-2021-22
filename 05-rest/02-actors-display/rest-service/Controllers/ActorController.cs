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
    public class ActorController : ControllerBase
    {
        private readonly ILogger<ActorController> _logger;

        public ActorController(ILogger<ActorController> logger)
        {
            _logger = logger?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public IEnumerable<ActorDTO> GetRandomSlice()
        {
            List<Country> countries = CountryData.ListAll();
            List<Actor> actors = ActorData.ListAll( countries );
            var rng = new Random();
            int skip = rng.Next(0, actors.Count/2);
            int take = rng.Next(0, actors.Count);
            return actors.Skip(skip).Take(take).Select(a => 
                new ActorDTO(
                    a.Id,
                    a.FirstName,
                    a.LastName,
                    a.Country.Code,
                    a.DateOfBirth
            )).ToList();
        }
    }
}
