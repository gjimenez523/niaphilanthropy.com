using Abp.AspNetCore.Mvc.Views;

namespace niaphilanthropy.com.Web.Views
{
    public abstract class comRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected comRazorPage()
        {
            LocalizationSourceName = comConsts.LocalizationSourceName;
        }
    }
}
