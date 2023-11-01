using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class PersonTypeConfiguration : IEntityTypeConfiguration<PersonType>
    {
        public void Configure(EntityTypeBuilder<PersonType> builder)
        {
            builder.ToTable("personType");

            builder.HasKey(e => e.IdPersonType);
            builder.Property(e => e.IdPersonType);

            builder.Property(p => p.TypePersonDescription)
            .IsRequired()
            .HasMaxLength(50);
        }
    }
}