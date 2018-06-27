using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RIMIKS.Configuration;
using RIMIKS.Web;

namespace RIMIKS.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class RIMIKSDbContextFactory : IDesignTimeDbContextFactory<RIMIKSDbContext>
    {
        public RIMIKSDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<RIMIKSDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            RIMIKSDbContextConfigurer.Configure(builder, configuration.GetConnectionString(RIMIKSConsts.ConnectionStringName));

            return new RIMIKSDbContext(builder.Options);
        }
    }
}
