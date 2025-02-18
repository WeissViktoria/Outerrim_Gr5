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
