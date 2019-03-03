using Generator.Database.Context.IDatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Generator.Database.Context.DatabaseContext
{
    public class ContextFactory : IContextFactory
    {
        public DbContext GetDbContext()
        {
            return new GeneratorContext();
        }
    }
}
