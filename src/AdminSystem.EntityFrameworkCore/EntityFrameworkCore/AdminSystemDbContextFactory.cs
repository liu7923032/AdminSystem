using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AdminSystem.Configuration;
using AdminSystem.Web;

namespace AdminSystem.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AdminSystemDbContextFactory : IDesignTimeDbContextFactory<AdminSystemDbContext>
    {
        public AdminSystemDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AdminSystemDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AdminSystemDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AdminSystemConsts.ConnectionStringName));

            return new AdminSystemDbContext(builder.Options);
        }
    }
}
