using System.Data.Entity;
using SimpleFrameworkApp.Services.Tables;

namespace SimpleFrameworkApp.Services
{
    public class DatabaseContext : DbContext
    {
        public DbSet<VersionHistory> VersionHistory { get; set; }
    }
}