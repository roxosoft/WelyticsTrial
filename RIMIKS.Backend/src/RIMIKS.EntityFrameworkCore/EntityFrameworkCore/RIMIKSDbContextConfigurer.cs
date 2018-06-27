using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace RIMIKS.EntityFrameworkCore
{
    public static class RIMIKSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<RIMIKSDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<RIMIKSDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
