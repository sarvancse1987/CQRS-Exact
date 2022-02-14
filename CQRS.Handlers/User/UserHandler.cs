using CQRS.Core.CQ;
using CQRS.Handlers.DTO.User;
using CQRS.Service;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Handlers.User
{
    public class UserHandler
    {
        public UserHandler()
        {
        }
        public class UserHandlercommands : ICommandHandler<UserCommand.User_Update,Users>, ICommandHandler<UserCommand.User_UpdateProfileImage, Users>
        {
            private readonly IUserService _userService;
            public UserHandlercommands(IUserService userService)
            {
                _userService = userService;
            }
            public Task<Users> Handle(UserCommand.User_Update request, CancellationToken cancellationToken)
            {
                throw new System.NotImplementedException();
            }
            public Task<Users> Handle(UserCommand.User_UpdateProfileImage request, CancellationToken cancellationToken)
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
