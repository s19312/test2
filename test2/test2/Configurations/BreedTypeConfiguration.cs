using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test2.Models;

namespace test2.Configurations
{
    public class BreedTypeConfiguration : IEntityTypeConfiguration<BreedType>
    {
        public void Configure(EntityTypeBuilder<BreedType> builder)
        {
            builder.HasKey(e => e.IdBreedType)
                  .HasName("BreedType_pk");

            builder.Property(e => e.Name)
                 .IsRequired()
                 .HasMaxLength(50);

            builder.Property(e => e.Description)
                 .IsRequired(false)
                 .HasMaxLength(500);
        }
    }
}
