using System;
using Generator.Database.Models;
using Generator.Database.Repositories.Repository;

namespace Generator.WebInteraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new TestEntityRepository();
            var testEntity = new TestEntity()
            {
                TEST_FIELD1 = "hello",
                TEST_FIELD2 =43
            };
            repo.Create(testEntity);
        }
    }
}
