using Abp;

namespace Storemey
{
    public class StoremeyServiceBase : AbpServiceBase
    {
        public StoremeyServiceBase()
        {
            LocalizationSourceName = StoremeyConsts.LocalizationSourceName;
        }
    }
}