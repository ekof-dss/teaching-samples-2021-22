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
                    a.LastName,
                    a.FirstName,
                    a.Country.Code,
                    a.DateOfBirth
                )).ToList();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _actorRepo.GetById(id);
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ActorCreateDTO model)
        {
            await _actorRepo.Create(model);
            return Ok(new { message = "User created" });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(ActorUpdateDTO model)
        {
            await _actorRepo.Update(model);
            return Ok(new { message = "User updated" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _actorRepo.Delete(id);
            return Ok(new { message = "User deleted" });
        }
    }
}
