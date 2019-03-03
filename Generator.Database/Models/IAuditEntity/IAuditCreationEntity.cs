using System;

namespace Generator.Database.Models.IAuditEntity
{
    interface IAuditCreationEntity
    {
        /// <summary>
        /// Время помещения записи в БД
        /// </summary>
        DateTime CreationTime { get; set; }
    }
}
