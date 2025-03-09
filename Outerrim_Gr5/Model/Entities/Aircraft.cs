﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("AIRCRAFTS")]
public class Aircraft
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("AIRCRAFT_ID")]
    public int ID { get; set; }

    public AircraftSpezifikation Spezifikation { get; set; }

    [Column("SPECIFICATION_ID")] 
    public int SpezifikationId { get; set; }

    [Required, Range(0, 100)]
    [Column("FUEL")]
    public int Fuel { get; set; }

    [Required, Range(0, 100)]
    [Column("SPEED")]
    public int Speed { get; set; }

    [Column("ALTITUDE")] 
    public int Altitude { get; set; }
    [StringLength(100), Required] 
    [Column("NAME")] 
    public string Name { get; set; }
    public List<Compartment> Compartments { get; set; }
    public List<Crew> CrewItems { get; set; }
}
