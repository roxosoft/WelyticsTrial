using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace RIMIKS.Controllers
{
    public abstract class RIMIKSControllerBase: AbpController
    {
        protected RIMIKSControllerBase()
        {
            LocalizationSourceName = RIMIKSConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
