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
    public DbSet<AircraftSpezification> AircraftSpezifications { get; set; }
    public DbSet<CrimeSyndicate> CrimeSyndicates {get;set;}
    public DbSet<MercenaryReputation> MercenaryReputations { get; set; }
    public DbSet<Machinery> Machineries { get; set; }
    
    public OuterrimDbContext(DbContextOptions<OuterrimDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Machinery>().HasDiscriminator<string>("MACHINERY_TYPE")
            .HasValue<Weapon>("WEAPONS")
            .HasValue<EnviromentalSystem>("ENERGY_SYSTEMS")
            .HasValue<EnergySystem>("ENVIRONMENTAL_SYSTEMS");
        
        modelBuilder.Entity<Machinery>()
            .HasOne(m => m.Compartment)
            .WithMany()
            .HasForeignKey(m => m.Compartment_Id);
        
        modelBuilder.Entity<Compartment>()
            .HasOne(c => c.Aircraft)
            .WithMany(a => a.Compartments)
            .HasForeignKey(c => c.Aircraft_Id);

        modelBuilder.Entity<Crew>()
            .HasKey(c => new { c.Aircraft_Id, c.Mercenary_Id });
        
        modelBuilder.Entity<Crew>()
            .HasOne(c => c.Aircraft)
            .WithMany(a => a.CrewItems)
            .HasForeignKey(c => c.Aircraft_Id);
        
        modelBuilder.Entity<Crew>()
            .HasOne(c => c.Mercenary)
            .WithMany()
            .HasForeignKey(c => c.Mercenary_Id);

        modelBuilder.Entity<Aircraft>()
            .HasOne(a => a.Spezification)
            .WithMany()
            .HasForeignKey(a => a.SpezificationId);
        
        modelBuilder.Entity<MercenaryReputation>()
            .HasKey(mr => new { mr.MercenaryId, mr.CrimeSynicateId });
        
        modelBuilder.Entity<MercenaryReputation>()
            .HasOne(mr => mr.Mercenary)
            .WithMany()
            .HasForeignKey(mr => mr.MercenaryId);

        modelBuilder.Entity<MercenaryReputation>()
            .HasOne(mr => mr.CrimeSyndicate)
            .WithMany()
            .HasForeignKey(mr => mr.CrimeSynicateId);
    }
    
}