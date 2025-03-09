using System.Reflection.PortableExecutable;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Weapon = Model.Entities.Weapon;

namespace Model.Configurations;

public class OuterrimDbContext : DbContext
{
    public DbSet<Aircraft> Aircrafts { get; set; }
    public DbSet<Compartment> Compartments { get; set; }
    public DbSet<Mercenary> Mercenaries { get; set; }
    public DbSet<Crew> Crews { get; set; }
    public DbSet<AircraftSpezifikation> AircraftSpezifications { get; set; }
    public DbSet<CrimeSyndicate> CrimeSyndicates {get;set;}
    public DbSet<MercenaryReputation> MercenaryReputations { get; set; }
    public DbSet<Machinery> Machineries { get; set; }
    
    public OuterrimDbContext(DbContextOptions<OuterrimDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Aircraft>()
            .HasOne(a => a.Spezifikation)
            .WithMany()
            .HasForeignKey(a => a.SpezifikationId);

        modelBuilder.Entity<Compartment>()
            .HasOne(c => c.Aircraft)
            .WithMany(c => c.Compartments)
            .HasForeignKey(c => c.Aircraft_Id);

        modelBuilder.Entity<Crew>()
            .HasKey(c => new { c.Aircraft_Id, c.Mercenary_Id });

        modelBuilder.Entity<Crew>()
            .HasOne(c => c.Aircraft)
            .WithMany(c => c.CrewItems)
            .HasForeignKey(c => c.Aircraft_Id);

        modelBuilder.Entity<Crew>()
            .HasOne(c => c.Mercenary)
            .WithMany()
            .HasForeignKey(c => c.Mercenary_Id);

        modelBuilder.Entity<MercenaryReputation>()
            .HasKey(mr => new { mr.MercenaryId, mr.CrimeSyndicateId });
        
        modelBuilder.Entity<MercenaryReputation>()
            .HasOne(mr => mr.Mercenary)
            .WithMany()
            .HasForeignKey(mr => mr.MercenaryId);

        modelBuilder.Entity<MercenaryReputation>()
            .HasOne(mr => mr.CrimeSyndicate)
            .WithMany()
            .HasForeignKey(mr => mr.CrimeSyndicateId);
        
        modelBuilder.Entity<EnergySystem>().ToTable("ENERGY_SYSTEMS");
        modelBuilder.Entity<EnviromentalSystem>().ToTable("ENVIRONMENTAL_SYSTEMS");
        modelBuilder.Entity<Weapon>().ToTable("WEAPONS");
        
        modelBuilder.Entity<Machinery>()
            .HasOne(m => m.Compartment)
            .WithMany()
            .HasForeignKey(m => m.CompartmentId);

    }
    
    
}