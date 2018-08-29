using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Storemey.EntityFramework;

namespace Storemey
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(StoremeyCoreModule))]
    public class StoremeyDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
