using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTest.Domain.Entities
{
    public class User : ObjectId
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public DateTime DatedJoined { get; set; }
        public string UserRole { get; set; }

    }
}
