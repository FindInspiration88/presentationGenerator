using System.ComponentModel.DataAnnotations.Schema;

namespace Generator.Database.Models
{
    [Table("test_entities")]
    public class TestEntity:EntityBase<int>
    {
        public string TEST_FIELD1 { get; set; }
        public long TEST_FIELD2 { get; set; }
    }
}
