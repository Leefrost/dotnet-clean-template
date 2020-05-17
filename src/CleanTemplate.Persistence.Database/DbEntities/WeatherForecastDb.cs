using System;

namespace CleanTemplate.Persistence.Database.DbEntities
{
    public class WeatherForecastDb
    {
        public Guid Id { get; set; }
        public int Temperature { get; set; }
        public string Wind { get; set; }
        public string Clouds { get; set; }
        public DateTime ForecastDate { get; set; }
        public string Summary { get; set; }

        public virtual LocationDb ForecastLocation { get; set; }
    }
}
