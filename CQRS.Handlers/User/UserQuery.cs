using CQRS.Core.CQ;
using CQRS.Handlers.DTO.User;
using System.Collections.Generic;

namespace CQRS.Handlers.User
{
    public class UserQuery
    {
        public record User_Get(Users User_QueryReq) : IQuery<List<Users>>;
        public record UserQuery_Get(Users UserEvent_QueryReq) : IQuery<List<Users>>;
    }
}
