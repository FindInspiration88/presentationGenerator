using Generator.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Generator.Database.Context.DatabaseContext
{
    partial class GeneratorContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;UserId=root;Password=11111111;database=123;");
        }

        //Add new DbSets here
        public virtual DbSet<TestEntity> TestEntities { get; set; }
    }
}
