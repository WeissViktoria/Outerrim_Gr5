using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("MACHINERIES_BT")]
public class Machinery
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("MACHINERY_ID")]
    public int Id { get; set; }
    
    public Compartment Compartment { get; set; }
    
    [Column("COMPARTMENT_ID")]
    public int Compartment_Id { get; set; }
    [Required, StringLength(100)]
    [Column("LABEL")]
    public string Label { get; set; }
    
    [Required, DataType(DataType.Text)]
    [Column("FUNCTION")]
    public string Function { get; set; }
}
