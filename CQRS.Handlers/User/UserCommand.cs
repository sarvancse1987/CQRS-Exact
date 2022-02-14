using CQRS.Core.CQ;
using CQRS.Handlers.DTO.User;

namespace CQRS.Handlers.User
{
    public class UserCommand
    {
        public record User_Update(Users User_Update_CmdReq) : ICommand<Users>;
        public record User_UpdateProfileImage(Users User_UpdateProfileImage_CmdReq) : ICommand<Users>;
    }
}
