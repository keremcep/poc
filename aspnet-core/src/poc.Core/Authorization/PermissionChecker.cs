using Abp.Authorization;
using poc.Authorization.Roles;
using poc.Authorization.Users;

namespace poc.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
