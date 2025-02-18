using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

public class Aircraft
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("AIRCRAFT_ID")]
    public int ID { get; set; }

    public AircraftSpezifikation Spezifikation { get; set; }

    [Column("SPEZIFIKATION_ID")] public int SpezifikationId { get; set; }

    [Required, Range(0, 100)]
    [Column("SPEZIFICATION_ID")]
    public int Fuel { get; set; }

    [Required, Range(0, 100)]
    [Column("SPEED")]
    public int Speed { get; set; }

    [Column("ALTITUDE")] public int Altitude { get; set; }
    [MaxLength(200)] [Column("NAME")] public string Name { get; set; }
}

[Table("AIRCRAFT_SPECIFICATIONS")]
public class AircraftSpezifikation
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("AIRCRAFT_SPECIFICATION_ID")]
    public int Id { get; set; }
    
    [Required, Range(0,20)]
    [Column("STRUCTURE")]
    public int Structure { get; set; }
    
    [Required, Range(0,20)]
    [Column("FUEL_CAPACITY")]
    public int FuelCapacity { get; set; }
    
    [Required, Range(0,20)]
    [Column("MIN_SPEED")]
    public int MinSpeed { get; set; }
    
    [Required, Range(0,20)]
    [Column("MAX_SPEED")]
    public int MaxSpeed { get; set; }
    
    [Required, Range(0,20)]
    [Column("MAX_ALTITUDe")]
    public int MaxAltitude { get; set; }
    
    [Required, StringLength(200)]
    [Column("SPECIFICATION_CODE")]
    public string SpecificationCode { get; set; }
}
