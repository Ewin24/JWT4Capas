using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("pais");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
            .HasMaxLength(3);

            builder.Property(p => p.CountryName)
            .IsRequired()
            .HasMaxLength(50);
        }
    }
}