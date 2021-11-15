using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace poc.EntityFrameworkCore
{
    public static class pocDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<pocDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<pocDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
