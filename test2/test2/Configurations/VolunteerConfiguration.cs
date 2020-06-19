using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test2.Models;

namespace test2.Configurations
{
    public class VolunteerConfiguration : IEntityTypeConfiguration<Volunteer>
    {
        public void Configure(EntityTypeBuilder<Volunteer> builder)
        {
            builder.HasKey(e => e.IdVolunteer)
                  .HasName("Volunteer_pk");

            builder.HasOne(e => e.IdSupervisorNavigation).WithMany().HasForeignKey(e => e.IdSupervisor).HasConstraintName("IdSupervisor");

            builder.Property(e => e.Name)
                  .IsRequired()
                  .HasMaxLength(80);

            builder.Property(e => e.Surname)
                 .IsRequired()
                 .HasMaxLength(80);

            builder.Property(e => e.Phone)
                 .IsRequired()
                 .HasMaxLength(30);

            builder.Property(e => e.Address)
                 .IsRequired()
                 .HasMaxLength(100);

            builder.Property(e => e.Email)
                 .IsRequired()
                 .HasMaxLength(80);

            builder.Property(e => e.StartingDate).HasColumnType("date");
        }
    }
}
