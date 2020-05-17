using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanTemplate.Persistence.Database.DbEntities
{
    internal class LocaltionDbConfiguration : IEntityTypeConfiguration<LocationDb>
    {
        public void Configure(EntityTypeBuilder<LocationDb> builder)
        {
            builder.Property(x => x.City).HasColumnName("DbColumnCity");

            builder.HasMany(x => x.Forecasts)
                .WithOne(x => x.ForecastLocation)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
