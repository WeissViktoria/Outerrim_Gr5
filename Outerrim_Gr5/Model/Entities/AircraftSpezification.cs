using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

public class AircraftSpezifikation
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("AIRCRAFT_SPECIFICATION_ID")]
    public int Id { get; set; }


    [Required, Range(0, 20)]
    [Column("STRUCTURE")]
    public int Structure { get; set; }

    [Required, Range(0, 20)]
    [Column("FUEL_CAPACITY")]
    public int FuelCapacity { get; set; }

    [Required, Range(0, 20)]
    [Column("MIN_SPEED")]
    public int MinSpeed { get; set; }

    [Required, Range(0, 20)]
    [Column("MAX_SPEED")]
    public int MaxSpeed { get; set; }

    [Required, Range(0, 20)]
    [Column("MAX_ALTITUDE")]
    public int MaxAltitude { get; set; }

    [Required, StringLength(200)]
    [Column("SPECIFICATION_CODE")]
    public string SpecificationCode { get; set; }
}

