using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("AIRCRAFT_CREW_JT")]
public class Crew
{
    public Aircraft Aircraft { get; set; }
    [Column("AIRCRAFT_ID")]
    public int Aircraft_Id { get; set; }
    
    public Mercenary Mercenary { get; set; }
    [Column("MERCENARY_ID")]
    public int Mercenary_Id { get; set; }
}