using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace Storemey
{
    [DependsOn(typeof(StoremeyCoreModule), typeof(AbpAutoMapperModule))]
    public class StoremeyApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
