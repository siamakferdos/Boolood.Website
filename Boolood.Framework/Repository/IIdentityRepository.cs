using Common.ApplicationIdentity;
using Microsoft.AspNetCore.Identity;


namespace Boolood.Framework.Repository
{
    public interface IIdentityRepository
    {
        void AddRole(IdentityRole role);
        void AddUser(ApplicationUser user);
    }
}
