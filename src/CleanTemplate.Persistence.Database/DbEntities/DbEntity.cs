using System;

namespace CleanTemplate.Persistence.Database.DbEntities
{
    internal class DbEntity
    {
        public Guid Id { get; set; }
    }

    internal class DbEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}
