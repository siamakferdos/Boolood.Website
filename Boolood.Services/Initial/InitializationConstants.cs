using System;
using System.Collections.Generic;
using System.Text;
using Common.ApplicationIdentity;

namespace Boolood.Services.Initial
{
    class InitializationConstants
    {
        public ApplicationUser AdminUser = new ApplicationUser
        {
            Email = "siamak.ferdos@gmail.com",
            FirstName = "Siamak",
            LastName = "B.Ferdos",
            EmailConfirmed = true,
            CreationDate = DateTimeOffset.Now,
            AccessFailedCount = 5,
            PasswordHash = "Kd2HuilFuiowe76F8tfyuioefguew",
            PhoneNumber = "00989143058600",
            PhoneNumberConfirmed = true,
            TwoFactorEnabled = true,
            UserName = InitializationConstants.AdminUserId
        };

        public const string AdminRoleId = "AdminRole";
        public const string AdminUserId = "admin";
        public const string AdminPassword = "MainAdminPassword";

        public const string AdminAuthorRoleId = "AdminAuthorRole";
        public const string AdminAuthorUserId = "authoradmin";
        public const string AdminAuthorPassword = "AdminAuthorPassword";
    }
}
