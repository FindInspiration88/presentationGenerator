using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator.Database;
using Generator.Database.Context.DatabaseContext;
using Generator.Database.Models;

namespace Generator.Database.Repositories.Repository
{
    public class TestEntityRepository:CrudRepository<TestEntity,int>
    {
        public TestEntityRepository():base(new ContextFactory()){}
    }
}
