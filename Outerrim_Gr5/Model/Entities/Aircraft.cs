using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("AIRCRAFTS")]
public class Aircraft
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("AIRCRAFT_ID")]
    public int Id { get; set; }

    public AircraftSpezification Spezification { get; set; }
    [Column("SPEZIFICATION_ID")] 
    
    public int SpezificationId { get; set; }
    [Required, Range(0, 100)]
    [Column("FUEL")]
    public int Fuel { get; set; }

    [Required, Range(0, 10)]
    [Column("SPEED")]
    public int Speed { get; set; }

    [Required, Range(0, 10)]
    [Column("ALTITUDE")] 
    public int Altitude { get; set; }
    
    [Required, StringLength(100)]
    [Column("NAME")] 
    public string Name { get; set; }
    
    public List<Compartment> Compartments { get; set; }
    
    public List<Crew> CrewItems { get; set; }
}
