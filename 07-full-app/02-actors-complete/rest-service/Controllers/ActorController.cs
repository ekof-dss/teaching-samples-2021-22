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
        public async Task<List<ActorDTO>> GetAll()
        {
            List<ActorDTO> actors = await _actorRepo.GetAll();
            return actors;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            ActorDTO actor = await _actorRepo.GetById(id);
            return Ok(actor);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ActorDTO model)
        {
            await _actorRepo.Create(model);
            return Ok(new { message = "Actor created" });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(ActorDTO model)
        {
            await _actorRepo.Update(model);
            return Ok(new { message = "Actor updated" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _actorRepo.Delete(id);
            return Ok(new { message = "Actor deleted" });
        }
    }
}
