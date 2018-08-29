using Abp.Modules;
using Abp.TestBase;

namespace Storemey.Tests
{
    [DependsOn(
         typeof(StoremeyApplicationModule),
         typeof(StoremeyDataModule),
         typeof(AbpTestBaseModule)
     )]
    public class StoremeyTestModule : AbpModule
    {

    }
}