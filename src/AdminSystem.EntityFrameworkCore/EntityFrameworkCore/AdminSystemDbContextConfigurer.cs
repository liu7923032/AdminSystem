using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AdminSystem.EntityFrameworkCore
{
    public static class AdminSystemDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AdminSystemDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AdminSystemDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
