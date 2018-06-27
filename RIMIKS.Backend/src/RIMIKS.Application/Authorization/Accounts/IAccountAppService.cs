using System.Threading.Tasks;
using Abp.Application.Services;
using RIMIKS.Authorization.Accounts.Dto;

namespace RIMIKS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
