using System;
using BacklogBonanza.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BacklogBonanza.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private readonly ILogger<GameController> _logger;
        private readonly IGameService _service;

        public GameController(ILogger<GameController> logger, IGameService service)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _service.Get();
            return Ok(result);
        }
    }
}
