using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("AIRCRAFTS")]
public class Aircraft
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("AIRCRAFT_ID")]
    public int Id { get; set; }
    [Column("FUEL")]
    public int Fuel { get; set; }
    [Column("SPEED")]
    public int Speed { get; set; }
    [Column("ALTITUDE")]
    public int Altitude { get; set; }
    [MaxLength(200)]
    [Column("NAME")]
    public string Name { get; set; }
}
