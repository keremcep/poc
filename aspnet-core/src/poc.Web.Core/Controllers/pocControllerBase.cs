using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace poc.Controllers
{
    public abstract class pocControllerBase: AbpController
    {
        protected pocControllerBase()
        {
            LocalizationSourceName = pocConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
