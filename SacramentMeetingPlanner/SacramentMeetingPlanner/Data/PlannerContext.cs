using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Data
{
    public class PlannerContext : DbContext
    {
        public PlannerContext(DbContextOptions<PlannerContext> options) : base(options)
        {
        }

        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<RoleAssignment> RoleAssignments { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<MusicSelection> MusicSelections { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meeting>().ToTable("Meetings");
            modelBuilder.Entity<RoleAssignment>().ToTable("RoleAssignments");
            modelBuilder.Entity<Person>().ToTable("Persons");
            modelBuilder.Entity<Song>().ToTable("Songs");
            modelBuilder.Entity<MusicSelection>().ToTable("MusicSelections");

        }

    }

}
