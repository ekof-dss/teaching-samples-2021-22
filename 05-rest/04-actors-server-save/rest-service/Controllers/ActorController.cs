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
        private readonly IActorRepository _actorRepo;
        private readonly ILogger<ActorController> _logger;

        public ActorController(IActorRepository actorRepo, ILogger<ActorController> logger)
        {
            _actorRepo = actorRepo?? throw new ArgumentNullException(nameof(actorRepo));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public async Task<IEnumerable<ActorDTO>> GetAll()
        {
            List<Actor> actors = await _actorRepo.GetAll();
            return actors.Select(a =>
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
