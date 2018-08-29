using System.Threading.Tasks;
using Abp.Authorization;
using Storemey.Users.Dto;
using Abp.Application.Services.Dto;
using Abp.Application.Services;
using System.Collections.Generic;
using Abp.Domain.Repositories;
using Abp.Dependency;

namespace Storemey.Users
{
    [AbpAuthorize]
    /* THIS IS JUST A SAMPLE. */
    public class UserAppService : StoremeyAppServiceBase, IUserAppService, ITransientDependency
    {
        private readonly UserManager _userManager;
        private readonly IPermissionManager _permissionManager;
        private readonly IRepository<Storemey.Users.User, long> _userRepository;

        public UserAppService(IRepository<Storemey.Users.User, long> userRepository, UserManager userManager, IPermissionManager permissionManager)
        {
            _userRepository = userRepository;
            _userManager = userManager;
            _permissionManager = permissionManager;
        }


        public async Task<ListResultDto<UserDto>> GetList(GetUserListInput input)
        {
            var users = await _userRepository.GetAllListAsync();
            return new ListResultDto<UserDto>(ObjectMapper.Map<List<UserDto>>(users));
        }


        public async Task ProhibitPermission(ProhibitPermissionInput input)
        {
            var user = await _userManager.GetUserByIdAsync(input.UserId);
            var permission = _permissionManager.GetPermission(input.PermissionName);

            await _userManager.ProhibitPermissionAsync(user, permission);
        }

        //Example for primitive method parameters.
        public async Task RemoveFromRole(long userId, string roleName)
        {
            CheckErrors(await _userManager.RemoveFromRoleAsync(userId, roleName));
        }
    }
}