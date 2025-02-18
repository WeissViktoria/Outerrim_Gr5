using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Model.Configurations;

public class OuterrimDbContext : DbContext
{
    public DbSet<Aircraft> Aircrafts { get; set; }
    public DbSet<Compartment> Compartments { get; set; }
    public DbSet<Mercenary> Mercenaries { get; set; }
    public DbSet<Crew> Crews { get; set; }
    
    public OuterrimDbContext(DbContextOptions<OuterrimDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Compartment>()
            .HasOne(c => c.Aircraft)
            .WithMany()
            .HasForeignKey(c => c.Aircraft_Id);

        modelBuilder.Entity<Crew>()
            .HasKey(c => new { c.Aircraft_Id, c.Mercenary_Id });
        
        modelBuilder.Entity<Crew>()
            .HasOne(c => c.Aircraft)
            .WithMany()
            .HasForeignKey(c => c.Aircraft_Id);
        
        modelBuilder.Entity<Crew>()
            .HasOne(c => c.Mercenary)
            .WithMany()
            .HasForeignKey(c => c.Mercenary_Id);
    }
    
}