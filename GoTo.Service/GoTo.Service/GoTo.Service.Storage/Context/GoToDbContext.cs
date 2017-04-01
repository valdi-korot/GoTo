using System.Data.Entity;

namespace GoTo.Service.Storage.Context
{
    public sealed class GoToDbContext : DbContext
    {
        public GoToDbContext(string goToDbConnectionString) : base(goToDbConnectionString)
        { }
    }
}
