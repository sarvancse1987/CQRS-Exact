using System;

namespace CQRS.Handlers.DTO.User
{
    public class Users
    {
        public int ID { get; set; }
        public Guid UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
