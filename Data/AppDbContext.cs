using Microsoft.EntityFrameworkCore;
using TripPlannerAPI.Models;

namespace TripPlannerAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<UserTrip> UserTrips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trip>().HasKey(t => t.trip_id);
            modelBuilder.Entity<User>().HasKey(u => u.user_id);
            modelBuilder.Entity<UserTrip>().HasKey(ut => ut.user_trip_id);

            modelBuilder.Entity<UserTrip>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(ut => ut.user_id);

            modelBuilder.Entity<UserTrip>()
                .HasOne<Trip>()
                .WithMany()
                .HasForeignKey(ut => ut.trip_id);
        }
    }
}
