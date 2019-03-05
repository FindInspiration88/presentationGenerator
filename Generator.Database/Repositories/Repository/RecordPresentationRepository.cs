using System;
using System.Collections.Generic;
using System.Text;
using Generator.Database.Context.DatabaseContext;
using Generator.Database.Models;
using Generator.Database.Repositories.IRepository;

namespace Generator.Database.Repositories.Repository
{
    public class RecordPresentationRepository:CrudRepository<RecordPresentation, int>, IRecordPresentationRepository
    {
        public RecordPresentationRepository():base(new ContextFactory()) { }

    }
}
