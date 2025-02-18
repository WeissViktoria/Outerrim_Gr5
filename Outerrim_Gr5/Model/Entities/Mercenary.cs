using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("MERCENARIES")]
public class Mercenary //Söldner
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("MERCENARY_ID")]
    public int Id { get; set; }
    [Required, StringLength(50)]
    [Column("FIRST_NAME")]
    public string FirstName { get; set; }
    [Required, StringLength(50)]
    [Column("LAST_NAME")]
    public string LastName { get; set; }
    [Required, Range(0, 10)]
    [Column("BODY_SKILL")]
    public int BodySkill { get; set; }
    [Required, Range(0,10)]
    [Column("COMBAT_SKILL")]
    public int CombatSkill { get; set; }
}