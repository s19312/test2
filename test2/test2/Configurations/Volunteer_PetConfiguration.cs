using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test2.Models;

namespace test2.Configurations
{
    public class Volunteer_PetConfiguration : IEntityTypeConfiguration<Volunteer_Pet>
    {

        public void Configure(EntityTypeBuilder<Volunteer_Pet> builder)
        {
            builder.HasKey(e => new { e.IdPet, e.IdVolunteer });

            builder.HasOne(e => e.IdPetNavigation).WithMany().HasForeignKey(e => e.IdPet).HasConstraintName("IdPet");
            builder.HasOne(e => e.IdVolunteerNavigation).WithMany().HasForeignKey(e => e.IdVolunteer).HasConstraintName("IdVolunteer");
        }
    }
}
