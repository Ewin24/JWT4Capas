using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class TuitionConfiguration : IEntityTypeConfiguration<Tuition>
    {
        public void Configure(EntityTypeBuilder<Tuition> builder)
        {
            builder.ToTable("tuition");

            builder.HasKey(e => e.IdTuition);
            builder.Property(e => e.IdTuition);
        }
    }
}