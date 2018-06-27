using System.Threading.Tasks;
using Abp.Application.Services;
using RIMIKS.Sessions.Dto;

namespace RIMIKS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
