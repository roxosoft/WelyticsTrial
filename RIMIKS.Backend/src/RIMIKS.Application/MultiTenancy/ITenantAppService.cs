using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RIMIKS.MultiTenancy.Dto;

namespace RIMIKS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
