using System;

namespace Generator.Database.Models.IAuditEntity
{
    interface IAuditChangingEntity
    {
        /// <summary>
        /// Время последнего изменения записи в БД
        /// </summary>
        DateTime LastChangeTime { get; set; }
    }
}
