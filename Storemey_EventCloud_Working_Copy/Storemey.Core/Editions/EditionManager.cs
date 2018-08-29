using Abp.Application.Editions;
using Abp.Application.Features;
using Abp.Domain.Repositories;
using Storemey.Features;

namespace Storemey.Editions
{
    public class EditionManager : AbpEditionManager
    {
        public EditionManager(
            IRepository<Edition> editionRepository,
            FeatureValueStore featureValueStore)
            : base(
                editionRepository,
                featureValueStore)
        {
        }
    }
}
