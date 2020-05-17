﻿using System;
using CleanTemplate.Domain.Common;

namespace CleanTemplate.Domain.Entities
{
    public class WeatherForecast : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public int Temperature { get; set; }
        public string Wind { get; set; }
        public string Clouds { get; set; }
        public DateTime ForecastDate { get; set; }
        public string Summary { get; set; }

        public Location ForecastLocation { get; set; }
        
    }
}
