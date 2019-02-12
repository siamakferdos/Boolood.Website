using System;
using Microsoft.AspNetCore.Identity;

namespace Common.ApplicationIdentity
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset CreationDate { get; set; }
    }
}
