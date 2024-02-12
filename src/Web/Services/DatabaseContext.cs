using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using SimpleFrameworkApp.Services.Tables;

namespace SimpleFrameworkApp.Services
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        { 
            var connectionString = ConfigurationManager.ConnectionStrings["Framework"].ConnectionString;
            Database.Connection.ConnectionString = connectionString;
        }
        
        public DbSet<VersionHistory> VersionHistory { get; set; }
    }
}