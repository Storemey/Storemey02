using System.Threading.Tasks;
using Abp.Application.Services;
using Storemey.Users.Dto;
using Abp.Application.Services.Dto;
using Abp.Dependency;

namespace Storemey.Users
{
    public interface IUserAppService : IApplicationService, ITransientDependency
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);

        Task<ListResultDto<UserDto>> GetList(GetUserListInput input);


    }
}