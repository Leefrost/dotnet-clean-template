using System;
using System.Collections.Generic;
using CleanTemplate.Domain.Common;

namespace CleanTemplate.Domain.Entities
{
    public class Location : Entity<Guid>
    {
        public Location()
        {
            Forecasts = new List<WeatherForecast>();
        }

        public string City { get; set; }

        public IList<WeatherForecast> Forecasts { get; }
    }
}
