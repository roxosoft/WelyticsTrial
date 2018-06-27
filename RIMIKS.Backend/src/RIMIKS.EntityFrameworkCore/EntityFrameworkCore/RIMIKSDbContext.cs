using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using RIMIKS.Authorization.Roles;
using RIMIKS.Authorization.Users;
using RIMIKS.MultiTenancy;

namespace RIMIKS.EntityFrameworkCore
{
    public class RIMIKSDbContext : AbpZeroDbContext<Tenant, Role, User, RIMIKSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public RIMIKSDbContext(DbContextOptions<RIMIKSDbContext> options)
            : base(options)
        {
        }
    }
}
