using Abp.Authorization;
using RIMIKS.Authorization.Roles;
using RIMIKS.Authorization.Users;

namespace RIMIKS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
