namespace CSharpInheritance
{
    //Using Composition and using the Logger class in multiple classes
    public class DbMigrator
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating blah blah blah");
        }
    }
}