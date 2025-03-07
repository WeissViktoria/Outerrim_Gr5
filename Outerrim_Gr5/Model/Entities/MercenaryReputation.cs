using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("MERCENARY_HAS_REPUTATIONS_JT")]
public class MercenaryReputation {
    
    public Mercenary Mercenary { get; set; }
    [Column("MERCENARY_ID")] 
    public int MercenaryId { get; set; }
    
    public CrimeSyndicate CrimeSyndicate { get; set; }
    [Column("CRIME_SYNDICATE_ID")]
    
    public int CrimeSynicateId { get; set; }

}