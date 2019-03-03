using System.ComponentModel.DataAnnotations;

namespace Generator.Database.Models
{
    /// <summary>
    /// Базовый класс для всех моделей
    /// </summary>
    /// <typeparam name="T">Тип данных для Id</typeparam>
    public class EntityBase<T>
    {
        [Key]
        public T Id { get; set; }
    }
}
