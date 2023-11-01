using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class TrainerRoomConfiguration : IEntityTypeConfiguration<TrainerRoom>
    {
        public void Configure(EntityTypeBuilder<TrainerRoom> builder)
        {
            builder.ToTable("trainerRoom");

            builder.Property(p => p.IdPerTrainerFk)
            .HasMaxLength(20);

            builder.Property(p => p.IdRoomFk)
            .HasColumnType("int");

            builder.HasOne(p => p.Person)
            .WithMany(p => p.TrainerRooms)
            .HasForeignKey(p => p.IdPerTrainerFk);

            builder.HasOne(p => p.Room)
            .WithMany(p => p.TrainerRooms)
            .HasForeignKey(p => p.IdRoomFk);
        }
    }
}