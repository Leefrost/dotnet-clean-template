using System;
using System.Collections.Generic;

namespace CleanTemplate.Persistence.Database.DbEntities
{
    internal class LocationDb: DbEntity
    {
        public string City { get; set; }

        public virtual ICollection<WeatherForecastDb> Forecasts { get; set; }
    }
}
