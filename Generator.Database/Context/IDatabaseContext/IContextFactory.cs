using Microsoft.EntityFrameworkCore;

namespace Generator.Database.Context.IDatabaseContext
{
    public interface IContextFactory
    {
        DbContext GetDbContext();
    }
}
