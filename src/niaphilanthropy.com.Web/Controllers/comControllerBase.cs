using Abp.AspNetCore.Mvc.Controllers;

namespace niaphilanthropy.com.Web.Controllers
{
    public abstract class comControllerBase: AbpController
    {
        protected comControllerBase()
        {
            LocalizationSourceName = comConsts.LocalizationSourceName;
        }
    }
}