using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("COMPARTMENT")]
public class Compartment
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("COMPARTMENT_ID")]
    public int Id { get; set; }
    public Aircraft Aircraft { get; set; }
    [Column("AIRCRAFT_ID")]
    public int Aircraft_Id { get; set; }
}