using System.Linq;
using SimpleFrameworkApp.Services.Tables;

namespace SimpleFrameworkApp.Services
{
    public class DatabaseService
    {
        private readonly DatabaseContext _dbContext;

        public DatabaseService()
        {
            _dbContext = new DatabaseContext();
        }

        public VersionHistory GetVersionHistory()
        {
            return _dbContext.VersionHistory.Last();
        }
    }
}