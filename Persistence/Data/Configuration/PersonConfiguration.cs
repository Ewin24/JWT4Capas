using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("persons");

            builder.HasKey(e => e.IdPerson);
            builder.Property(e => e.IdPerson)
            .HasMaxLength(20);

            builder.Property(p => p.PersonName)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne(p => p.Gender)
            .WithMany(p => p.Persons)
            .HasForeignKey(p => p.IdGenderFk);

            builder.HasOne(p => p.City)
            .WithMany(p => p.Persons)
            .HasForeignKey(p => p.IdCityFk);

            builder.HasOne(p => p.PersonType)
            .WithMany(p => p.Persons)
            .HasForeignKey(p => p.IdPerTypeFk);
        }
    }
}