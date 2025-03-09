using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("COMPARTMENTS")]
public class Compartment
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("COMPARTMENT_ID")]
    public int Id { get; set; }
    public Aircraft Aircraft { get; set; }
    [Column("AIRCRAFT_ID")]
    public int Aircraft_Id { get; set; }
    [Required, StringLength(50)]
    [Column("NAME")]
    public string Name { get; set; }
}