using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test2.Configurations;

namespace test2.Models
{
    public class PetContext : DbContext
    {
        public PetContext()
        {
        }

        public PetContext(DbContextOptions<PetContext> options)
            : base(options)
        {


        }

        public DbSet<BreedType> BreedType { get; set; }
        public DbSet<Volunteer> Volunteer { get; set; }
        public DbSet<Pet> Pet { get; set; }
        public DbSet<Volunteer_Pet> Volunteer_Pet { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BreedTypeConfiguration());
            modelBuilder.ApplyConfiguration(new VolunteerConfiguration());
            modelBuilder.ApplyConfiguration(new PetConfiguration());
            modelBuilder.ApplyConfiguration(new Volunteer_PetConfiguration());
        }
    }
}
