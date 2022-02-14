using CQRS.Core.CQ;
using CQRS.Handlers.DTO.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICommandBus _commandBus;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, ICommandBus commandBus)
        {
            _logger = logger;
            _commandBus = commandBus;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpPost]
        public async Task<IActionResult> abc(Users users, CancellationToken cancellationToken)
        {
            var query = new CQRS.Handlers.User.UserCommand.User_Update(users);
            var execute = await _commandBus.Send(query, cancellationToken);
            return Ok(execute);
        }
    }
}
