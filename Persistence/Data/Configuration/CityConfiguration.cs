using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("cities");

            builder.HasKey(e => e.IdCity);
            builder.Property(e => e.IdCity)
            .HasMaxLength(3);

            builder.Property(p => p.CityName)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(p => p.State)
                .WithMany(p => p.Cities)
                .HasForeignKey(p => p.IdStateFk);
        }
    }
}
