using System;

namespace Interfaces
{
    public class DbMigrator
    {
        //Dependcey injection
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);
            //Details of migrating the database
            _logger.LogError("Migration finished at " + DateTime.Now.AddMinutes(10));
        }
    }
}