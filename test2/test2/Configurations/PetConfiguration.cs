using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test2.Models;

namespace test2.Configurations
{
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.HasKey(e => e.IdPet)
                  .HasName("Pet_pk");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(80);

            builder.Property(e => e.IsMale)
                .IsRequired()
                .HasColumnType("bit");
            builder.Property(e => e.ApprocimateDateOfBirth).HasColumnType("date");
            builder.Property(e => e.DateAdopted).HasColumnType("date");
            builder.Property(e => e.DateRegistered).HasColumnType("date");
        }
    }
}
