using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Net_Core_3_MsSQL_Codefirst.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MsSQLDbContext>
    {
        public MsSQLDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<MsSQLDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);
            return new MsSQLDbContext(builder.Options);
        }
    }
}
