using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;

namespace Storemey.Statistics
{
    public interface IStatisticsAppService : IApplicationService
    {
        Task<ListResultDto<NameValueDto>> GetStatistics();
    }
}