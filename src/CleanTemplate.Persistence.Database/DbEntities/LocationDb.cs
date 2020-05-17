using System;
using System.Collections.Generic;

namespace CleanTemplate.Persistence.Database.DbEntities
{
    public class LocationDb
    {
        public Guid Id { get; set; }
        public string City { get; set; }

        public virtual ICollection<WeatherForecastDb> Forecasts { get; set; }
    }
}
