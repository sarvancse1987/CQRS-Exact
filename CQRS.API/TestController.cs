using CQRS.Core.CQ;
using CQRS.Handlers.DTO.User;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ICommandBus _commandBus;
        public TestController(ICommandBus commandBus)
        {
            _commandBus = commandBus;
        }
        public async Task<IActionResult> abc(Users users, CancellationToken cancellationToken)
        {
            var query = new CQRS.Handlers.User.UserCommand.User_Update(users);
            var execute = await _commandBus.Send(query, cancellationToken);
            return Ok(execute);
        }
    }
}
