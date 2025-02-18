using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("CRIME_SYNDICATES")]
public class CrimeSyndicate
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("SYNDICATE_ID")]
    public int Id { get; set; }
    [Required, StringLength(100)]
    [Column("NAME")]
    public string Name { get; set; }
    [Required, StringLength(200)]
    [Column("LOCATION")]
    public string Location { get; set; }
}