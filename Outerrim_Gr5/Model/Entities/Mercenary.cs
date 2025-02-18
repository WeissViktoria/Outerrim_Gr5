using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("MERCENARIES")]
public class Mercenary
{//Söldner
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("MERCENARY_ID")]
    public int Id { get; set; }
}