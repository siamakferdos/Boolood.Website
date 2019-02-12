using System.Collections.Generic;
using System.Linq;
using Boolood.Framework.Repository;
using Microsoft.AspNetCore.Identity;
using Common.ApplicationIdentity;

namespace Boolood.Infrastructure
{
    public class IdentityRepository: IIdentityRepository
    {
        private readonly AppIdentityDbContext _identityDbContext;
        public IdentityRepository(AppIdentityDbContext identityDbContext)
        {
            _identityDbContext = identityDbContext;
        }

        public void AddRole(string roleName)
        {
            _identityDbContext.Roles.Add(new IdentityRole(roleName));
            _identityDbContext.SaveChanges();
        }

        public void AddRole(IdentityRole role)
        {
            throw new System.NotImplementedException();
        }

        public void AddUser(ApplicationUser user)
        {
            _identityDbContext.Users.Add(user);
            _identityDbContext.SaveChanges();
        }

        public ApplicationUser GetUser(string userId)
        {
            return _identityDbContext.Users.FirstOrDefault(u => u.Id == userId);
        }
    }
}
