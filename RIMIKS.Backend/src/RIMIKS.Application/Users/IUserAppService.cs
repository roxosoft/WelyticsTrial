using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RIMIKS.Roles.Dto;
using RIMIKS.Users.Dto;

namespace RIMIKS.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
