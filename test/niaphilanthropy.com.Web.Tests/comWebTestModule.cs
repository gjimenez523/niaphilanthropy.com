using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using niaphilanthropy.com.Web.Startup;
namespace niaphilanthropy.com.Web.Tests
{
    [DependsOn(
        typeof(comWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class comWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(comWebTestModule).GetAssembly());
        }
    }
}