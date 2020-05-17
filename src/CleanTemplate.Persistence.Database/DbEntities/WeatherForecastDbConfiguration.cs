using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanTemplate.Persistence.Database.DbEntities
{
    internal class WeatherForecastDbConfiguration : IEntityTypeConfiguration<WeatherForecastDb>
    {
        public void Configure(EntityTypeBuilder<WeatherForecastDb> builder)
        {
            builder.Property(x => x.Summary).HasColumnName("WeatherSummary");
        }
    }
}
