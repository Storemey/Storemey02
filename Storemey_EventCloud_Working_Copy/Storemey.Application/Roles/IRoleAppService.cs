using System.Threading.Tasks;
using Abp.Application.Services;
using Storemey.Roles.Dto;

namespace Storemey.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
