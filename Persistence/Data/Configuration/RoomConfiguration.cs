using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable("room");

            builder.HasKey(e => e.IdRoom);
            builder.Property(e => e.IdRoom);

            builder.Property(p => p.RoomName)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p => p.Capacity)
            .HasColumnType("int");
        }
    }
}